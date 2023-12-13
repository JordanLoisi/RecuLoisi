using RecuPPSeminario2023.Entidades;
using RecuPPSeminario2023.Servicios;
using RecuPPSeminario2023.Windows.GridHelpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuPPSeminario2023.Windows
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            _servicios = new ServicioCategoria();
        }
        private readonly ServicioCategoria _servicios;
        private List<Categoria> lista;



        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            MostrarDatosEnGrilla();
        }

        private void MostrarDatosEnGrilla()
        {
            dataGridView1.Rows.Clear();
            //MostrarCantidad();
            lista = _servicios.GetCategoria();
            foreach (var categoria in lista)
            {
                DataGridViewRow r = GridHelpers.GridHelpers.ConstruirFila(dataGridView1);
                GridHelpers.GridHelpers.SetearFila(r,categoria );
                GridHelpers.GridHelpers.AgregarFila(dataGridView1, r);
            }
        }

        private void MostrarCantidad()
        {
            //txtCantidad.Text = _servicios.GetCantidad().ToString;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCategoriaAE frm = new frmCategoriaAE();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            try
            {
                Categoria nuevaCategoria = frm.GetCategoria();
                if (!_servicios.Existe(nuevaCategoria))
                {
                    _servicios.Guardar(nuevaCategoria);
                    DataGridViewRow r = GridHelpers.GridHelpers.ConstruirFila(dataGridView1);
                    GridHelpers.GridHelpers.SetearFila(r, nuevaCategoria);
                    MostrarCantidad();
                    GridHelpers.GridHelpers.AgregarFila(dataGridView1, r);
                    MessageBox.Show("categoria agregado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("La categoria ya existe en la base de Datos", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void ButtonBorrar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dataGridView1.SelectedRows[0];
            Categoria categoria = (Categoria)r.Tag;
            try
            {
                //TODO: Se debe controlar que no este relacionado
                DialogResult dr = MessageBox.Show("¿Desea borrar el registro seleccionado?",
                    "Confirmar",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dr == DialogResult.No) { return; }
                _servicios.Borrar(categoria.CategoriaId);
                GridHelpers.GridHelpers.QuitarFila(dataGridView1, r);
                
                MessageBox.Show("Registro borrado", "Mensaje",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void ButtonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }
            var r = dataGridView1.SelectedRows[0];
            Categoria categoria = (Categoria)r.Tag;
            Categoria CategoriaCopia = (Categoria)categoria.Clone();
            try
            {
                frmCategoriaAE frm = new frmCategoriaAE();
                frm.SetCategoria(categoria);
                DialogResult dr = frm.ShowDialog(this);
                if (dr == DialogResult.Cancel) { return; }
                categoria = frm.GetCategoria();
                if (!_servicios.Existe(categoria))
                {
                    _servicios.Guardar(categoria);
                    GridHelpers.GridHelpers.SetearFila(r, categoria);
                    MessageBox.Show("Marca editado", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    GridHelpers.GridHelpers.SetearFila(r, CategoriaCopia);
                    MessageBox.Show("La marca ya existe", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                GridHelpers.GridHelpers.SetearFila(r, categoria);
                MessageBox.Show(ex.Message, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
