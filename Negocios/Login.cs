using Biblioteca.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Negocios
{
    public class Login
    {
        public static bool Ingresar(string username, string password, string servidor, string BD)
        {
            try
            {
                Conexion.LogIn(username, password, servidor, BD);
                Conexion.CerrarConexion();
                return true;
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
