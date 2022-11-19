using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Entidades;
using Biblioteca.Negocios;

namespace Biblioteca.Front
{
    public partial class frmBusquedaLibro : Form
    {
        DataTable tabla;
        public frmBusquedaLibro()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tabla = NLibro.BuscarLibro(txtBusqueda.Text);
            dgvBusqueda.DataSource = tabla;
        }

        private void dgvBusqueda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.ISBN = Convert.ToString(dgvBusqueda.CurrentRow.Cells["ISBN"].Value);
            Variables.Titulo = Convert.ToString(dgvBusqueda.CurrentRow.Cells["TITULO DEL LIBRO"].Value);
            Variables.Autor = Convert.ToString(dgvBusqueda.CurrentRow.Cells["AUTOR"].Value);
            Variables.Existencia = Convert.ToString(dgvBusqueda.CurrentRow.Cells["EXISTENCIA"].Value);
            Variables.Editorial = Convert.ToString(dgvBusqueda.CurrentRow.Cells["EDITORIAL"].Value);
            Variables.TipoUsuario = Convert.ToString(dgvBusqueda.CurrentRow.Cells["TIPO PRESTAMO"].Value);
            this.Close();
        }
    }
}
