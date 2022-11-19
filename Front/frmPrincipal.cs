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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void todosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaLibro ConLibros = new frmConsultaLibro();
            ConLibros.ShowDialog();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgregarLibro agregarLibro = new frmAgregarLibro();
            agregarLibro.ShowDialog();
        }

        private void individualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaLibroIndividual cli = new frmConsultaLibroIndividual();
            cli.ShowDialog();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmConsultaUsuario usu = new frmConsultaUsuario();
            usu.ShowDialog();
        }

        private void consultarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmConsultaPrestamo pre = new frmConsultaPrestamo();
            pre.ShowDialog();
        }

        private void agregarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmAgregarUsuario agregarUsuario = new frmAgregarUsuario();
            agregarUsuario.ShowDialog();
        }

        private void agregarToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAgregarPrestamo agrPres = new frmAgregarPrestamo();
            agrPres.ShowDialog();
        }
    }
}
