namespace Biblioteca.Front
{
    partial class frmAgregarLibro
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
            this.components = new System.ComponentModel.Container();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.gpbTipoPrestamo = new System.Windows.Forms.GroupBox();
            this.rdbExterno = new System.Windows.Forms.RadioButton();
            this.rdbInterno = new System.Windows.Forms.RadioButton();
            this.lblSBN = new System.Windows.Forms.Label();
            this.gpbInfo = new System.Windows.Forms.GroupBox();
            this.lblExistencia = new System.Windows.Forms.Label();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.txtAutor = new System.Windows.Forms.TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtTitulo = new System.Windows.Forms.TextBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.gpbTipoUsuario = new System.Windows.Forms.GroupBox();
            this.ckbEstudiante = new System.Windows.Forms.CheckBox();
            this.ckbMaestro = new System.Windows.Forms.CheckBox();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbTipoPrestamo.SuspendLayout();
            this.gpbInfo.SuspendLayout();
            this.gpbTipoUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(353, 28);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 62);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(353, 117);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 63);
            this.btnLimpiar.TabIndex = 1;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(353, 199);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 71);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // gpbTipoPrestamo
            // 
            this.gpbTipoPrestamo.Controls.Add(this.rdbExterno);
            this.gpbTipoPrestamo.Controls.Add(this.rdbInterno);
            this.gpbTipoPrestamo.Location = new System.Drawing.Point(25, 254);
            this.gpbTipoPrestamo.Name = "gpbTipoPrestamo";
            this.gpbTipoPrestamo.Size = new System.Drawing.Size(118, 100);
            this.gpbTipoPrestamo.TabIndex = 3;
            this.gpbTipoPrestamo.TabStop = false;
            this.gpbTipoPrestamo.Text = "Tipo de prestamo";
            // 
            // rdbExterno
            // 
            this.rdbExterno.AutoSize = true;
            this.rdbExterno.Location = new System.Drawing.Point(18, 60);
            this.rdbExterno.Name = "rdbExterno";
            this.rdbExterno.Size = new System.Drawing.Size(61, 17);
            this.rdbExterno.TabIndex = 1;
            this.rdbExterno.TabStop = true;
            this.rdbExterno.Text = "Externo";
            this.rdbExterno.UseVisualStyleBackColor = true;
            this.rdbExterno.CheckedChanged += new System.EventHandler(this.rdbExterno_CheckedChanged);
            // 
            // rdbInterno
            // 
            this.rdbInterno.AutoSize = true;
            this.rdbInterno.Checked = true;
            this.rdbInterno.Location = new System.Drawing.Point(18, 36);
            this.rdbInterno.Name = "rdbInterno";
            this.rdbInterno.Size = new System.Drawing.Size(58, 17);
            this.rdbInterno.TabIndex = 0;
            this.rdbInterno.TabStop = true;
            this.rdbInterno.Text = "Interno";
            this.rdbInterno.UseVisualStyleBackColor = true;
            this.rdbInterno.CheckedChanged += new System.EventHandler(this.rdbInterno_CheckedChanged);
            // 
            // lblSBN
            // 
            this.lblSBN.AutoSize = true;
            this.lblSBN.Location = new System.Drawing.Point(15, 25);
            this.lblSBN.Name = "lblSBN";
            this.lblSBN.Size = new System.Drawing.Size(32, 13);
            this.lblSBN.TabIndex = 4;
            this.lblSBN.Text = "ISBN";
            // 
            // gpbInfo
            // 
            this.gpbInfo.Controls.Add(this.lblExistencia);
            this.gpbInfo.Controls.Add(this.txtExistencia);
            this.gpbInfo.Controls.Add(this.cmbEditorial);
            this.gpbInfo.Controls.Add(this.lblEditorial);
            this.gpbInfo.Controls.Add(this.txtAutor);
            this.gpbInfo.Controls.Add(this.lblAutor);
            this.gpbInfo.Controls.Add(this.txtTitulo);
            this.gpbInfo.Controls.Add(this.lblTitulo);
            this.gpbInfo.Controls.Add(this.txtISBN);
            this.gpbInfo.Controls.Add(this.lblSBN);
            this.gpbInfo.Location = new System.Drawing.Point(25, 38);
            this.gpbInfo.Name = "gpbInfo";
            this.gpbInfo.Size = new System.Drawing.Size(293, 192);
            this.gpbInfo.TabIndex = 5;
            this.gpbInfo.TabStop = false;
            this.gpbInfo.Text = "Informacion de Libro";
            // 
            // lblExistencia
            // 
            this.lblExistencia.AutoSize = true;
            this.lblExistencia.Location = new System.Drawing.Point(172, 129);
            this.lblExistencia.Name = "lblExistencia";
            this.lblExistencia.Size = new System.Drawing.Size(55, 13);
            this.lblExistencia.TabIndex = 13;
            this.lblExistencia.Text = "Existencia";
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(175, 145);
            this.txtExistencia.MaxLength = 3;
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(100, 20);
            this.txtExistencia.TabIndex = 12;
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Items.AddRange(new object[] {
            "Zireael",
            "Mirai",
            "Sentinel"});
            this.cmbEditorial.Location = new System.Drawing.Point(18, 144);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(100, 21);
            this.cmbEditorial.TabIndex = 11;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Location = new System.Drawing.Point(15, 129);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(44, 13);
            this.lblEditorial.TabIndex = 10;
            this.lblEditorial.Text = "Editorial";
            // 
            // txtAutor
            // 
            this.txtAutor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAutor.Location = new System.Drawing.Point(175, 80);
            this.txtAutor.MaxLength = 50;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Size = new System.Drawing.Size(100, 20);
            this.txtAutor.TabIndex = 9;
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Location = new System.Drawing.Point(172, 64);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(32, 13);
            this.lblAutor.TabIndex = 8;
            this.lblAutor.Text = "Autor";
            // 
            // txtTitulo
            // 
            this.txtTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTitulo.Location = new System.Drawing.Point(18, 80);
            this.txtTitulo.MaxLength = 30;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Size = new System.Drawing.Size(100, 20);
            this.txtTitulo.TabIndex = 7;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(15, 64);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(33, 13);
            this.lblTitulo.TabIndex = 6;
            this.lblTitulo.Text = "Titulo";
            // 
            // txtISBN
            // 
            this.txtISBN.Location = new System.Drawing.Point(53, 22);
            this.txtISBN.MaxLength = 13;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(100, 20);
            this.txtISBN.TabIndex = 5;
            // 
            // gpbTipoUsuario
            // 
            this.gpbTipoUsuario.Controls.Add(this.ckbEstudiante);
            this.gpbTipoUsuario.Controls.Add(this.ckbMaestro);
            this.gpbTipoUsuario.Location = new System.Drawing.Point(200, 254);
            this.gpbTipoUsuario.Name = "gpbTipoUsuario";
            this.gpbTipoUsuario.Size = new System.Drawing.Size(118, 100);
            this.gpbTipoUsuario.TabIndex = 6;
            this.gpbTipoUsuario.TabStop = false;
            this.gpbTipoUsuario.Text = "Tipo de Usuario";
            // 
            // ckbEstudiante
            // 
            this.ckbEstudiante.AutoSize = true;
            this.ckbEstudiante.Location = new System.Drawing.Point(23, 60);
            this.ckbEstudiante.Name = "ckbEstudiante";
            this.ckbEstudiante.Size = new System.Drawing.Size(76, 17);
            this.ckbEstudiante.TabIndex = 1;
            this.ckbEstudiante.Text = "Estudiante";
            this.ckbEstudiante.UseVisualStyleBackColor = true;
            // 
            // ckbMaestro
            // 
            this.ckbMaestro.AutoSize = true;
            this.ckbMaestro.Checked = true;
            this.ckbMaestro.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbMaestro.Location = new System.Drawing.Point(23, 36);
            this.ckbMaestro.Name = "ckbMaestro";
            this.ckbMaestro.Size = new System.Drawing.Size(64, 17);
            this.ckbMaestro.TabIndex = 0;
            this.ckbMaestro.Text = "Maestro";
            this.ckbMaestro.UseVisualStyleBackColor = true;
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // frmAgregarLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 374);
            this.Controls.Add(this.gpbTipoUsuario);
            this.Controls.Add(this.gpbInfo);
            this.Controls.Add(this.gpbTipoPrestamo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "frmAgregarLibro";
            this.Text = "Agregar Libro";
            this.Load += new System.EventHandler(this.frmAgregarLibro_Load);
            this.gpbTipoPrestamo.ResumeLayout(false);
            this.gpbTipoPrestamo.PerformLayout();
            this.gpbInfo.ResumeLayout(false);
            this.gpbInfo.PerformLayout();
            this.gpbTipoUsuario.ResumeLayout(false);
            this.gpbTipoUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.GroupBox gpbTipoPrestamo;
        private System.Windows.Forms.RadioButton rdbExterno;
        private System.Windows.Forms.RadioButton rdbInterno;
        private System.Windows.Forms.Label lblSBN;
        private System.Windows.Forms.GroupBox gpbInfo;
        private System.Windows.Forms.Label lblExistencia;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.ComboBox cmbEditorial;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtAutor;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.TextBox txtTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.GroupBox gpbTipoUsuario;
        private System.Windows.Forms.CheckBox ckbEstudiante;
        private System.Windows.Forms.CheckBox ckbMaestro;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}