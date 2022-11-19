using System;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.Entidades;

namespace Biblioteca.Datos
{
    public class DUsuario
    {
        public static DataTable ObtenerUsuarios()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Usuario_Listar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                lector = comando.ExecuteReader();
                tabla.Load(lector);
                return tabla;
            }
            catch(Exception ex)
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
        public static string BuscarClave(string clave)
        {
            SqlConnection conn = null;
            string respuesta = "";
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Usuario_ExisteClave", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@valor", SqlDbType.NVarChar).Value = clave;
                SqlParameter parExiste = new SqlParameter();
                parExiste.ParameterName = "@existe";
                parExiste.SqlDbType = SqlDbType.Int;
                parExiste.Direction = ParameterDirection.Output;
                comando.Parameters.Add(parExiste);
                comando.ExecuteNonQuery();
                respuesta = Convert.ToString(parExiste.Value);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                if(conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return respuesta;
        }

        public static string Agregar(Usuario usuario)
        {
            string respuesta = " ";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Usuario_Agregar",conn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@ClaveUsuario",usuario.pClave);
                comando.Parameters.AddWithValue("@NombreUsuario",usuario.pNombre);
                comando.Parameters.AddWithValue("@Edad",usuario.pEdad);
                comando.Parameters.AddWithValue("@TipoUsuario",usuario.pTipo);

                if(comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "OK";
                }
                else
                {
                    respuesta = "No se pudo agregar";
                }
            }
            catch(Exception ex)
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
        public static DataTable BuscarUsuario(string texto)
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Usuario_Buscar", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@valor",SqlDbType.NVarChar).Value = texto;
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
        public static DataTable RegresaTipoUsuario(string clave)
        {
            SqlConnection conn = null;
            DataTable tabla = new DataTable();
            SqlDataReader lector = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Usuario_RegresaTipo", conn);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@valor", SqlDbType.NVarChar).Value = clave;
                lector = comando.ExecuteReader();
                tabla.Load(lector);
                return tabla;
            }
            catch(Exception ex)
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
