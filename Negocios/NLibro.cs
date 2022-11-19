using System;

using System.Data;
using System.Data.SqlClient;
using Biblioteca.Datos;
using Biblioteca.Entidades;

namespace Biblioteca.Negocios
{
    public static class NLibro
    {
        public static DataTable ObtenerLibros()
        {
            return DLibro.ObtenerLibros();
        }

        public static string BuscarTitulo(string titulo)
        {
            string respuesta = "No Existe";
            string retorno = DLibro.BuscarTitulo(titulo);
            if (retorno.Equals("1"))
            {
                respuesta = "Existe";
            }
            return respuesta;
        }
        public static string BuscarISBN(string isbn)
        {
            string respuesta = "No Existe";
            string retorno = DLibro.BuscarISBN(isbn);
            if (retorno.Equals("1"))
            {
                respuesta = "Existe";
            }
            return respuesta;
        }
        public static string Agregar(Libro libro)
        {
            string respuesta = "OK";
            string retorno = DLibro.BuscarISBN(libro.pISBN);
            if (retorno.Equals("1"))
            {
                respuesta = "Existe";
            }
            else
            {
                DLibro.Agregar(libro);
            }
            return respuesta;
        }
        public static DataTable BuscarLibro(string texto)
        {
            return DLibro.BuscarLibro(texto);
        }
        public static void ActualizarExistencia(string isbn,int existencia)
        {
            DLibro.ActualizarExistencia(isbn,existencia);
        }
        public static void Eliminar(string isbn)
        {
            DLibro.Eliminar(isbn);
        }
        public static void CambiarTitulo(string isbn,string titulo)
        {
            DLibro.CambiarTitulo(isbn,titulo);
        }
    }

}
