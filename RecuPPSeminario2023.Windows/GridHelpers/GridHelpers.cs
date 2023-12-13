using RecuPPSeminario2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RecuPPSeminario2023.Windows.GridHelpers
{
    public static class GridHelpers
    {
        public static void LimpiarGrilla(DataGridView dgv)
        {
            dgv.Rows.Clear();
        }
        public static DataGridViewRow ConstruirFila(DataGridView dgv)
        {
            DataGridViewRow r = new DataGridViewRow();
            r.CreateCells(dgv);
            return r;

        }
        public static void SetearFila(DataGridViewRow r, object obj)
        {
            switch (obj)
            {
                case Categoria categoria:
                    r.Cells[0].Value = categoria.NombreCategoria ;
                    r.Cells[1].Value = categoria.Descripcion;
                    break;
            }
            r.Tag = obj;
        }
        public static void AgregarFila(DataGridView dgv, DataGridViewRow r)
        {
            dgv.Rows.Add(r);
        }

        public static void QuitarFila(DataGridView dgv, DataGridViewRow r)
        {
            dgv.Rows.Remove(r);
        }

        internal static void MostrarDatosEnGrilla<T>(DataGridView dgv, List<T> lista)
        {
            GridHelpers.LimpiarGrilla(dgv);
            foreach (var obj in lista)
            {
                DataGridViewRow r = GridHelpers.ConstruirFila(dgv);
                GridHelpers.SetearFila(r, obj);
                GridHelpers.AgregarFila(dgv, r);
            }
        }
    }
}
