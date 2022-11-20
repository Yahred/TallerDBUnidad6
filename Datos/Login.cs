using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Datos
{
    public class Login
    {
        public static bool LogIn(string username, string password)
        {
            Conexion.CrearConexion(username, password);
            if(Conexion.Connection == null)
            {
                return false;
            }

            return true;
           
        }
    }
}
