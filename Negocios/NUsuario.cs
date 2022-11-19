using System;
using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocios
{
    public class NUsuario
    {
        public static DataTable ObtenerUsuarios()
        {
            return DUsuario.ObtenerUsuarios();
        }
        public static string BuscarClave(string clave)
        {
            string respuesta = "No Existe";
            string retorno = DUsuario.BuscarClave(clave);
            if (retorno.Equals("1"))
            {
                respuesta = "Existe";
            }
            return respuesta;
        }
        public static string Agregar(Usuario usuario)
        {
            string respuesta = "OK";
            
            DUsuario.Agregar(usuario);

            return respuesta;
        }
        public static DataTable BuscarUsuario(string texto)
        {
            return DUsuario.BuscarUsuario(texto);
        }
        public static DataTable RegresaTipoUsuario(string clave)
        {
            return DUsuario.RegresaTipoUsuario(clave);
        }
    }
}
