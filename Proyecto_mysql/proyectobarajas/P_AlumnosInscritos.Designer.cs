namespace ProyectoBarajas
{
    partial class P_AlumnosInscritos
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
            this.dataGridViewAlumnosInscritos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxMaterias = new System.Windows.Forms.ComboBox();
            this.textBoxProfesor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.ClaveMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnosInscritos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewAlumnosInscritos
            // 
            this.dataGridViewAlumnosInscritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAlumnosInscritos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveMateria,
            this.NombreMateria});
            this.dataGridViewAlumnosInscritos.Enabled = false;
            this.dataGridViewAlumnosInscritos.Location = new System.Drawing.Point(73, 162);
            this.dataGridViewAlumnosInscritos.Name = "dataGridViewAlumnosInscritos";
            this.dataGridViewAlumnosInscritos.Size = new System.Drawing.Size(243, 107);
            this.dataGridViewAlumnosInscritos.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Detalle de Alumnos Inscritos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Materias a Impartir";
            // 
            // comboBoxMaterias
            // 
            this.comboBoxMaterias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMaterias.FormattingEnabled = true;
            this.comboBoxMaterias.Location = new System.Drawing.Point(227, 68);
            this.comboBoxMaterias.Name = "comboBoxMaterias";
            this.comboBoxMaterias.Size = new System.Drawing.Size(162, 21);
            this.comboBoxMaterias.TabIndex = 8;
            // 
            // textBoxProfesor
            // 
            this.textBoxProfesor.Enabled = false;
            this.textBoxProfesor.Location = new System.Drawing.Point(227, 31);
            this.textBoxProfesor.Name = "textBoxProfesor";
            this.textBoxProfesor.ReadOnly = true;
            this.textBoxProfesor.Size = new System.Drawing.Size(162, 20);
            this.textBoxProfesor.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Nombre del Profesor";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(314, 120);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 12;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // ClaveMateria
            // 
            this.ClaveMateria.Frozen = true;
            this.ClaveMateria.HeaderText = "ID Alumno";
            this.ClaveMateria.Name = "ClaveMateria";
            this.ClaveMateria.ReadOnly = true;
            // 
            // NombreMateria
            // 
            this.NombreMateria.Frozen = true;
            this.NombreMateria.HeaderText = "NombreAlumno";
            this.NombreMateria.Name = "NombreMateria";
            this.NombreMateria.ReadOnly = true;
            // 
            // P_AlumnosInscritos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 303);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.dataGridViewAlumnosInscritos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxMaterias);
            this.Controls.Add(this.textBoxProfesor);
            this.Controls.Add(this.label1);
            this.Name = "P_AlumnosInscritos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alumnos Inscritos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAlumnosInscritos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewAlumnosInscritos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxMaterias;
        private System.Windows.Forms.TextBox textBoxProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreMateria;
    }
}