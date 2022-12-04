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
            this.txtServidor.Text = "DESKTOP-F92EKB0";
            this.txtBD.Text = "Ventas";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string usuario = this.txtUsuario.Text;
            string contra = this.txtContra.Text;
            string servidor = this.txtServidor.Text;
            string BD = this.txtBD.Text;

            try
            {

                if (!Login.Ingresar(usuario, contra, servidor, BD))
                {
                    MessageBox.Show("El Usuario o la contraseña son incorrectos");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            frmMenu menu = new frmMenu();
            menu.Show();
            this.Hide();
        }

    }
}
