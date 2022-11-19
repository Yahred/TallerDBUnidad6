using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocios
{
    public class NPrestamo
    {
        public static DataTable ObtenerPrestamos()
        {
            return DPrestamos.ObtenerPrestamos();
        }
        public static string Agregar(Prestamo prestamo)
        {
            string respuesta = "OK";

            DPrestamos.Agregar(prestamo);

            return respuesta;
        }
    }
}
