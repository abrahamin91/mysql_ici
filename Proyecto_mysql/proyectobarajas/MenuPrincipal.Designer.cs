namespace ProyectoBarajas
{
    partial class MenuPrincipal
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
            System.Windows.Forms.Label label3;
            this.linkLabelCalificacionesAl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabelCatalogoCursosAl = new System.Windows.Forms.LinkLabel();
            this.linkLabelCursosAl = new System.Windows.Forms.LinkLabel();
            this.linkLabelAlumnosInscritosP = new System.Windows.Forms.LinkLabel();
            this.linkLabelCatalogoCursosP = new System.Windows.Forms.LinkLabel();
            this.linkLabelAdminAl = new System.Windows.Forms.LinkLabel();
            this.linkLabelAdminP = new System.Windows.Forms.LinkLabel();
            this.linkLabelContactoAl = new System.Windows.Forms.LinkLabel();
            this.linkLabelContactoP = new System.Windows.Forms.LinkLabel();
            this.buttonSalir = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(30, 258);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(70, 13);
            label3.TabIndex = 5;
            label3.Text = "Administrador";
            // 
            // linkLabelCalificacionesAl
            // 
            this.linkLabelCalificacionesAl.AutoSize = true;
            this.linkLabelCalificacionesAl.Location = new System.Drawing.Point(43, 48);
            this.linkLabelCalificacionesAl.Name = "linkLabelCalificacionesAl";
            this.linkLabelCalificacionesAl.Size = new System.Drawing.Size(115, 13);
            this.linkLabelCalificacionesAl.TabIndex = 0;
            this.linkLabelCalificacionesAl.TabStop = true;
            this.linkLabelCalificacionesAl.Text = "Calificaciones Alumnos";
            this.linkLabelCalificacionesAl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCalificacionesAl_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Alumnos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Profesores";
            // 
            // linkLabelCatalogoCursosAl
            // 
            this.linkLabelCatalogoCursosAl.AutoSize = true;
            this.linkLabelCatalogoCursosAl.Location = new System.Drawing.Point(43, 72);
            this.linkLabelCatalogoCursosAl.Name = "linkLabelCatalogoCursosAl";
            this.linkLabelCatalogoCursosAl.Size = new System.Drawing.Size(99, 13);
            this.linkLabelCatalogoCursosAl.TabIndex = 3;
            this.linkLabelCatalogoCursosAl.TabStop = true;
            this.linkLabelCatalogoCursosAl.Text = "Catálogo de Cursos";
            this.linkLabelCatalogoCursosAl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCatalogoCursosAl_LinkClicked);
            // 
            // linkLabelCursosAl
            // 
            this.linkLabelCursosAl.AutoSize = true;
            this.linkLabelCursosAl.Location = new System.Drawing.Point(43, 96);
            this.linkLabelCursosAl.Name = "linkLabelCursosAl";
            this.linkLabelCursosAl.Size = new System.Drawing.Size(93, 13);
            this.linkLabelCursosAl.TabIndex = 4;
            this.linkLabelCursosAl.TabStop = true;
            this.linkLabelCursosAl.Text = "Cursos Solicitados";
            this.linkLabelCursosAl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCursosAl_LinkClicked);
            // 
            // linkLabelAlumnosInscritosP
            // 
            this.linkLabelAlumnosInscritosP.AutoSize = true;
            this.linkLabelAlumnosInscritosP.Location = new System.Drawing.Point(41, 206);
            this.linkLabelAlumnosInscritosP.Name = "linkLabelAlumnosInscritosP";
            this.linkLabelAlumnosInscritosP.Size = new System.Drawing.Size(89, 13);
            this.linkLabelAlumnosInscritosP.TabIndex = 6;
            this.linkLabelAlumnosInscritosP.TabStop = true;
            this.linkLabelAlumnosInscritosP.Text = "Alumnos Inscritos";
            this.linkLabelAlumnosInscritosP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAlumnosInscritosP_LinkClicked);
            // 
            // linkLabelCatalogoCursosP
            // 
            this.linkLabelCatalogoCursosP.AutoSize = true;
            this.linkLabelCatalogoCursosP.Location = new System.Drawing.Point(43, 180);
            this.linkLabelCatalogoCursosP.Name = "linkLabelCatalogoCursosP";
            this.linkLabelCatalogoCursosP.Size = new System.Drawing.Size(99, 13);
            this.linkLabelCatalogoCursosP.TabIndex = 7;
            this.linkLabelCatalogoCursosP.TabStop = true;
            this.linkLabelCatalogoCursosP.Text = "Catálogo de Cursos";
            this.linkLabelCatalogoCursosP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCatalogoCursosP_LinkClicked);
            // 
            // linkLabelAdminAl
            // 
            this.linkLabelAdminAl.AutoSize = true;
            this.linkLabelAdminAl.Location = new System.Drawing.Point(43, 285);
            this.linkLabelAdminAl.Name = "linkLabelAdminAl";
            this.linkLabelAdminAl.Size = new System.Drawing.Size(118, 13);
            this.linkLabelAdminAl.TabIndex = 8;
            this.linkLabelAdminAl.TabStop = true;
            this.linkLabelAdminAl.Text = "Administración Alumnos";
            this.linkLabelAdminAl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAdminAl_LinkClicked);
            // 
            // linkLabelAdminP
            // 
            this.linkLabelAdminP.AutoSize = true;
            this.linkLabelAdminP.Location = new System.Drawing.Point(45, 311);
            this.linkLabelAdminP.Name = "linkLabelAdminP";
            this.linkLabelAdminP.Size = new System.Drawing.Size(117, 13);
            this.linkLabelAdminP.TabIndex = 9;
            this.linkLabelAdminP.TabStop = true;
            this.linkLabelAdminP.Text = "Administración Profesor";
            this.linkLabelAdminP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAdminP_LinkClicked);
            // 
            // linkLabelContactoAl
            // 
            this.linkLabelContactoAl.AutoSize = true;
            this.linkLabelContactoAl.Location = new System.Drawing.Point(45, 335);
            this.linkLabelContactoAl.Name = "linkLabelContactoAl";
            this.linkLabelContactoAl.Size = new System.Drawing.Size(93, 13);
            this.linkLabelContactoAl.TabIndex = 10;
            this.linkLabelContactoAl.TabStop = true;
            this.linkLabelContactoAl.Text = "Contacto Alumnos";
            this.linkLabelContactoAl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelContactoAl_LinkClicked);
            // 
            // linkLabelContactoP
            // 
            this.linkLabelContactoP.AutoSize = true;
            this.linkLabelContactoP.Location = new System.Drawing.Point(45, 361);
            this.linkLabelContactoP.Name = "linkLabelContactoP";
            this.linkLabelContactoP.Size = new System.Drawing.Size(103, 13);
            this.linkLabelContactoP.TabIndex = 11;
            this.linkLabelContactoP.TabStop = true;
            this.linkLabelContactoP.Text = "Contacto Profesores";
            this.linkLabelContactoP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelContactoP_LinkClicked);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(243, 137);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 12;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 420);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.linkLabelContactoP);
            this.Controls.Add(this.linkLabelContactoAl);
            this.Controls.Add(this.linkLabelAdminP);
            this.Controls.Add(this.linkLabelAdminAl);
            this.Controls.Add(this.linkLabelCatalogoCursosP);
            this.Controls.Add(this.linkLabelAlumnosInscritosP);
            this.Controls.Add(label3);
            this.Controls.Add(this.linkLabelCursosAl);
            this.Controls.Add(this.linkLabelCatalogoCursosAl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabelCalificacionesAl);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelCalificacionesAl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabelCatalogoCursosAl;
        private System.Windows.Forms.LinkLabel linkLabelCursosAl;
        private System.Windows.Forms.LinkLabel linkLabelAlumnosInscritosP;
        private System.Windows.Forms.LinkLabel linkLabelCatalogoCursosP;
        private System.Windows.Forms.LinkLabel linkLabelAdminAl;
        private System.Windows.Forms.LinkLabel linkLabelAdminP;
        private System.Windows.Forms.LinkLabel linkLabelContactoAl;
        private System.Windows.Forms.LinkLabel linkLabelContactoP;
        private System.Windows.Forms.Button buttonSalir;
    }
}