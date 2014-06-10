using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ProyectoBarajas
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }
        
        private Ad_AdministracionAlumnos adminAl;
        private Ad_AdministracionProfesores adminP;
        private string usuario;

        public String Usuario
        { set { usuario = value;  } } 
        

        private void linkLabelAdminAl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminAl = new Ad_AdministracionAlumnos();
            adminAl.Show();
        }

        private void linkLabelAdminP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            adminP = new Ad_AdministracionProfesores();
            adminP.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lbUsuario.Text = usuario;
            
        }

    }
}
