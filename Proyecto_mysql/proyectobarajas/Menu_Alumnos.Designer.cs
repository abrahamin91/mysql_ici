namespace ProyectoBarajas
{
    partial class Menu_Alumno
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
            this.linkLabelCursosAl = new System.Windows.Forms.LinkLabel();
            this.linkLabelCatalogoCursosAl = new System.Windows.Forms.LinkLabel();
            this.lbAlumnos = new System.Windows.Forms.Label();
            this.linkLabelCalificacionesAl = new System.Windows.Forms.LinkLabel();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.linkLabelAlumno = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // linkLabelCursosAl
            // 
            this.linkLabelCursosAl.AutoSize = true;
            this.linkLabelCursosAl.Location = new System.Drawing.Point(25, 117);
            this.linkLabelCursosAl.Name = "linkLabelCursosAl";
            this.linkLabelCursosAl.Size = new System.Drawing.Size(93, 13);
            this.linkLabelCursosAl.TabIndex = 8;
            this.linkLabelCursosAl.TabStop = true;
            this.linkLabelCursosAl.Text = "Cursos Solicitados";
            this.linkLabelCursosAl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCursosAl_LinkClicked);
            // 
            // linkLabelCatalogoCursosAl
            // 
            this.linkLabelCatalogoCursosAl.AutoSize = true;
            this.linkLabelCatalogoCursosAl.Location = new System.Drawing.Point(25, 88);
            this.linkLabelCatalogoCursosAl.Name = "linkLabelCatalogoCursosAl";
            this.linkLabelCatalogoCursosAl.Size = new System.Drawing.Size(99, 13);
            this.linkLabelCatalogoCursosAl.TabIndex = 7;
            this.linkLabelCatalogoCursosAl.TabStop = true;
            this.linkLabelCatalogoCursosAl.Text = "Catálogo de Cursos";
            this.linkLabelCatalogoCursosAl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCatalogoCursosAl_LinkClicked);
            // 
            // lbAlumnos
            // 
            this.lbAlumnos.AutoSize = true;
            this.lbAlumnos.Location = new System.Drawing.Point(12, 56);
            this.lbAlumnos.Name = "lbAlumnos";
            this.lbAlumnos.Size = new System.Drawing.Size(47, 13);
            this.lbAlumnos.TabIndex = 6;
            this.lbAlumnos.Text = "Alumnos";
            this.lbAlumnos.Visible = false;
            // 
            // linkLabelCalificacionesAl
            // 
            this.linkLabelCalificacionesAl.AutoSize = true;
            this.linkLabelCalificacionesAl.Location = new System.Drawing.Point(25, 153);
            this.linkLabelCalificacionesAl.Name = "linkLabelCalificacionesAl";
            this.linkLabelCalificacionesAl.Size = new System.Drawing.Size(115, 13);
            this.linkLabelCalificacionesAl.TabIndex = 5;
            this.linkLabelCalificacionesAl.TabStop = true;
            this.linkLabelCalificacionesAl.Text = "Calificaciones Alumnos";
            this.linkLabelCalificacionesAl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelCalificacionesAl_LinkClicked);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(180, 9);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbUsuario.TabIndex = 10;
            this.lbUsuario.Text = "label1";
            // 
            // linkLabelAlumno
            // 
            this.linkLabelAlumno.AutoSize = true;
            this.linkLabelAlumno.Location = new System.Drawing.Point(232, 9);
            this.linkLabelAlumno.Name = "linkLabelAlumno";
            this.linkLabelAlumno.Size = new System.Drawing.Size(40, 13);
            this.linkLabelAlumno.TabIndex = 11;
            this.linkLabelAlumno.TabStop = true;
            this.linkLabelAlumno.Text = "Logout";
            this.linkLabelAlumno.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAlumno_LinkClicked);
            // 
            // Menu_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.linkLabelAlumno);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.linkLabelCursosAl);
            this.Controls.Add(this.linkLabelCatalogoCursosAl);
            this.Controls.Add(this.lbAlumnos);
            this.Controls.Add(this.linkLabelCalificacionesAl);
            this.Name = "Menu_Alumno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Alumno";
            this.Load += new System.EventHandler(this.Menu_Alumnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelCursosAl;
        private System.Windows.Forms.LinkLabel linkLabelCatalogoCursosAl;
        private System.Windows.Forms.Label lbAlumnos;
        private System.Windows.Forms.LinkLabel linkLabelCalificacionesAl;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.LinkLabel linkLabelAlumno;
    }
}