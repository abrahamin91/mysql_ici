namespace ProyectoBarajas
{
    partial class Menu_Profesor
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
            this.linkLabelCatalogoCursosP = new System.Windows.Forms.LinkLabel();
            this.linkLabelAlumnosInscritosP = new System.Windows.Forms.LinkLabel();
            this.lbProfesores = new System.Windows.Forms.Label();
            this.lbLogoutProfesor = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabelCursosImpartir = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabelCatalogoCursosP
            // 
            this.linkLabelCatalogoCursosP.AutoSize = true;
            this.linkLabelCatalogoCursosP.Location = new System.Drawing.Point(25, 52);
            this.linkLabelCatalogoCursosP.Name = "linkLabelCatalogoCursosP";
            this.linkLabelCatalogoCursosP.Size = new System.Drawing.Size(99, 13);
            this.linkLabelCatalogoCursosP.TabIndex = 10;
            this.linkLabelCatalogoCursosP.TabStop = true;
            this.linkLabelCatalogoCursosP.Text = "Catálogo de Cursos";
            this.linkLabelCatalogoCursosP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCatalogoCursosP_LinkClicked);
            // 
            // linkLabelAlumnosInscritosP
            // 
            this.linkLabelAlumnosInscritosP.AutoSize = true;
            this.linkLabelAlumnosInscritosP.Location = new System.Drawing.Point(23, 78);
            this.linkLabelAlumnosInscritosP.Name = "linkLabelAlumnosInscritosP";
            this.linkLabelAlumnosInscritosP.Size = new System.Drawing.Size(89, 13);
            this.linkLabelAlumnosInscritosP.TabIndex = 9;
            this.linkLabelAlumnosInscritosP.TabStop = true;
            this.linkLabelAlumnosInscritosP.Text = "Alumnos Inscritos";
            this.linkLabelAlumnosInscritosP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAlumnosInscritosP_LinkClicked);
            // 
            // lbProfesores
            // 
            this.lbProfesores.AutoSize = true;
            this.lbProfesores.Location = new System.Drawing.Point(12, 28);
            this.lbProfesores.Name = "lbProfesores";
            this.lbProfesores.Size = new System.Drawing.Size(57, 13);
            this.lbProfesores.TabIndex = 8;
            this.lbProfesores.Text = "Profesores";
            this.lbProfesores.Visible = false;
            // 
            // lbLogoutProfesor
            // 
            this.lbLogoutProfesor.AutoSize = true;
            this.lbLogoutProfesor.Location = new System.Drawing.Point(178, 9);
            this.lbLogoutProfesor.Name = "lbLogoutProfesor";
            this.lbLogoutProfesor.Size = new System.Drawing.Size(35, 13);
            this.lbLogoutProfesor.TabIndex = 11;
            this.lbLogoutProfesor.Text = "label1";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(232, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // linkLabelCursosImpartir
            // 
            this.linkLabelCursosImpartir.AutoSize = true;
            this.linkLabelCursosImpartir.Location = new System.Drawing.Point(23, 105);
            this.linkLabelCursosImpartir.Name = "linkLabelCursosImpartir";
            this.linkLabelCursosImpartir.Size = new System.Drawing.Size(85, 13);
            this.linkLabelCursosImpartir.TabIndex = 13;
            this.linkLabelCursosImpartir.TabStop = true;
            this.linkLabelCursosImpartir.Text = "Cursos a Impartir";
            this.linkLabelCursosImpartir.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCursosImpartir_LinkClicked);
            // 
            // Menu_Profesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.linkLabelCursosImpartir);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbLogoutProfesor);
            this.Controls.Add(this.linkLabelCatalogoCursosP);
            this.Controls.Add(this.linkLabelAlumnosInscritosP);
            this.Controls.Add(this.lbProfesores);
            this.Name = "Menu_Profesor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Profesor";
            this.Load += new System.EventHandler(this.Menu_Profesor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelCatalogoCursosP;
        private System.Windows.Forms.LinkLabel linkLabelAlumnosInscritosP;
        private System.Windows.Forms.Label lbProfesores;
        private System.Windows.Forms.Label lbLogoutProfesor;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabelCursosImpartir;
    }
}