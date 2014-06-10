namespace ProyectoBarajas
{
    partial class P_Cursos
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
            this.textBoxProfesor = new System.Windows.Forms.TextBox();
            this.comboBoxCentros = new System.Windows.Forms.ComboBox();
            this.lbCentro = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.lbIdProfesor = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.lbCarreras = new System.Windows.Forms.Label();
            this.comboBoxCarreras = new System.Windows.Forms.ComboBox();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            this.ClaveMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Impartir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del Profesor";
            // 
            // textBoxProfesor
            // 
            this.textBoxProfesor.Enabled = false;
            this.textBoxProfesor.Location = new System.Drawing.Point(173, 24);
            this.textBoxProfesor.Name = "textBoxProfesor";
            this.textBoxProfesor.ReadOnly = true;
            this.textBoxProfesor.Size = new System.Drawing.Size(239, 20);
            this.textBoxProfesor.TabIndex = 1;
            // 
            // comboBoxCentros
            // 
            this.comboBoxCentros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCentros.FormattingEnabled = true;
            this.comboBoxCentros.Location = new System.Drawing.Point(173, 66);
            this.comboBoxCentros.Name = "comboBoxCentros";
            this.comboBoxCentros.Size = new System.Drawing.Size(239, 21);
            this.comboBoxCentros.TabIndex = 2;
            this.comboBoxCentros.SelectedIndexChanged += new System.EventHandler(this.comboBoxMaterias_SelectedIndexChanged);
            // 
            // lbCentro
            // 
            this.lbCentro.AutoSize = true;
            this.lbCentro.Location = new System.Drawing.Point(28, 69);
            this.lbCentro.Name = "lbCentro";
            this.lbCentro.Size = new System.Drawing.Size(38, 13);
            this.lbCentro.TabIndex = 3;
            this.lbCentro.Text = "Centro";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Detalles de la Materia";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(263, 328);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 6;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // lbIdProfesor
            // 
            this.lbIdProfesor.AutoSize = true;
            this.lbIdProfesor.Location = new System.Drawing.Point(446, 9);
            this.lbIdProfesor.Name = "lbIdProfesor";
            this.lbIdProfesor.Size = new System.Drawing.Size(35, 13);
            this.lbIdProfesor.TabIndex = 7;
            this.lbIdProfesor.Text = "label4";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(508, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(40, 13);
            this.linkLabel1.TabIndex = 8;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Logout";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // lbCarreras
            // 
            this.lbCarreras.AutoSize = true;
            this.lbCarreras.Location = new System.Drawing.Point(31, 114);
            this.lbCarreras.Name = "lbCarreras";
            this.lbCarreras.Size = new System.Drawing.Size(46, 13);
            this.lbCarreras.TabIndex = 10;
            this.lbCarreras.Text = "Carreras";
            // 
            // comboBoxCarreras
            // 
            this.comboBoxCarreras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarreras.FormattingEnabled = true;
            this.comboBoxCarreras.Location = new System.Drawing.Point(173, 106);
            this.comboBoxCarreras.Name = "comboBoxCarreras";
            this.comboBoxCarreras.Size = new System.Drawing.Size(239, 21);
            this.comboBoxCarreras.TabIndex = 11;
            this.comboBoxCarreras.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarreras_SelectedIndexChanged);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(366, 327);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 14;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dataGridViewCursos
            // 
            this.dataGridViewCursos.AllowUserToAddRows = false;
            this.dataGridViewCursos.AllowUserToDeleteRows = false;
            this.dataGridViewCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClaveMateria,
            this.Materia,
            this.Periodo,
            this.Impartir});
            this.dataGridViewCursos.Location = new System.Drawing.Point(32, 197);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.Size = new System.Drawing.Size(449, 112);
            this.dataGridViewCursos.TabIndex = 16;
            // 
            // ClaveMateria
            // 
            this.ClaveMateria.DataPropertyName = "idcurso";
            this.ClaveMateria.HeaderText = "Clave Materia";
            this.ClaveMateria.Name = "ClaveMateria";
            // 
            // Materia
            // 
            this.Materia.DataPropertyName = "curso";
            this.Materia.HeaderText = "materia";
            this.Materia.Name = "Materia";
            // 
            // Periodo
            // 
            this.Periodo.DataPropertyName = "periodo";
            this.Periodo.HeaderText = "periodo";
            this.Periodo.Name = "Periodo";
            // 
            // Impartir
            // 
            this.Impartir.HeaderText = "impartir";
            this.Impartir.Name = "Impartir";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Carreras";
            // 
            // P_Cursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 391);
            this.Controls.Add(this.dataGridViewCursos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.comboBoxCarreras);
            this.Controls.Add(this.lbCarreras);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lbIdProfesor);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbCentro);
            this.Controls.Add(this.comboBoxCentros);
            this.Controls.Add(this.textBoxProfesor);
            this.Controls.Add(this.label1);
            this.Name = "P_Cursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cursos";
            this.Load += new System.EventHandler(this.P_Cursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxProfesor;
        private System.Windows.Forms.ComboBox comboBoxCentros;
        private System.Windows.Forms.Label lbCentro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label lbIdProfesor;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label lbCarreras;
        private System.Windows.Forms.ComboBox comboBoxCarreras;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridView dataGridViewCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Impartir;
        private System.Windows.Forms.Label label2;
    }
}