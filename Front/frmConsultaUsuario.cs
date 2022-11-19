using System;
using System.Data;
using System.Windows.Forms;
using Biblioteca.Negocios;
using LibreriaUsoPDF;
using iText;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Kernel.Font;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Font.Constants;

namespace Biblioteca.Front
{
    public partial class frmConsultaUsuario : Form
    {
        DataTable tablaUsuarios;
        public frmConsultaUsuario()
        {
            InitializeComponent();
        }

        private void frmConsultaUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                tablaUsuarios = NUsuario.ObtenerUsuarios();
                dgvUsuario.DataSource = tablaUsuarios;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Document documento = Utility.CratePDF("Reporte de Usuarios.PDF");

            documento = Utility.EncabezadoPDF(documento, "Biblioteca En Capas", "Reporte de Usuarios");
            string[] columnas = { "Clave", "Nombre", "Edad", "Tipo" };
            float[] tam = { 20, 40, 10, 30 };
            Table tabla = Utility.EncabezadoTable(columnas, tam);

            for (int i = 0; i < tablaUsuarios.Rows.Count; i++)
            {
                Paragraph p = new Paragraph(tablaUsuarios.Rows[i][0].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaUsuarios.Rows[i][1].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaUsuarios.Rows[i][2].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaUsuarios.Rows[i][3].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
            }
            documento.Add(tabla);
            documento.Close();
            MessageBox.Show("Reporte generado");
        }
    }
}
