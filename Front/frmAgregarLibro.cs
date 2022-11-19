using System;
using System.Windows.Forms;
using Biblioteca.Negocios;
using Biblioteca.Entidades;

namespace Biblioteca.Front
{
    public partial class frmAgregarLibro : Form
    {
        public frmAgregarLibro()
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

            //ontener variables del libro
            string isbn = txtISBN.Text;
            string titulo = txtTitulo.Text;
            string respuesta = "";
            
            try
            {
                respuesta = NLibro.BuscarTitulo(titulo);
                if (respuesta.Equals("Existe"))
                {
                    errorP.SetError(txtTitulo, "Titulo duplicado");
                    MessageBox.Show("Titulo Duplicado");
                    return;
                }
                else
                {
                    errorP.SetError(txtTitulo, "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return;
            }

            string autor = txtAutor.Text;
            string editorial = cmbEditorial.SelectedItem.ToString();
            byte existencia = Convert.ToByte(txtExistencia.Text);
            bool tipoPrestamo = ObtenerTipoPrestamo();
            char tipoUsuario = ObtenerTipoUsuario();

            Libro libro = new Libro(isbn,titulo,autor,editorial,existencia,tipoPrestamo,tipoUsuario);

            try
            {
                //obtener respuesta del negocio
                respuesta = NLibro.Agregar(libro);
                if (respuesta.Equals("OK"))
                {
                    MessageBox.Show("Libro agregado");
                }
                if (respuesta.Equals("Existe"))
                {
                    errorP.SetError(txtISBN, "ISBN duplicado");
                    MessageBox.Show("Error detectado");
                    return;
                }
                else
                {
                    errorP.SetError(txtISBN, "");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
                return;
            }

            Limpiar();
        }
        public bool Validar()
        {
            bool correcto = true;

            //validar isbn
            string isbn = txtISBN.Text;
            if (ValidarTexto(isbn))
            {
                errorP.SetError(txtISBN, "");
                if (ValidarSoloNumeros(isbn))
                {
                    errorP.SetError(txtISBN, "");
                    //validar longitud completa
                    if (ValidarLongitudDeISBN(txtISBN.Text))
                    {
                        errorP.SetError(txtISBN, "");
                    }
                    else
                    {
                        errorP.SetError(txtISBN, "El ISBN debe tener 13 caracteres");
                        correcto = false;
                    }
                }
                else
                {
                    errorP.SetError(txtISBN, "Solo se aceptan numeros");
                    correcto = false;
                }
            }
            else
            {
                errorP.SetError(txtISBN, "ISBN vacio");
                correcto = false;
            }

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

            //validar autor
            string autor = txtAutor.Text;
            if (ValidarTexto(autor))
            {
                errorP.SetError(txtAutor, "");
                if (ValidarSoloLetrasONumeros(autor))
                {
                    errorP.SetError(txtAutor, "");
                }
                else
                {
                    errorP.SetError(txtAutor, "Solo se aceptan letras");
                    correcto = false;
                }
            }
            else
            {
                errorP.SetError(txtAutor, "Autor vacio");
                correcto = false;
            }

            //validar existencia
            string existencia = txtExistencia.Text;
            if (ValidarTexto(existencia))
            {
                errorP.SetError(txtExistencia, "");
                if (ValidarSoloNumeros(existencia))
                {
                    errorP.SetError(txtExistencia, "");
                    if (Convert.ToInt32(txtExistencia.Text) > 0)
                    {
                        errorP.SetError(txtExistencia, "");
                    }
                    else
                    {
                        errorP.SetError(txtExistencia, "La existenciad debe ser mayor a 0");
                        correcto = false;
                    }
                }
                else
                {
                    errorP.SetError(txtExistencia, "Solo se aceptan numeros");
                    correcto = false;
                }
            }
            else
            {
                errorP.SetError(txtExistencia, "Existencia vacio");
                correcto = false;
            }

            //validar tipoUsiario
            if(ckbMaestro.Checked == false && ckbEstudiante.Checked == false)
            {
                correcto = false;
                errorP.SetError(gpbTipoUsuario,"Se necesita seleccionar minimo un tipo de usuario");
            }
            else
            {
                errorP.SetError(gpbTipoUsuario, "");
            }

            return correcto;
        }
        public bool ValidarTexto(string texto)
        {
            bool correcto=true;
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

        public bool ValidarLongitudDeISBN(string texto)
        {
            bool correcto = true;
            if(texto.Length != 13)
            {
                correcto = false;
            }
            return correcto;
        }
        public bool ObtenerTipoPrestamo()
        {
            bool interno = true;
            if (rdbInterno.Checked == false)
            {
                interno = false;
            }
            else
            {
                interno = true;
            }
            return interno;
        }
        public char ObtenerTipoUsuario()
        {
            char tipo = '0';
            if (ckbEstudiante.Checked==true && ckbMaestro.Checked==false)
            {
                tipo = '1';
            }
            else if (ckbEstudiante.Checked == true && ckbMaestro.Checked == true)
            {
                tipo = '2';
            }
            return tipo;
        }
        public void Limpiar()
        {
            cmbEditorial.SelectedIndex = 0;

            txtAutor.Text = "";
            txtExistencia.Text = "";
            txtISBN.Text = "";
            txtTitulo.Text = "";

            rdbInterno.Checked = true;
            rdbExterno.Checked = false;

            ckbEstudiante.Checked = false;
            ckbMaestro.Checked = true;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void frmAgregarLibro_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void rdbInterno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbExterno.Checked)
            {
                rdbInterno.Checked = false;
            }
            else
            {
                rdbExterno.Checked = false;
            }
        }

        private void rdbExterno_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbExterno.Checked)
            {
                rdbInterno.Checked = false;
            }
            else
            {
                rdbExterno.Checked = false;
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultaLibro verLibros = new frmConsultaLibro();
            verLibros.ShowDialog();
        }
    }
}
