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
    public partial class Menu_Alumno : Form
    {
        public Menu_Alumno()
        {
            InitializeComponent();
        }

        private Al_CalificacionesAlumnos calificaciones;
        private Al_CatalogoCursos catalogo;
        private Al_CursosSolicitados cursosAl;
        private string idAlumno;

        public String IdAlumno
        { set { idAlumno = value; } } 

        private void Menu_Alumnos_Load(object sender, EventArgs e)
        {
            lbUsuario.Text = idAlumno;
        }

        private void linkLabelCalificacionesAl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            calificaciones = new Al_CalificacionesAlumnos();
            calificaciones.IdAlumno = idAlumno;
            calificaciones.Show();
        }

        private void linkLabelCatalogoCursosAl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            catalogo = new Al_CatalogoCursos();
            catalogo.IdAlumno = idAlumno;
            catalogo.Show();
        }

        private void linkLabelCursosAl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cursosAl = new Al_CursosSolicitados();
            cursosAl.IdAlumno = idAlumno;
            cursosAl.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void linkLabelAlumno_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Id = idAlumno;
            alumno.Logout_Alumno();
            Application.Restart();
        }
    }
}
