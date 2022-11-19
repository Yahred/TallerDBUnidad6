using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Negocios;
using Biblioteca.Entidades;

namespace Biblioteca.Front
{
    public partial class frmCambiarTitulo : Form
    {
        public frmCambiarTitulo()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //VALIDACIONES
            if (Validar() == true)
            {
                //todo correcto
            }
            else
            {
                MessageBox.Show("Error detectado");
                return;
            }

            string titulo = txtTitulo.Text;
            string isbn = Variables.ISBN;

            try
            {
                NLibro.CambiarTitulo(isbn,titulo);
                MessageBox.Show("Titulo Cambiado");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR");
            }


        }
        public bool Validar()
        {
            bool correcto = true;

            //validar titulo
            string titulo = txtTitulo.Text;
            if (ValidarTexto(titulo))
            {
                errorP.SetError(txtTitulo, "");
                if (ValidarSoloLetrasONumeros(titulo))
                {
                    errorP.SetError(txtTitulo, "");
                }
                else
                {
                    errorP.SetError(txtTitulo, "Solo se aceptan letras o numeros");
                    correcto = false;
                }
            }
            else
            {
                errorP.SetError(txtTitulo, "Titulo vacio");
                correcto = false;
            }

            
            return correcto;
        }

        public bool ValidarTexto(string texto)
        {
            bool correcto = true;
            if (string.IsNullOrWhiteSpace(texto))
            {
                correcto = false;
            }
            return correcto;
        }
        public bool ValidarSoloNumeros(string texto)
        {
            bool correcto = true;
            foreach (char c in texto)
            {
                if (char.IsLetter(c))
                {
                    correcto = false;
                }
            }
            return correcto;
        }
        public bool ValidarSoloLetras(string texto)
        {
            bool correcto = true;
            foreach (char c in texto)
            {
                if (char.IsDigit(c))
                {
                    correcto = false;
                }
            }
            return correcto;
        }
        public bool ValidarSoloLetrasONumeros(string texto)
        {
            bool correcto = true;
            foreach (char c in texto)
            {
                if (char.IsLetterOrDigit(c) || c == ' ')
                {

                }
                else
                {
                    correcto = false;
                }
            }
            return correcto;
        }
    }
}
