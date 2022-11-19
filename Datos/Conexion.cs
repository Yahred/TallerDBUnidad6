using System;

using System.Data.SqlClient;
using System.Configuration;


namespace Biblioteca.Datos
{
    public class Conexion
    {
        public static SqlConnection CrearConexion()
        {           
            //string strConn = "Data Source=DESKTOP-FNOF9G8\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";
            string strConn = "Data Source=USER-PC;Initial Catalog=Biblioteca;Integrated Security=True";

            //string strConn = GetConnectionString();

            SqlConnection conn;
            try
            {
                conn = LibreriaBD.UsoBD.ConectaBD(strConn);
            }
            catch (Exception ex)
            {
                conn = null;
                throw ex;
            }
            return conn;
        }

        public static string GetConnectionString()
        {
            string strConn = "";
            try
            {
                strConn = ConfigurationManager.ConnectionStrings["conStrBD"].ConnectionString;
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return strConn;
        }
    }
}
