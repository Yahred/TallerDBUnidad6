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
    public partial class frmConsultaPrestamo : Form
    {
        DataTable tablaPrestamo; 
        public frmConsultaPrestamo()
        {
            InitializeComponent();
        }

        private void frmConsultaPrestamo_Load(object sender, EventArgs e)
        {
            tablaPrestamo = NPrestamo.ObtenerPrestamos();
            dgvPrestamo.DataSource = tablaPrestamo;
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            PdfFont fontNormal = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);
            Document documento = Utility.CratePDF("Reporte de Prestamos.PDF");

            documento = Utility.EncabezadoPDF(documento, "Biblioteca En Capas", "Reporte de Prestamos");
            string[] columnas = { "Clave", "ISBN", "Titulo", "Clave Usuario", "Nombre" };
            float[] tam = { 20, 20, 40, 20, 40 };
            Table tabla = Utility.EncabezadoTable(columnas, tam);

            for (int i = 0; i < tablaPrestamo.Rows.Count; i++)
            {
                Paragraph p = new Paragraph(tablaPrestamo.Rows[i][0].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaPrestamo.Rows[i][1].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaPrestamo.Rows[i][2].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaPrestamo.Rows[i][3].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                p = new Paragraph(tablaPrestamo.Rows[i][4].ToString()).SetFont(fontNormal);
                tabla.AddCell(new Cell().Add(p));
                
            }
            documento.Add(tabla);
            documento.Close();
            MessageBox.Show("Reporte generado");
        }
    }
}
