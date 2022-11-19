using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Entidades
{
    public class Usuario
    {
        string ClaveUsuario;
        string Nombre;
        int Edad;
        char TipoUsuario;

        public Usuario(string clave, string nombre, int edad, char tipo)
        {
            ClaveUsuario = clave;
            Nombre = nombre;
            Edad = edad;
            TipoUsuario = tipo;
        }

        public string pClave
        {
            get
            {
                return ClaveUsuario;
            }
        }
        public string pNombre
        {
            get
            {
                return Nombre;
            }
        }
        public int pEdad
        {
            get
            {
                return Edad;
            }
        }
        public char pTipo
        {
            get
            {
                return TipoUsuario;
            }
        }
    }
}
