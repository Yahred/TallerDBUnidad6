using System;

namespace Biblioteca.Entidades
{
    public class Libro
    {
        private string ISBN;
        private string Titulo;
        private string Autor;
        private string Editorial;
        private byte Existencia;
        private bool Consulta;
        private char TipoUsuario;

        public Libro(string isbn, string titulo, string autor, string editorial, byte existencia, bool consulta, char tipoUsuario)
        {
            ISBN = isbn;
            Titulo = titulo;
            Autor = autor;
            Editorial = editorial;
            Existencia = existencia;
            Consulta = consulta;
            TipoUsuario = tipoUsuario;
        }

        public string pISBN
        {
            get
            {
                return ISBN;
            }
            set
            {
                ISBN = pISBN;
            }
        }
        public string pTitulo
        {
            get
            {
                return Titulo;
            }
            set
            {
                Titulo = pTitulo;
            }
        }
        public string pAutor
        {
            get
            {
                return Autor;
            }
            set
            {
                Autor = pAutor;
            }
        }
        public byte pExistencia
        {
            get
            {
                return Existencia;
            }
            set
            {
                Existencia = pExistencia;
            }
        }
        public string pEditorial
        {
            get
            {
                return Editorial;
            }
            set
            {
                Editorial = pEditorial;
            }
        }
        public bool pConsulta
        {
            get
            {
                return Consulta;
            }
            set
            {
                Consulta = pConsulta;
            }
        }
        public char pTipoUsiario
        {
            get
            {
                return TipoUsuario;
            }
            set
            {
                TipoUsuario = pTipoUsiario;
            }
        }
    }
}
