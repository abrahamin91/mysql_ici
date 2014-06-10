namespace ProyectoBarajas
{
    partial class Al_CatalogoCursos
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCentro = new System.Windows.Forms.ComboBox();
            this.comboBoxCarrera = new System.Windows.Forms.ComboBox();
            this.dataGridViewCursos = new System.Windows.Forms.DataGridView();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.lbIdAlumno = new System.Windows.Forms.Label();
            this.linkLabelLogoutCC = new System.Windows.Forms.LinkLabel();
            this.ClaveMateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inscribir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Centro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Carrera";
            // 
            // comboBoxCentro
            // 
            this.comboBoxCentro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCentro.FormattingEnabled = true;
            this.comboBoxCentro.Location = new System.Drawing.Point(178, 19);
            this.comboBoxCentro.Name = "comboBoxCentro";
            this.comboBoxCentro.Size = new System.Drawing.Size(222, 21);
            this.comboBoxCentro.TabIndex = 2;
            this.comboBoxCentro.SelectedIndexChanged += new System.EventHandler(this.comboBoxCentro_SelectedIndexChanged);
            // 
            // comboBoxCarrera
            // 
            this.comboBoxCarrera.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCarrera.FormattingEnabled = true;
            this.comboBoxCarrera.Location = new System.Drawing.Point(178, 49);
            this.comboBoxCarrera.Name = "comboBoxCarrera";
            this.comboBoxCarrera.Size = new System.Drawing.Size(222, 21);
            this.comboBoxCarrera.TabIndex = 3;
            this.comboBoxCarrera.SelectedIndexChanged += new System.EventHandler(this.comboBoxCarrera_SelectedIndexChanged);
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
            this.profesor,
            this.inscribir});
            this.dataGridViewCursos.Location = new System.Drawing.Point(24, 113);
            this.dataGridViewCursos.Name = "dataGridViewCursos";
            this.dataGridViewCursos.Size = new System.Drawing.Size(644, 182);
            this.dataGridViewCursos.TabIndex = 4;
            this.dataGridViewCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCursos_CellContentClick);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(420, 60);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 5;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(535, 60);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 6;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // lbIdAlumno
            // 
            this.lbIdAlumno.AutoSize = true;
            this.lbIdAlumno.Location = new System.Drawing.Point(589, 9);
            this.lbIdAlumno.Name = "lbIdAlumno";
            this.lbIdAlumno.Size = new System.Drawing.Size(35, 13);
            this.lbIdAlumno.TabIndex = 7;
            this.lbIdAlumno.Text = "label3";
            // 
            // linkLabelLogoutCC
            // 
            this.linkLabelLogoutCC.AutoSize = true;
            this.linkLabelLogoutCC.Location = new System.Drawing.Point(647, 9);
            this.linkLabelLogoutCC.Name = "linkLabelLogoutCC";
            this.linkLabelLogoutCC.Size = new System.Drawing.Size(40, 13);
            this.linkLabelLogoutCC.TabIndex = 8;
            this.linkLabelLogoutCC.TabStop = true;
            this.linkLabelLogoutCC.Text = "Logout";
            this.linkLabelLogoutCC.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogoutCC_LinkClicked);
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
            this.Materia.HeaderText = "Materia";
            this.Materia.Name = "Materia";
            // 
            // Periodo
            // 
            this.Periodo.DataPropertyName = "periodo";
            this.Periodo.HeaderText = "Periodo";
            this.Periodo.Name = "Periodo";
            // 
            // profesor
            // 
            this.profesor.DataPropertyName = "nombre";
            this.profesor.HeaderText = "Profesor";
            this.profesor.Name = "profesor";
            // 
            // inscribir
            // 
            this.inscribir.HeaderText = "Inscribir";
            this.inscribir.Name = "inscribir";
            // 
            // Al_CatalogoCursos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 328);
            this.Controls.Add(this.linkLabelLogoutCC);
            this.Controls.Add(this.lbIdAlumno);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.dataGridViewCursos);
            this.Controls.Add(this.comboBoxCarrera);
            this.Controls.Add(this.comboBoxCentro);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Al_CatalogoCursos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo Cursos";
            this.Load += new System.EventHandler(this.Al_CatalogoCursos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCentro;
        private System.Windows.Forms.ComboBox comboBoxCarrera;
        private System.Windows.Forms.DataGridView dataGridViewCursos;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label lbIdAlumno;
        private System.Windows.Forms.LinkLabel linkLabelLogoutCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClaveMateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn inscribir;
    }
}