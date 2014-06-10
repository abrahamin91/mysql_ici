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
            this.lbAdministrador = new System.Windows.Forms.Label();
            this.linkLabelAdminAl = new System.Windows.Forms.LinkLabel();
            this.linkLabelAdminP = new System.Windows.Forms.LinkLabel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.lbUsuario = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbAdministrador
            // 
            this.lbAdministrador.AutoSize = true;
            this.lbAdministrador.Location = new System.Drawing.Point(12, 9);
            this.lbAdministrador.Name = "lbAdministrador";
            this.lbAdministrador.Size = new System.Drawing.Size(70, 13);
            this.lbAdministrador.TabIndex = 5;
            this.lbAdministrador.Text = "Administrador";
            this.lbAdministrador.Visible = false;
            // 
            // linkLabelAdminAl
            // 
            this.linkLabelAdminAl.AutoSize = true;
            this.linkLabelAdminAl.Location = new System.Drawing.Point(25, 36);
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
            this.linkLabelAdminP.Location = new System.Drawing.Point(27, 62);
            this.linkLabelAdminP.Name = "linkLabelAdminP";
            this.linkLabelAdminP.Size = new System.Drawing.Size(117, 13);
            this.linkLabelAdminP.TabIndex = 9;
            this.linkLabelAdminP.TabStop = true;
            this.linkLabelAdminP.Text = "Administración Profesor";
            this.linkLabelAdminP.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelAdminP_LinkClicked);
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(59, 115);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(75, 23);
            this.buttonSalir.TabIndex = 12;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Location = new System.Drawing.Point(282, 9);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(35, 13);
            this.lbUsuario.TabIndex = 13;
            this.lbUsuario.Text = "label4";
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 231);
            this.Controls.Add(this.lbUsuario);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.linkLabelAdminP);
            this.Controls.Add(this.linkLabelAdminAl);
            this.Controls.Add(this.lbAdministrador);
            this.Name = "MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabelAdminAl;
        private System.Windows.Forms.LinkLabel linkLabelAdminP;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbAdministrador;
    }
}