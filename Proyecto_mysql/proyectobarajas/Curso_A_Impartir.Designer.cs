namespace ProyectoBarajas
{
    partial class P_CursoAImpartir
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
            this.lbIdprofesor = new System.Windows.Forms.Label();
            this.linkLabelLogout = new System.Windows.Forms.LinkLabel();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.dataGridViewCursosImpartir = new System.Windows.Forms.DataGridView();
            this.clavemateria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.periodo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noimpartir = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursosImpartir)).BeginInit();
            this.SuspendLayout();
            // 
            // lbIdprofesor
            // 
            this.lbIdprofesor.AutoSize = true;
            this.lbIdprofesor.Location = new System.Drawing.Point(411, 9);
            this.lbIdprofesor.Name = "lbIdprofesor";
            this.lbIdprofesor.Size = new System.Drawing.Size(35, 13);
            this.lbIdprofesor.TabIndex = 0;
            this.lbIdprofesor.Text = "label1";
            // 
            // linkLabelLogout
            // 
            this.linkLabelLogout.AutoSize = true;
            this.linkLabelLogout.Location = new System.Drawing.Point(477, 9);
            this.linkLabelLogout.Name = "linkLabelLogout";
            this.linkLabelLogout.Size = new System.Drawing.Size(40, 13);
            this.linkLabelLogout.TabIndex = 1;
            this.linkLabelLogout.TabStop = true;
            this.linkLabelLogout.Text = "Logout";
            this.linkLabelLogout.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogout_LinkClicked);
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(123, 311);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Location = new System.Drawing.Point(247, 311);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            this.buttonCancelar.Click += new System.EventHandler(this.buttonCancelar_Click);
            // 
            // dataGridViewCursosImpartir
            // 
            this.dataGridViewCursosImpartir.AllowUserToAddRows = false;
            this.dataGridViewCursosImpartir.AllowUserToDeleteRows = false;
            this.dataGridViewCursosImpartir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCursosImpartir.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clavemateria,
            this.materia,
            this.periodo,
            this.noimpartir});
            this.dataGridViewCursosImpartir.Location = new System.Drawing.Point(35, 43);
            this.dataGridViewCursosImpartir.Name = "dataGridViewCursosImpartir";
            this.dataGridViewCursosImpartir.Size = new System.Drawing.Size(464, 244);
            this.dataGridViewCursosImpartir.TabIndex = 4;
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
            // noimpartir
            // 
            this.noimpartir.HeaderText = "No impartir";
            this.noimpartir.Name = "noimpartir";
            // 
            // P_CursoAImpartir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 346);
            this.Controls.Add(this.dataGridViewCursosImpartir);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.linkLabelLogout);
            this.Controls.Add(this.lbIdprofesor);
            this.Name = "P_CursoAImpartir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Curso A Impartir";
            this.Load += new System.EventHandler(this.P_CursoAImpartir_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCursosImpartir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbIdprofesor;
        private System.Windows.Forms.LinkLabel linkLabelLogout;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.DataGridView dataGridViewCursosImpartir;
        private System.Windows.Forms.DataGridViewTextBoxColumn clavemateria;
        private System.Windows.Forms.DataGridViewTextBoxColumn materia;
        private System.Windows.Forms.DataGridViewTextBoxColumn periodo;
        private System.Windows.Forms.DataGridViewCheckBoxColumn noimpartir;
    }
}