namespace ProyectoBarajas
{
    partial class Al_CursosSolicitados
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
            this.dataGridViewCursosSolicitados = new System.Windows.Forms.DataGridView();
            this.clavemateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profesor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desinscribirse = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.lbIdalumno = new System.Windows.Forms.Label();
            this.linkLabelLogoutCS = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursosSolicitados)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCursosSolicitados
            // 
            this.dataGridViewCursosSolicitados.AllowUserToAddRows = false;
            this.dataGridViewCursosSolicitados.AllowUserToDeleteRows = false;
            this.dataGridViewCursosSolicitados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursosSolicitados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clavemateria,
            this.materia,
            this.periodo,
            this.profesor,
            this.desinscribirse});
            this.dataGridViewCursosSolicitados.Location = new System.Drawing.Point(26, 44);
            this.dataGridViewCursosSolicitados.Name = "dataGridViewCursosSolicitados";
            this.dataGridViewCursosSolicitados.Size = new System.Drawing.Size(641, 273);
            this.dataGridViewCursosSolicitados.TabIndex = 0;
            this.dataGridViewCursosSolicitados.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCursosSolicitados_CellContentClick);
            // 
            // clavemateria
            // 
            this.clavemateria.DataPropertyName = "idcurso";
            this.clavemateria.HeaderText = "Clave Materia";
            this.clavemateria.Name = "clavemateria";
            // 
            // materia
            // 
            this.materia.DataPropertyName = "curso";
            this.materia.HeaderText = "Materia";
            this.materia.Name = "materia";
            // 
            // periodo
            // 
            this.periodo.DataPropertyName = "periodo";
            this.periodo.HeaderText = "Periodo";
            this.periodo.Name = "periodo";
            // 
            // profesor
            // 
            this.profesor.DataPropertyName = "nombre";
            this.profesor.HeaderText = "Profesor";
            this.profesor.Name = "profesor";
            // 
            // desinscribirse
            // 
            this.desinscribirse.HeaderText = "Desinscribirse";
            this.desinscribirse.Name = "desinscribirse";
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(416, 339);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 1;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(531, 339);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 2;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // lbIdalumno
            // 
            this.lbIdalumno.AutoSize = true;
            this.lbIdalumno.Location = new System.Drawing.Point(592, 9);
            this.lbIdalumno.Name = "lbIdalumno";
            this.lbIdalumno.Size = new System.Drawing.Size(35, 13);
            this.lbIdalumno.TabIndex = 3;
            this.lbIdalumno.Text = "label1";
            // 
            // linkLabelLogoutCS
            // 
            this.linkLabelLogoutCS.AutoSize = true;
            this.linkLabelLogoutCS.Location = new System.Drawing.Point(647, 9);
            this.linkLabelLogoutCS.Name = "linkLabelLogoutCS";
            this.linkLabelLogoutCS.Size = new System.Drawing.Size(40, 13);
            this.linkLabelLogoutCS.TabIndex = 4;
            this.linkLabelLogoutCS.TabStop = true;
            this.linkLabelLogoutCS.Text = "Logout";
            this.linkLabelLogoutCS.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogoutCS_LinkClicked);
            // 
            // Al_CursosSolicitados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 426);
            this.Controls.Add(this.linkLabelLogoutCS);
            this.Controls.Add(this.lbIdalumno);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.dataGridViewCursosSolicitados);
            this.Name = "Al_CursosSolicitados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CursosSolicitados";
            this.Load += new System.EventHandler(this.Al_CursosSolicitados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursosSolicitados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCursosSolicitados;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label lbIdalumno;
        private System.Windows.Forms.LinkLabel linkLabelLogoutCS;
        private System.Windows.Forms.DataGridViewTextBoxColumn clavemateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
        private System.Windows.Forms.DataGridViewTextBoxColumn profesor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn desinscribirse;
    }
}