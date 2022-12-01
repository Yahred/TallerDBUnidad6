using Biblioteca.Entidades;
using Biblioteca.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Front
{
    public partial class frmMenu : Form
    {
        private const int CELDA_CLAVE = 2;
        private const int EDITAR = 0;
        private const int ELIMINAR = 1;
        private Thread spinner;

        public frmMenu()
        {
            InitializeComponent();
            llenarComboFamilias();

            boxSpinner.ImageLocation = "C:\\Users\\DrYah\\Desktop\\DB\\InterfazVentas\\Assets\\spinner.gif";
            boxSpinner.SizeMode = PictureBoxSizeMode.StretchImage;

            llenarGrid(); 
            DataGridViewButtonColumn botonesEditar = new DataGridViewButtonColumn();
            botonesEditar.HeaderText = "Editar";
            botonesEditar.Text = "Editar";
            botonesEditar.UseColumnTextForButtonValue = true;
            dgvPrincipal.Columns.Add(botonesEditar);


            DataGridViewButtonColumn botonesEliminar = new DataGridViewButtonColumn();
            botonesEliminar.HeaderText = "Eliminar";
            botonesEliminar.Text = "Eliminar";
            botonesEliminar.UseColumnTextForButtonValue = true;
            dgvPrincipal.Columns.Add(botonesEliminar);


        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoArticulo nuevoArticulo = new frmNuevoArticulo();
            nuevoArticulo.ShowDialog();
        }

        private void llenarGrid()
        {
            try
            {
                NArticulos articulosN = new NArticulos();
                var grid = articulosN.ObtenerGridArticulos(this.ObtenerFiltros());
                dgvPrincipal.DataSource = grid;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show("Ocurrió un error al llenar la tabla de consulta", "ERROR");
            }
        }

        private Articulo ObtenerFiltros()
        {
            Articulo filtro = new Articulo
            {
                ID = txtClave.Text.Length > 0 ? int.Parse(txtClave.Text) : 0,
                Nombre = txtNombre.Text.Length > 0 ? txtNombre.Text : "",
                Precio = txtPrecio.Text.Length > 0 ? decimal.Parse(txtPrecio.Text) : 0,
                Familia = new Familia
                {
                    ID = int.Parse(cmbFamilia.SelectedValue.ToString()),
                    Nombre = cmbFamilia.Text
                }
            };

            return filtro;
        }

        private void llenarComboFamilias()
        {
            try
            {
                NFamilias familiasN = new NFamilias();
                var comboFamilias = new List<Familia>().Append(new Familia
                {
                    ID = 0,
                    Nombre = "Todas"
                }).Concat(familiasN.getFamilias()).ToList();

                cmbFamilia.DataSource = comboFamilias;
                cmbFamilia.DisplayMember = "Nombre";
                cmbFamilia.ValueMember = "ID";
                cmbFamilia.SelectedIndex = 0;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error al llenar el combo de familias", "ERROR");
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Refresh();
            this.llenarGrid();
        }

        private void dgvPrincipal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == ELIMINAR) 
            {
                EliminarRegistro(e.RowIndex);
                return;
            }

            if(e.ColumnIndex == EDITAR) 
            {
                EditarRegistro(e.RowIndex);
            }
        }

        private void EliminarRegistro(int index)
        {
           int artID = Convert.ToInt32(dgvPrincipal.Rows[index].Cells[CELDA_CLAVE].Value);
            try
            {
                NArticulos articuloN = new NArticulos();
                if(articuloN.EliminarArticulo(artID))
                {
                    MessageBox.Show($"Se eliminó el artículo con Clave {artID} correctamente", "Éxito");
                    llenarGrid();
                    return;
                }
                MessageBox.Show($"Ocurrió un error al artículo con Clave {artID} correctamente", "Error");
            }
            catch
            {
                MessageBox.Show("Ocurrió un error", "Error");
            }
        }

        private void EditarRegistro(int index)
        {
            int artID = Convert.ToInt32(dgvPrincipal.Rows[index].Cells[CELDA_CLAVE].Value);

            try
            {
                NArticulos articulosN = new NArticulos();
                Articulo articulo = articulosN.ObtenerArticuloPorID(artID);
                frmNuevoArticulo frmNuevoArticulo = new frmNuevoArticulo(articulo);
                frmNuevoArticulo.ShowDialog();
                llenarGrid();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);  
                MessageBox.Show("Ocurrió un error");
            }
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
