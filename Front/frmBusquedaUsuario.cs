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
    public partial class frmBusquedaUsuario : Form
    {
        DataTable tabla;
        public frmBusquedaUsuario()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            tabla = NUsuario.BuscarUsuario(txtTexto.Text);
            dgvUsuario.DataSource = tabla;
        }

        private void dgvUsuario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Variables.ClaveUsuario = Convert.ToString(dgvUsuario.CurrentRow.Cells["CLAVE DEL USUARIO"].Value);
            Variables.Nombre = Convert.ToString(dgvUsuario.CurrentRow.Cells["NOMBRE DEL USUARIO"].Value);
            Variables.UsuarioTipoUsuario = Convert.ToString(dgvUsuario.CurrentRow.Cells["TIPO DE USUARIO"].Value);
            this.Close();
        }
    }
}
