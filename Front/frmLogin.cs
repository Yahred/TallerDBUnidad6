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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = this.txtUsuario.Text;
            string contra = this.txtContra.Text;   
            Console.WriteLine(usuario + " " + contra);

            if(!Login.Ingresar(usuario, contra))
            {
                MessageBox.Show("El Usuario o la contraseña son incorrectos");
                return;
            }

            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }
    }
}
