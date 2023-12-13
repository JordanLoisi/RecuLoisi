using Dapper;
using RecuPPSeminario2023.Datos.interfaces;
using RecuPPSeminario2023.Entidades;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RecuPPSeminario2023.Datos.Repositorio
{
    public class Repocategoria : IRepositorioCategoria
    {
        private readonly string cadenaConexion;

        public Repocategoria()
        {
            cadenaConexion = ConfigurationManager.ConnectionStrings["MiConexion"].ToString();
        }
        public void Agregar(Categoria categoria)
        {
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string insertQuery = "INSERT INTO Categorias (NombreCategoria,Descripcion) VALUES(@NombreCategoria,@Descripcion); SELECT SCOPE_IDENTITY()";
                conn.Open();
                using (var comando = new SqlCommand(insertQuery, conn))
                {
                    comando.Parameters.Add("@NombreCategoria", SqlDbType.NVarChar);
                    comando.Parameters["@NombreCategoria"].Value = categoria.NombreCategoria;

                    comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar);
                    comando.Parameters["@Descripcion"].Value = categoria.Descripcion;


                    int CategoriaId = Convert.ToInt32(comando.ExecuteScalar());
                    categoria.CategoriaId = CategoriaId;
                }
            }
        }

        public void Borrar(int CategoriaId)
        {
            try
            {
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string deleteQuery = "DELETE FROM Categorias WHERE CategoriaId=@CategoriaId";
                    using (var comando = new SqlCommand(deleteQuery, conn))
                    {
                        comando.Parameters.Add("@CategoriaId", SqlDbType.Int);
                        comando.Parameters["@CategoriaId"].Value = CategoriaId;

                        comando.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Editar(Categoria categoria)
        {
            try
            {
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string editQuery = "UPDATE Categorias SET NombreCategoria=@NombreCategoria,Descripcion=@Descripcion  WHERE CategoriaId=@CategoriaId";
                    using (var comando = new SqlCommand(editQuery, conn))
                    {
                        comando.Parameters.Add("@NombreCategoria", SqlDbType.NVarChar);
                        comando.Parameters["@NombreCategoria"].Value = categoria.NombreCategoria;

                        comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar);
                        comando.Parameters["@Descripcion"].Value = categoria.Descripcion;

                        

                        comando.ExecuteNonQuery();
                    }

                }
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
                int cantidad;
                using (var conn = new SqlConnection(cadenaConexion))
                {
                    conn.Open();
                    string selectQuery;
                    if (categoria.CategoriaId == 0)
                    {
                        selectQuery = "SELECT COUNT(*) FROM Categorias WHERE NombreCategoria=@NombreCategoria";
                    }
                    else
                    {
                        selectQuery = "SELECT COUNT(*) FROM Categorias WHERE NombreCategoria=@NombreCategoria AND CategoriaId!=@CategoriaId";
                    }
                    using (var comando = new SqlCommand(selectQuery, conn))
                    {
                        comando.Parameters.Add("@NombreCategoria", SqlDbType.NVarChar);
                        comando.Parameters["@NombreCategoria"].Value = categoria.NombreCategoria;

                        if (categoria.CategoriaId != 0)
                        {
                            comando.Parameters.Add("@CategoriaId", SqlDbType.Int);
                            comando.Parameters["@CategoriaId"].Value = categoria.CategoriaId;
                        }
                        cantidad = (int)comando.ExecuteScalar();
                    }
                }
                return cantidad > 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public int GetCantidad(string textoFiltro=null)
        {
            int cantidad = 0;
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery;
                if (textoFiltro == null)
                {
                    selectQuery = "SELECT COUNT(*) FROM Categorias";
                    cantidad = conn.ExecuteScalar< int >(selectQuery);
                }
            }
            return cantidad;
        }

        public List<Categoria> GetCategoria()
        {
            List<Categoria> lista = new List<Categoria>();
            using (var conn = new SqlConnection(cadenaConexion))
            {
                string selectQuery = @"SELECT CategoriaId, NombreCategoria,Descripcion FROM Categorias
                         ORDER BY NombreCategoria";
                conn.Open();
                using (var comando = new SqlCommand(selectQuery, conn))
                {
                    using (var reader = comando.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var categoria = ConstruirCategoria(reader);

                            lista.Add(categoria);
                        }

                    }
                }
            }
            return lista;
        }

        private Categoria ConstruirCategoria(SqlDataReader reader)
        {
            Categoria categoria = new Categoria()
            {
                CategoriaId = reader.GetInt32(0),
                NombreCategoria = reader.GetString(1),
                Descripcion=reader.GetString(2)
            };
            return categoria;
        }
    }
}
