using System;

using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Security;

namespace Biblioteca.Datos
{
    public class Conexion
    {
        private static string _usuario;
        private static string _password;
        private static SqlConnection sqlConexion;

        public static SqlConnection LogIn(string username, string password)
        {
            _usuario = username;
            _password = password;

            return ObtenerConexion();
        }

        public static SqlConnection ObtenerConexion()
        {
            string strConn = $"Data Source=DESKTOP-F92EKB0; Initial Catalog=Ventas;";
            SecureString passwordSecureString = new NetworkCredential(_usuario, _password).SecurePassword;
            passwordSecureString.MakeReadOnly();
            SqlConnection conn;
            SqlCredential credential = new SqlCredential(_usuario, passwordSecureString);
            try
            {
                SqlConnection sqlConnection = new SqlConnection(strConn, credential);

                conn = sqlConnection;
                conn.Open();
                sqlConexion = conn;
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

        public static void CerrarConexion()
        {
            if(sqlConexion!= null)
            {
                sqlConexion.Close();
            }
        }

    }
}
