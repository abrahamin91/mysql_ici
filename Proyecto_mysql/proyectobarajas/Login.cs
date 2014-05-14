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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private MenuPrincipal menu = new MenuPrincipal();

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            menu.Show();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
