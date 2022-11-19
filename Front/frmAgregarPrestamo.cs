using System;
using System.Windows.Forms;
using Biblioteca.Entidades;
using Biblioteca.Negocios;

namespace Biblioteca.Front
{
    public partial class frmAgregarPrestamo : Form
    {
        public frmAgregarPrestamo()
        {
            InitializeComponent();
        }

        private void btnBuscarC_Click(object sender, EventArgs e)
        {
            frmBusquedaUsuario ventana = new frmBusquedaUsuario();
            ventana.ShowDialog();
            txtID.Text = Convert.ToString(Variables.ClaveUsuario);
            txtNombre.Text = Convert.ToString(Variables.Nombre);
        }

        private void txtISBN_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscarL_Click(object sender, EventArgs e)
        {
            frmBusquedaLibro ventana = new frmBusquedaLibro();
            ventana.ShowDialog();
            txtISBN.Text = Convert.ToString(Variables.ISBN);
            txtTitulo.Text = Convert.ToString(Variables.Titulo);
            txtAutor.Text = Convert.ToString(Variables.Autor);
            txtEditorial.Text = Convert.ToString(Variables.Editorial);
            txtExistencia.Text = Convert.ToString(Variables.Existencia);
            txtTipo.Text = Convert.ToString(Variables.TipoUsuario);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {  
            if(Validar())
            {
                string isbn = txtISBN.Text;
                string claveUsuario = txtID.Text;
                int nuevaExistencia = Convert.ToInt32(txtExistencia.Text) - 1;

                Prestamo prestamo = new Prestamo(isbn,claveUsuario);

                try
                {
                    string respuesta = NPrestamo.Agregar(prestamo);
                    NLibro.ActualizarExistencia(isbn,nuevaExistencia);
                    MessageBox.Show("Prestamo Agregado");

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
                Limpiar();

                //MessageBox.Show("Agregado Correctamente");
            }
            else
            {
                MessageBox.Show("Error Detectado");
            }
        }
        public bool Validar()
        {
            bool correcto = true;
            if (ValidarSeleccion() == false)
            {
                correcto = false;
            }
            else
            {
                if (ValidarTipo() == false)
                {
                    correcto = false;
                }
                else
                {
                    if(Convert.ToInt32(txtExistencia.Text) <= 0)
                    {
                        correcto = false;
                        MessageBox.Show("No hay libros disponibles");
                    }
                }
            }
            
            return correcto;
        }
        public bool ValidarSeleccion()
        {
            bool correcto = true;
            if (string.IsNullOrWhiteSpace(txtEditorial.Text))
            {
                MessageBox.Show("No a seleccionado un libro");
                correcto = false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("No a seleccionado un usuario");
                correcto = false;
            }
            return correcto;
        }

        public bool ValidarTipo()
        {
            bool correcto = false;
            string tipo = Variables.UsuarioTipoUsuario;
            if (txtTipo.Text.Equals("Ambos"))
            {
                correcto = true;
            }
            else if (txtTipo.Text.Equals("Solo Maestros") && tipo.Equals("MAESTRO"))
            {
                correcto = true;
            }
            else if (txtTipo.Text.Equals("Solo Alumnos") && tipo.Equals("ALUMNO"))
            {
                correcto = true;
            }
            else
            {
                MessageBox.Show("Incompatibilidad entre el tipo de usuario y el tipo de prestamo del libro");
                correcto = false;
            }

            return correcto;
        }

        public void Limpiar()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtISBN.Text = "";
            txtTitulo.Text = "";
            txtAutor.Text = "";
            txtExistencia.Text = "";
            txtEditorial.Text = "";
            txtTipo.Text = "";
        }
    }
}
