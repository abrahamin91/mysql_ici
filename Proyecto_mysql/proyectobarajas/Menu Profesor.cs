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
    public partial class Menu_Profesor : Form
    {
        public Menu_Profesor()
        {
            InitializeComponent();
        }

        private P_Cursos cursos_P;
        private P_AlumnosInscritos inscritos;
        private P_CursoAImpartir cursosAimpartir;
        private string idProfesor;

        public String IdProfesor
        { set { idProfesor = value; } }


        private void Menu_Profesor_Load(object sender, EventArgs e)
        {
            lbLogoutProfesor.Text = idProfesor;
        }

        private void linkLabelCatalogoCursosP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cursos_P = new P_Cursos();
            cursos_P.IdProfesor = idProfesor;
            cursos_P.Show();
        }

        private void linkLabelAlumnosInscritosP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inscritos = new P_AlumnosInscritos();
            inscritos.IdProfesor = idProfesor;
            inscritos.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profesor profesor = new Profesor();
            profesor.Id = idProfesor;
            profesor.Logout_Profesor();
            Application.Restart();
        }

        private void linkLabelCursosImpartir_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cursosAimpartir = new P_CursoAImpartir();
            cursosAimpartir.IdProfesor = idProfesor;
            cursosAimpartir.Show();
        }
    }
}
