namespace Biblioteca.Front
{
    partial class frmAgregarPrestamo
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
            this.gpbCliente = new System.Windows.Forms.GroupBox();
            this.btnBuscarC = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbLibro = new System.Windows.Forms.GroupBox();
            this.btnBuscarL = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.txtTipo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.gpbCliente.SuspendLayout();
            this.gpbLibro.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCliente
            // 
            this.gpbCliente.Controls.Add(this.btnBuscarC);
            this.gpbCliente.Controls.Add(this.txtNombre);
            this.gpbCliente.Controls.Add(this.label2);
            this.gpbCliente.Controls.Add(this.txtID);
            this.gpbCliente.Controls.Add(this.label1);
            this.gpbCliente.Location = new System.Drawing.Point(12, 12);
            this.gpbCliente.Name = "gpbCliente";
            this.gpbCliente.Size = new System.Drawing.Size(509, 61);
            this.gpbCliente.TabIndex = 0;
            this.gpbCliente.TabStop = false;
            this.gpbCliente.Text = "Informacion de Cliente";
            // 
            // btnBuscarC
            // 
            this.btnBuscarC.Location = new System.Drawing.Point(404, 22);
            this.btnBuscarC.Name = "btnBuscarC";
            this.btnBuscarC.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarC.TabIndex = 4;
            this.btnBuscarC.Text = "Buscar";
            this.btnBuscarC.UseVisualStyleBackColor = true;
            this.btnBuscarC.Click += new System.EventHandler(this.btnBuscarC_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(205, 24);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.Size = new System.Drawing.Size(145, 20);
            this.txtNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(78, 24);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(45, 20);
            this.txtID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id. Cliente";
            // 
            // gpbLibro
            // 
            this.gpbLibro.Controls.Add(this.txtAutor);
            this.gpbLibro.Controls.Add(this.label8);
            this.gpbLibro.Controls.Add(this.label7);
            this.gpbLibro.Controls.Add(this.txtTipo);
            this.gpbLibro.Controls.Add(this.txtEditorial);
            this.gpbLibro.Controls.Add(this.txtExistencia);
            this.gpbLibro.Controls.Add(this.label6);
            this.gpbLibro.Controls.Add(this.label5);
            this.gpbLibro.Controls.Add(this.txtISBN);
            this.gpbLibro.Controls.Add(this.label4);
            this.gpbLibro.Controls.Add(this.btnBuscarL);
            this.gpbLibro.Controls.Add(this.label3);
            this.gpbLibro.Controls.Add(this.txtTitulo);
            this.gpbLibro.Location = new System.Drawing.Point(13, 88);
            this.gpbLibro.Name = "gpbLibro";
            this.gpbLibro.Size = new System.Drawing.Size(508, 199);
            this.gpbLibro.TabIndex = 1;
            this.gpbLibro.TabStop = false;
            this.gpbLibro.Text = "Informacion de Libro";
            // 
            // btnBuscarL
            // 
            this.btnBuscarL.Location = new System.Drawing.Point(403, 28);
            this.btnBuscarL.Name = "btnBuscarL";
            this.btnBuscarL.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarL.TabIndex = 3;
            this.btnBuscarL.Text = "Buscar";
            this.btnBuscarL.UseVisualStyleBackColor = true;
            this.btnBuscarL.Click += new System.EventHandler(this.btnBuscarL_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(172, 53);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(177, 20);
            this.txtTitulo.TabIndex = 1;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(416, 293);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "ISBN";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(23, 53);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.ReadOnly = true;
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 5;
            this.txtISBN.TextChanged += new System.EventHandler(this.txtISBN_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Existencia";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(317, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Editorial";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(23, 110);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.ReadOnly = true;
            this.txtExistencia.Size = new System.Drawing.Size(79, 20);
            this.txtExistencia.TabIndex = 8;
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(320, 110);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.ReadOnly = true;
            this.txtEditorial.Size = new System.Drawing.Size(158, 20);
            this.txtEditorial.TabIndex = 9;
            // 
            // txtTipo
            // 
            this.txtTipo.Location = new System.Drawing.Point(108, 157);
            this.txtTipo.Name = "txtTipo";
            this.txtTipo.ReadOnly = true;
            this.txtTipo.Size = new System.Drawing.Size(97, 20);
            this.txtTipo.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 160);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Tipo de Usuario";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(138, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(141, 110);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(138, 20);
            this.txtAutor.TabIndex = 13;
            // 
            // frmAgregarPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 328);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.gpbLibro);
            this.Controls.Add(this.gpbCliente);
            this.Name = "frmAgregarPrestamo";
            this.Text = "Agregar Prestamo";
            this.gpbCliente.ResumeLayout(false);
            this.gpbCliente.PerformLayout();
            this.gpbLibro.ResumeLayout(false);
            this.gpbLibro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCliente;
        private System.Windows.Forms.Button btnBuscarC;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbLibro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnBuscarL;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTipo;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label8;
    }
}