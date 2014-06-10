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


        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            if ((txtUsuario.Text == "admin") && txtContrasena.Text == "admin")
            {
                MenuPrincipal menu = new MenuPrincipal();
                string c = "Administrador";
                menu.Usuario = c;
                menu.Show();
                this.Hide();
            }
            else if(txtUsuario.TextLength == 6)
            {
                try
                {
                    Menu_Alumno menuA = new Menu_Alumno();
                    string dato1;
                    Alumno alumno = new Alumno();
                    alumno.Id = txtUsuario.Text;
                    alumno.Contrasena = txtContrasena.Text;
                    alumno.Login_Alumno();
                    dato1 = alumno.Tabla.Rows[0][0].ToString();
                    menuA.IdAlumno = dato1;
                    menuA.Show();
                    this.Hide();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Usuario y Contraseña Incorrectos", ex.Message);
                }
            }
            else if (txtUsuario.TextLength == 5)
            {
                try
                {
                    Menu_Profesor menuP = new Menu_Profesor();
                    string dato1;
                    Profesor profesor = new Profesor();
                    profesor.Id = txtUsuario.Text;
                    profesor.Contrasena = txtContrasena.Text;
                    profesor.Login_Profesor();
                    dato1 = profesor.Tabla.Rows[0][0].ToString();
                    menuP.IdProfesor = dato1;
                    menuP.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Usuario y Contraseña Incorrectos", ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Usuario y Contraseña Incorrectos");
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
