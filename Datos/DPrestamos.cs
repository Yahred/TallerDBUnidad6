using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Biblioteca.Entidades;

namespace Biblioteca.Datos
{
    public class DPrestamos
    {
        public static DataTable ObtenerPrestamos()
        {
            SqlDataReader lector = null;
            DataTable tabla = new DataTable();
            SqlConnection conn = null;

            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Prestamo_Listar",conn);
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
        public static string Agregar(Prestamo prestamo)
        {
            string respuesta = " ";
            SqlConnection conn = null;
            try
            {
                conn = Conexion.CrearConexion();
                SqlCommand comando = new SqlCommand("Prestamo_Agregar", conn);
                comando.CommandType = CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@ClavePrestamo", prestamo.pClavePrestamo);
                comando.Parameters.AddWithValue("@ISBN", prestamo.pISBN);
                comando.Parameters.AddWithValue("@ClaveUsuario", prestamo.pClaveUsuario);

                if (comando.ExecuteNonQuery() == 1)
                {
                    respuesta = "OK";
                }
                else
                {
                    respuesta = "No se pudo agregar";
                }
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
    }
}
