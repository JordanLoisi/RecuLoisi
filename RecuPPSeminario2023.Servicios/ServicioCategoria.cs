using RecuPPSeminario2023.Datos.interfaces;
using RecuPPSeminario2023.Datos.Repositorio;
using RecuPPSeminario2023.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RecuPPSeminario2023.Servicios
{
    public class ServicioCategoria:IServiciosCategoria
    {
        private readonly IRepositorioCategoria _servicio;
        public ServicioCategoria()
        {
            _servicio = new Repocategoria();
        }

        public void Borrar(int CategoriaId)
        {
            try
            {
                _servicio.Borrar(CategoriaId);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool EstaRelacionado(Categoria categoria)
        {
            throw new NotImplementedException();
        }

        public bool Existe(Categoria categoria)
        {
            try
            {
                return _servicio.Existe(categoria);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(string textoFiltro)
        {
            try
            {
                return _servicio.GetCantidad(textoFiltro);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Categoria> GetCategoria()
        {
            try
            {
                return _servicio.GetCategoria();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Guardar(Categoria categoria)
        {
            try
            {
                if (categoria.CategoriaId == 0)
                {
                    _servicio.Agregar(categoria);
                }
                else
                {
                    _servicio.Editar(categoria);
                }

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
