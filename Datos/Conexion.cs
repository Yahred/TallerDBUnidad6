using System;

using System.Data.SqlClient;
using System.Configuration;


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
            string strConn = $"Data Source=DESKTOP-F92EKB0; User Id={username}; Password={password}; Initial Catalog=Ventas;Integrated Security=True";
            SqlConnection conn;
            try
            {
                conn = LibreriaBD.UsoBD.ConectaBD(strConn);
                _conexion = conn;
                Console.WriteLine("Conexion establecida exitosamente");
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
