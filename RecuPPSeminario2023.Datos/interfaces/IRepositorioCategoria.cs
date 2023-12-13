using RecuPPSeminario2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RecuPPSeminario2023.Datos.interfaces
{
    public interface IRepositorioCategoria
    {
        void Agregar(Categoria categoria);
        void Borrar(int CategoriaId);
        void Editar(Categoria categoria);
        bool Existe(Categoria categoria);
        int GetCantidad(string textoFiltro);
        List<Categoria> GetCategoria();
        bool EstaRelacionado(Categoria categoria);
    }
}
