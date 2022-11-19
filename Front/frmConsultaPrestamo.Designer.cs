namespace Biblioteca.Front
{
    partial class frmConsultaPrestamo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvPrestamo = new System.Windows.Forms.DataGridView();
            this.btnReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPrestamo
            // 
            this.dgvPrestamo.AllowUserToAddRows = false;
            this.dgvPrestamo.AllowUserToDeleteRows = false;
            this.dgvPrestamo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPrestamo.Location = new System.Drawing.Point(0, 41);
            this.dgvPrestamo.Name = "dgvPrestamo";
            this.dgvPrestamo.ReadOnly = true;
            this.dgvPrestamo.Size = new System.Drawing.Size(562, 273);
            this.dgvPrestamo.TabIndex = 0;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(12, 12);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(108, 23);
            this.btnReporte.TabIndex = 1;
            this.btnReporte.Text = "Generar Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // frmConsultaPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 314);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.dgvPrestamo);
            this.Name = "frmConsultaPrestamo";
            this.Text = "Consulta Prestamo";
            this.Load += new System.EventHandler(this.frmConsultaPrestamo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPrestamo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPrestamo;
        private System.Windows.Forms.Button btnReporte;
    }
}