using Biblioteca.Entidades;
using Biblioteca.Negocios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca.Front
{
    public partial class frmNuevoArticulo : Form
    {
        public frmNuevoArticulo()
        {
            InitializeComponent();
            LlenarComboFamilias();
            cmbFamilia.SelectedIndex = 0;
            txtClave.Visible = false;
            lblClave.Visible = false;
        }

        public frmNuevoArticulo(Articulo articulo)
        {
            InitializeComponent();
            LlenarComboFamilias();
            txtClave.Visible = true;
            lblClave.Visible = true;
            txtClave.Enabled = false;
            txtClave.Text = $"{articulo.ID}";
            txtNombre.Text = articulo.Nombre;
            txtDesc.Text = articulo.Descripcion;
            txtPrecio.Text = articulo.Precio + "";
            cmbFamilia.SelectedText = articulo.Familia.Nombre;
            cmbFamilia.SelectedValue = articulo.Familia.ID;
        }

        private void LlenarComboFamilias()
        {
            NFamilias familiaN = new NFamilias();
            cmbFamilia.DisplayMember = "Nombre";
            cmbFamilia.ValueMember = "ID";
            cmbFamilia.DataSource = familiaN.getFamilias();
        }

        private bool ValidarCampos()
        {
            if(txtNombre.Text.Length == 0)
            {
                MessageBox.Show("El Nombre no puede quedar vacío", "ERROR");
                return false;
            } 
                
            if(txtDesc.Text.Length == 0)
            {
                MessageBox.Show("La descripción no puede quedar vacía", "ERROR");
                return false;
            };

            try
            {
                decimal precio = Decimal.Parse(txtPrecio.Text);
                if (precio <= 0) return false;
            }
            catch
            {
                MessageBox.Show("El precio debe ser numérico", "ERROR");
                return false;
            }


            return true;
        } 

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(!ValidarCampos())
            {
                return;
            }

            Familia familiaSeleccionada = new Familia
            {
                ID = int.Parse(cmbFamilia.SelectedValue.ToString()),
                Nombre = cmbFamilia.Text
            };

            Articulo articulo = new Articulo
            {
                ID = txtClave.Text.Length > 0 ? Convert.ToInt32(txtClave.Text) : 0,
                Nombre = txtNombre.Text,
                Descripcion = txtDesc.Text,
                Precio = Decimal.Parse(txtPrecio.Text),
                Familia = familiaSeleccionada
            };

            NArticulos articulosN = new NArticulos();
            int artID = articulosN.RegistrarArticulo(articulo);

            if(artID == 0)
            {
                MessageBox.Show("Ocurrió un error al registrar nuevo artículo", "Error");
                return;
            }

            if(artID == articulo.ID)
            {
                MessageBox.Show($"Se editó el registro del artículo con el id {artID} exitosamente", "Éxito");
                this.Close();
                return;
            }

            MessageBox.Show($"Se registro el nuevo artículo con el id {artID} exitosamente", "Éxito");
            this.Close();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
