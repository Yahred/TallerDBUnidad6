namespace Biblioteca.Entidades
{
    public class Prestamo
    {
        private int ClavePrestamo;
        private string ISBN;
        private string ClaveUsuario;

        private static int Clave = 6;

        public Prestamo( string isbn, string claveUsuario)
        {
            ClavePrestamo = Clave;
            ISBN = isbn;
            ClaveUsuario = claveUsuario;
            Clave++;
   
        }

        public int pClavePrestamo
        {
            get
            {
                return ClavePrestamo;
            }
            set
            {
                ClavePrestamo = pClavePrestamo;
            }
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
        public string pClaveUsuario
        {
            get
            {
                return ClaveUsuario;
            }
            set
            {
                ClaveUsuario = pClaveUsuario;
            }
        }
    }
}
