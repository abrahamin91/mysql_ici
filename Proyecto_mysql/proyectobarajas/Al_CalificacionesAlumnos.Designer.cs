namespace ProyectoBarajas
{
    partial class Al_CalificacionesAlumnos
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxAlumno = new System.Windows.Forms.TextBox();
            this.dataGridViewCalificaciones = new System.Windows.Forms.DataGridView();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.lbidAlumno = new System.Windows.Forms.Label();
            this.linkLabelLogutCA = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Alumno";
            // 
            // textBoxAlumno
            // 
            this.textBoxAlumno.BackColor = System.Drawing.Color.White;
            this.textBoxAlumno.Enabled = false;
            this.textBoxAlumno.Location = new System.Drawing.Point(157, 25);
            this.textBoxAlumno.Name = "textBoxAlumno";
            this.textBoxAlumno.ReadOnly = true;
            this.textBoxAlumno.Size = new System.Drawing.Size(228, 20);
            this.textBoxAlumno.TabIndex = 3;
            // 
            // dataGridViewCalificaciones
            // 
            this.dataGridViewCalificaciones.AllowUserToAddRows = false;
            this.dataGridViewCalificaciones.AllowUserToDeleteRows = false;
            this.dataGridViewCalificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalificaciones.Location = new System.Drawing.Point(41, 136);
            this.dataGridViewCalificaciones.Name = "dataGridViewCalificaciones";
            this.dataGridViewCalificaciones.Size = new System.Drawing.Size(393, 150);
            this.dataGridViewCalificaciones.TabIndex = 6;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(402, 76);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 7;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // lbidAlumno
            // 
            this.lbidAlumno.AutoSize = true;
            this.lbidAlumno.Location = new System.Drawing.Point(399, 9);
            this.lbidAlumno.Name = "lbidAlumno";
            this.lbidAlumno.Size = new System.Drawing.Size(35, 13);
            this.lbidAlumno.TabIndex = 8;
            this.lbidAlumno.Text = "label4";
            // 
            // linkLabelLogutCA
            // 
            this.linkLabelLogutCA.AutoSize = true;
            this.linkLabelLogutCA.Location = new System.Drawing.Point(454, 9);
            this.linkLabelLogutCA.Name = "linkLabelLogutCA";
            this.linkLabelLogutCA.Size = new System.Drawing.Size(40, 13);
            this.linkLabelLogutCA.TabIndex = 9;
            this.linkLabelLogutCA.TabStop = true;
            this.linkLabelLogutCA.Text = "Logout";
            this.linkLabelLogutCA.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogutCA_LinkClicked);
            // 
            // Al_CalificacionesAlumnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 327);
            this.Controls.Add(this.linkLabelLogutCA);
            this.Controls.Add(this.lbidAlumno);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.dataGridViewCalificaciones);
            this.Controls.Add(this.textBoxAlumno);
            this.Controls.Add(this.label1);
            this.Name = "Al_CalificacionesAlumnos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CalificacionesAlumnos";
            this.Load += new System.EventHandler(this.Al_CalificacionesAlumnos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalificaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxAlumno;
        private System.Windows.Forms.DataGridView dataGridViewCalificaciones;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label lbidAlumno;
        private System.Windows.Forms.LinkLabel linkLabelLogutCA;
    }
}