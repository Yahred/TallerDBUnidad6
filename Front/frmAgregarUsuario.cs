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
    public partial class frmAgregarUsuario : Form
    {
        public frmAgregarUsuario()
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

            //Obtener variables
            string clave = txtClave.Text;

            try
            {
                string retorno = NUsuario.BuscarClave(clave);
                if (retorno.Equals("Existe"))
                {
                    errorP.SetError(txtClave,"Clave Duplicada");
                    MessageBox.Show("Error Detectado");
                    return;
                }
                else
                {
                    errorP.SetError(txtClave, "");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

            string nombre = txtNombre.Text;
            int edad = Convert.ToInt32(txtEdad.Text);
            char tipo = ObtenerTipoUsuario();

            Usuario usuario = new Usuario(clave,nombre,edad,tipo);

            try
            {
                string respuesta = NUsuario.Agregar(usuario);
                MessageBox.Show("Usuario Agregado");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
            Limpiar();
        }
        public bool Validar()
        {
            //validar clave
            bool correcto = true;

            if (ValidarTexto(txtClave.Text))
            {
                errorP.SetError(txtClave,"");
                if (ValidarSoloNumeros(txtClave.Text))
                {
                    errorP.SetError(txtClave, "");
                    if (ValidarLongitudDeClave(txtClave.Text))
                    {
                        errorP.SetError(txtClave, "");
                    }
                    else
                    {
                        errorP.SetError(txtClave, "La clave debe medir 5 caracteres");
                        correcto = false;
                    }
                }
                else
                {
                    errorP.SetError(txtClave, "Solo se aceptan numeros");
                    correcto = false;
                }
            }
            else
            {
                errorP.SetError(txtClave,"Clave Vacia");
                correcto = false;
            }

            //validar nombre
            if(ValidarTexto(txtNombre.Text))
            {
                errorP.SetError(txtNombre, "");
                if (ValidarSoloLetras(txtNombre.Text))
                {
                    errorP.SetError(txtNombre, "");
                }
                else
                {
                    errorP.SetError(txtNombre, "Solo se aceptan letras");
                    correcto = false;
                }
            }
            else
            {
                errorP.SetError(txtNombre,"Nombre vacio");
                correcto = false;
            }

            //validar edad
            if (ValidarTexto(txtEdad.Text))
            {
                errorP.SetError(txtEdad,"");
                if (ValidarSoloNumeros(txtEdad.Text))
                {
                    errorP.SetError(txtEdad, "");
                }
                else
                {
                    errorP.SetError(txtEdad, "Solo se aceptan numeros");
                    correcto = false;
                }
            }
            else
            {
                errorP.SetError(txtEdad,"Edad vacia");
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
        public bool ValidarLongitudDeClave(string texto)
        {
            bool correcto = true;
            if (texto.Length != 5)
            {
                correcto = false;
            }
            return correcto;
        }
        public char ObtenerTipoUsuario()
        {
            if (rdbEstudiante.Checked)
            {
                return '1';
            }
            else
            {
                return '0';
            }
        }
        public void Limpiar()
        {
            txtClave.Text = "";
            txtNombre.Text = "";
            txtEdad.Text = "";

            rdbEstudiante.Checked = true;
            rdbMaestro.Checked = false;
        }

        private void rdbEstudiante_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEstudiante.Checked)
            {
                rdbMaestro.Checked = false;
            }
            else
            {
                rdbMaestro.Checked = true;
            }
        }
    }
}
