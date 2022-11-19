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

namespace Biblioteca.Front
{
    public partial class frmConsultaLibro : Form
    {
        public frmConsultaLibro()
        {
            InitializeComponent();
        }

        private void frmConsultaLibro_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable tabla = NLibro.ObtenerLibros();
                dgvLibro.DataSource = tabla;
                dgvLibro.Columns[1].Width = 150;
                dgvLibro.Columns[2].Width = 125;
            }
            catch(Exception ex)
            {
                //aqui manejan los errores de conexion de datos
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR", MessageBoxButtons.OK);
            }
        }
    }
}
