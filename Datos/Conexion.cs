using System;

using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Security;

namespace Biblioteca.Datos
{
    public class Conexion
    {
        private static SqlConnection _conexion { set; get; }
        public static SqlConnection Connection { 
            get
            {
                return _conexion;
            } 
            set 
            { 
                Connection = _conexion;       
            } 
        }

        public static SqlConnection CrearConexion()
        {   
            //string strConn = "Data Source=DESKTOP-FNOF9G8\\SQLEXPRESS;Initial Catalog=Biblioteca;Integrated Security=True";
            string strConn = $"Data Source=DESKTOP-F92EKB0; Initial Catalog=Biblioteca;Integrated Security=True";

            //string strConn = GetConnectionString();

            SqlConnection conn;
            try
            {
                conn = LibreriaBD.UsoBD.ConectaBD(strConn);
                _conexion = conn;
                Connection = conn;
            }
            catch (Exception ex)
            {
                conn = null;
                throw ex;
            }
            return conn;
        }

        public static SqlConnection CrearConexion(string username, string password)
        {
            string strConn = $"Data Source=DESKTOP-F92EKB0; Initial Catalog=Ventas;";
            SecureString passwordSecureString = new NetworkCredential(username, password).SecurePassword;
            passwordSecureString.MakeReadOnly();
            SqlConnection conn;
            SqlCredential credential = new SqlCredential(username, passwordSecureString);
            try
            {
                SqlConnection sqlConnection = new SqlConnection(strConn, credential);

                conn = sqlConnection;
                conn.Open();
                _conexion = conn;
                Console.WriteLine("Conexion establecida exitosamente");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
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
