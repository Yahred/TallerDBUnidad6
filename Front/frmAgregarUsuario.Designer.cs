
namespace Biblioteca.Front
{
    partial class frmAgregarUsuario
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gpbTipo = new System.Windows.Forms.GroupBox();
            this.rdbEstudiante = new System.Windows.Forms.RadioButton();
            this.rdbMaestro = new System.Windows.Forms.RadioButton();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.errorP = new System.Windows.Forms.ErrorProvider(this.components);
            this.gpbTipo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Edad ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Clave Usuario";
            // 
            // gpbTipo
            // 
            this.gpbTipo.Controls.Add(this.rdbMaestro);
            this.gpbTipo.Controls.Add(this.rdbEstudiante);
            this.gpbTipo.Location = new System.Drawing.Point(12, 152);
            this.gpbTipo.Name = "gpbTipo";
            this.gpbTipo.Size = new System.Drawing.Size(180, 57);
            this.gpbTipo.TabIndex = 3;
            this.gpbTipo.TabStop = false;
            this.gpbTipo.Text = "Tipo de Usuario";
            // 
            // rdbEstudiante
            // 
            this.rdbEstudiante.AutoSize = true;
            this.rdbEstudiante.Checked = true;
            this.rdbEstudiante.Location = new System.Drawing.Point(18, 29);
            this.rdbEstudiante.Name = "rdbEstudiante";
            this.rdbEstudiante.Size = new System.Drawing.Size(75, 17);
            this.rdbEstudiante.TabIndex = 0;
            this.rdbEstudiante.TabStop = true;
            this.rdbEstudiante.Text = "Estudiante";
            this.rdbEstudiante.UseVisualStyleBackColor = true;
            this.rdbEstudiante.CheckedChanged += new System.EventHandler(this.rdbEstudiante_CheckedChanged);
            // 
            // rdbMaestro
            // 
            this.rdbMaestro.AutoSize = true;
            this.rdbMaestro.Location = new System.Drawing.Point(102, 29);
            this.rdbMaestro.Name = "rdbMaestro";
            this.rdbMaestro.Size = new System.Drawing.Size(63, 17);
            this.rdbMaestro.TabIndex = 1;
            this.rdbMaestro.Text = "Maestro";
            this.rdbMaestro.UseVisualStyleBackColor = true;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(77, 82);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 4;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(77, 117);
            this.txtEdad.MaxLength = 2;
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(100, 20);
            this.txtEdad.TabIndex = 5;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(30, 39);
            this.txtClave.MaxLength = 5;
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(70, 20);
            this.txtClave.TabIndex = 6;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(115, 22);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(62, 37);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // errorP
            // 
            this.errorP.ContainerControl = this;
            // 
            // frmAgregarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 218);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.gpbTipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmAgregarUsuario";
            this.Text = "Agregar Usuario";
            this.gpbTipo.ResumeLayout(false);
            this.gpbTipo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gpbTipo;
        private System.Windows.Forms.RadioButton rdbMaestro;
        private System.Windows.Forms.RadioButton rdbEstudiante;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.ErrorProvider errorP;
    }
}