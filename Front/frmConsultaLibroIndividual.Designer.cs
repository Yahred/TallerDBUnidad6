namespace Biblioteca.Front
{
    partial class frmConsultaLibroIndividual
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
            this.cmbISBN = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.txtTipoUsuario = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtConsulta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.btnCambiarTitulo = new System.Windows.Forms.Button();
            this.gpbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbISBN
            // 
            this.cmbISBN.FormattingEnabled = true;
            this.cmbISBN.Location = new System.Drawing.Point(97, 15);
            this.cmbISBN.Name = "cmbISBN";
            this.cmbISBN.Size = new System.Drawing.Size(121, 21);
            this.cmbISBN.TabIndex = 0;
            this.cmbISBN.SelectedIndexChanged += new System.EventHandler(this.cmbISBN_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ISBN";
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.txtTipoUsuario);
            this.gpbInfo.Controls.Add(this.label7);
            this.gpbInfo.Controls.Add(this.txtConsulta);
            this.gpbInfo.Controls.Add(this.label6);
            this.gpbInfo.Controls.Add(this.txtEditorial);
            this.gpbInfo.Controls.Add(this.label5);
            this.gpbInfo.Controls.Add(this.txtExistencia);
            this.gpbInfo.Controls.Add(this.label4);
            this.gpbInfo.Controls.Add(this.txtAutor);
            this.gpbInfo.Controls.Add(this.label3);
            this.gpbInfo.Controls.Add(this.label2);
            this.gpbInfo.Controls.Add(this.txtTitulo);
            this.gpbInfo.Location = new System.Drawing.Point(15, 57);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(270, 211);
            this.gpbInfo.TabIndex = 2;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Informacion del Libro";
            // 
            // txtTipoUsuario
            // 
            this.txtTipoUsuario.Location = new System.Drawing.Point(94, 177);
            this.txtTipoUsuario.Name = "txtTipoUsuario";
            this.txtTipoUsuario.ReadOnly = true;
            this.txtTipoUsuario.Size = new System.Drawing.Size(170, 20);
            this.txtTipoUsuario.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 180);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Tipo Usuario";
            // 
            // txtConsulta
            // 
            this.txtConsulta.Location = new System.Drawing.Point(94, 146);
            this.txtConsulta.Name = "txtConsulta";
            this.txtConsulta.ReadOnly = true;
            this.txtConsulta.Size = new System.Drawing.Size(170, 20);
            this.txtConsulta.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Tipo Prestamo";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(94, 117);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.ReadOnly = true;
            this.txtEditorial.Size = new System.Drawing.Size(170, 20);
            this.txtEditorial.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Editorial";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(94, 84);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.ReadOnly = true;
            this.txtExistencia.Size = new System.Drawing.Size(170, 20);
            this.txtExistencia.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Existencia";
            // 
            // txtAutor
            // 
            this.txtAutor.Location = new System.Drawing.Point(94, 51);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.ReadOnly = true;
            this.txtAutor.Size = new System.Drawing.Size(170, 20);
            this.txtAutor.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            // 
            // txtTitulo
            // 
            this.txtTitulo.Location = new System.Drawing.Point(94, 21);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.ReadOnly = true;
            this.txtTitulo.Size = new System.Drawing.Size(170, 20);
            this.txtTitulo.TabIndex = 0;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(15, 284);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(93, 23);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "Borrar Libro";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // btnCambiarTitulo
            // 
            this.btnCambiarTitulo.Location = new System.Drawing.Point(184, 284);
            this.btnCambiarTitulo.Name = "btnCambiarTitulo";
            this.btnCambiarTitulo.Size = new System.Drawing.Size(95, 23);
            this.btnCambiarTitulo.TabIndex = 4;
            this.btnCambiarTitulo.Text = "Cambiar Titulo";
            this.btnCambiarTitulo.UseVisualStyleBackColor = true;
            this.btnCambiarTitulo.Click += new System.EventHandler(this.btnCambiarTitulo_Click);
            // 
            // frmConsultaLibroIndividual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 319);
            this.Controls.Add(this.btnCambiarTitulo);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbISBN);
            this.Name = "frmConsultaLibroIndividual";
            this.Text = "Consulta Libro";
            this.Load += new System.EventHandler(this.frmConsultaLibroIndividual_Load);
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbISBN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.TextBox txtTipoUsuario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtConsulta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Button btnCambiarTitulo;
    }
}