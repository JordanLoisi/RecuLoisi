using RecuPPSeminario2023.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecuPPSeminario2023.Windows
{
    public partial class frmCategoriaAE : Form
    {
        Categoria categoria;
        public frmCategoriaAE()
        {
            InitializeComponent();
        }

        private void frmCategoriaAE_Load(object sender, EventArgs e)
        {

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            if (categoria != null)
            {
                textNombreCategoria.Text = categoria.NombreCategoria;
                textDescripcion.Text = categoria.Descripcion;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                if (categoria == null)
                {
                    categoria = new Categoria();
                }
                categoria.NombreCategoria = textNombreCategoria.Text;
                categoria.Descripcion = textDescripcion.Text;
                DialogResult = DialogResult.OK;
            }
        }

        private bool ValidarDatos()
        {
            errorProvider1.Clear();
            bool valido = true;
            if (string.IsNullOrEmpty(textDescripcion.Text))
            {
                errorProvider1.SetError(textDescripcion, "Debe ingresar una dESCRIPCION");
                valido = false;
            }
            if (string.IsNullOrEmpty(textNombreCategoria.Text))
            {
                errorProvider1.SetError(textNombreCategoria, "Debe ingresar una Categoria");
                valido = false;
            }

            return valido;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        internal Categoria GetCategoria()
        {
            return categoria;
        }
        internal void SetCategoria(Categoria categoria)
        {
            this.categoria = categoria;
        }
    }
}
