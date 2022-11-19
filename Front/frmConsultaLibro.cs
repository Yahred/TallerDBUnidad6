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
    public partial class frmConsultaLibro : Form
    {
        DataTable tablaLibro;
        public frmConsultaLibro()
        {
            InitializeComponent();
        }

        private void frmConsultaLibro_Load(object sender, EventArgs e)
        {
            try
            {
                tablaLibro = NLibro.ObtenerLibros();
                dgvLibro.DataSource = tablaLibro;
                dgvLibro.Columns[1].Width = 150;
                dgvLibro.Columns[2].Width = 125;
            }
            catch (Exception ex)
            {
                //aqui manejan los errores de conexion de datos
                MessageBox.Show(ex.Message + ex.StackTrace, "ERROR", MessageBoxButtons.OK);
            }
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Document documento = Utility.CratePDF("Reporte de Libros.PDF");

            documento = Utility.EncabezadoPDF(documento, "Biblioteca En Capas", "Reporte de Libros");
            string[] columnas = { "ISBN", "Titlulo", "Autor", "Existencia","Editorial","Tipo de prestamo","Tipo de usuario" };
            float[] tam = { 20, 40, 40, 20,40,30,30 };
            Table tabla = Utility.EncabezadoTable(columnas, tam);

            for (int i = 0; i < tablaLibro.Rows.Count; i++)
            {
                Paragraph p = new Paragraph(tablaLibro.Rows[i][0].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaLibro.Rows[i][1].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaLibro.Rows[i][2].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaLibro.Rows[i][3].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaLibro.Rows[i][4].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaLibro.Rows[i][5].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaLibro.Rows[i][6].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                
            }
            documento.Add(tabla);
            documento.Close();
            MessageBox.Show("Reporte generado");
        }
    }
}
