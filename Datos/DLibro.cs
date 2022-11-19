using System;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.Entidades;

namespace Biblioteca.Datos
{
    public static class DLibro
    {
        public static DataTable ObtenerLibros()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Libro_Listar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                lector = comando.ExecuteReader();
                tabla.Load(lector);
                return tabla;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }

        public static string BuscarTitulo(string titulo)
        {
            SqlConnection conn = null;
            string respuesta = " ";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Libro_ExisteTitulo", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = titulo;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                comando.ExecuteNonQuery();
                respuesta = Convert.ToString(parExiste.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return respuesta;
        }

        public static string BuscarISBN(string isbn)
        {
            SqlConnection conn = null;
            string respuesta = " ";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Libro_ExisteISBN", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("@valor", SqlDbType.VarChar).Value = isbn;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                comando.ExecuteNonQuery();
                respuesta = Convert.ToString(parExiste.Value);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open) conn.Close();
            }
            return respuesta;
        }

        public static string Agregar(Libro libro)
        {
            string respuesta = " ";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Libro_Insertar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                //insertar
                comando.Parameters.AddWithValue("@isbn", libro.pISBN);
                comando.Parameters.AddWithValue("@titulo", libro.pTitulo);
                comando.Parameters.AddWithValue("@autor", libro.pAutor);
                comando.Parameters.AddWithValue("@existencia", libro.pExistencia);
                comando.Parameters.AddWithValue("@editorial", libro.pEditorial);
                comando.Parameters.AddWithValue("@consulta", libro.pConsulta);
                comando.Parameters.AddWithValue("@tipoUsuario", libro.pTipoUsiario);

                respuesta = comando.ExecuteNonQuery() == 1 ? "OK" : "No se pudo registrar";
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return respuesta;
        }
        public static DataTable BuscarLibro(string texto)
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Libro_Buscar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@valor", SqlDbType.NVarChar).Value = texto;
                lector = comando.ExecuteReader();
                tabla.Load(lector);
                return tabla;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public static void ActualizarExistencia(string isbn, int existencia)
        {
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Libro_Actualizar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@isbn", SqlDbType.NVarChar).Value = isbn;
                comando.Parameters.AddWithValue("@valor", SqlDbType.TinyInt).Value = existencia;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public static void Eliminar(string isbn)
        {
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Libro_Eliminar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@valor", SqlDbType.NVarChar).Value = isbn;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
        public static void CambiarTitulo(string isbn, string titulo)
        {
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Libro_CambiarTitulo", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@isbn", SqlDbType.NVarChar).Value = isbn;
                comando.Parameters.AddWithValue("@valor", SqlDbType.NVarChar).Value = titulo;
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }
    }
}
