using System;
using System.Data;
using System.Windows.Forms;
using Biblioteca.Negocios;
using Biblioteca.Entidades;

namespace Biblioteca.Front
{
    public partial class frmConsultaLibroIndividual : Form
    {
        DataTable tabla;
        public frmConsultaLibroIndividual()
        {
            InitializeComponent();
        }

        private void frmConsultaLibroIndividual_Load(object sender, EventArgs e)
        {
            try
            {
                tabla = NLibro.ObtenerLibros();
                cmbISBN.DataSource = tabla;
                this.cmbISBN.DisplayMember = "ISBN";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void cmbISBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            string isbnSeleccionado = cmbISBN.GetItemText(cmbISBN.SelectedItem);
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                string isbnTabla = tabla.Rows[i][0].ToString();
                if (isbnTabla.Equals(isbnSeleccionado))
                {
                    string titulo = tabla.Rows[i][1].ToString();
                    string autor = tabla.Rows[i][2].ToString();
                    string existencia = tabla.Rows[i][3].ToString();
                    string editorial = tabla.Rows[i][4].ToString();
                    string consulta = tabla.Rows[i][5].ToString();
                    string usuario = tabla.Rows[i][6].ToString();
                    
                    LlenarCampos(titulo, autor,existencia,editorial,consulta,usuario);
                }
            } 
        }
        public void LlenarCampos(string titulo,string autor,string existencia,string editorial,string consulta,string usuario)
        {
            txtTitulo.Text = titulo;
            txtAutor.Text = autor;
            txtExistencia.Text = existencia;
            txtEditorial.Text = editorial;
            txtConsulta.Text = consulta;
            txtTipoUsuario.Text = usuario;
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que quiere borrar el Libro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if(resultado == DialogResult.Yes)
            {
                string isbn = cmbISBN.GetItemText(cmbISBN.SelectedItem);
                NLibro.Eliminar(isbn);
                MessageBox.Show("Libro Eliminado");
            }
            else
            {
                MessageBox.Show("Accion Cancelada");
            }
        }

        private void btnCambiarTitulo_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Seguro que quiere cambiar el Titulo del Libro", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (resultado == DialogResult.Yes)
            {
                string isbn = cmbISBN.GetItemText(cmbISBN.SelectedItem);
                Variables.ISBN = isbn;
                frmCambiarTitulo titulo = new frmCambiarTitulo();
                titulo.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("Accion Cancelada");
            }
        }
    }
}
