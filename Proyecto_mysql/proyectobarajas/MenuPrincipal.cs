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

        private Al_CalificacionesAlumnos calificaciones;
        private Al_CatalogoCursos catalogo;
        private Al_CursosSolicitados cursosAl;
        private P_Cursos cursos_P;
        private P_AlumnosInscritos inscritos;
        private Ad_AdministracionAlumnos adminAl;
        private Ad_AdministracionProfesores adminP;
        private Ad_ContactosAlumnos contactosAl;
        private Ad_ContactosProfesores contactosP;
        
        private void linkLabelCalificacionesAl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            calificaciones = new Al_CalificacionesAlumnos();
            calificaciones.Show();
        }

        private void linkLabelCatalogoCursosAl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            catalogo = new Al_CatalogoCursos();
            catalogo.Show();
        }

        private void linkLabelCursosAl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cursosAl = new Al_CursosSolicitados();
            cursosAl.Show();
        }

        private void linkLabelCatalogoCursosP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            cursos_P = new P_Cursos();
            cursos_P.Show();
        }

        private void linkLabelAlumnosInscritosP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            inscritos = new P_AlumnosInscritos();
            inscritos.Show();
        }

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

        private void linkLabelContactoAl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            contactosAl = new Ad_ContactosAlumnos();
            contactosAl.Show();
        }

        private void linkLabelContactoP_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            contactosP = new Ad_ContactosProfesores();
            contactosP.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas salir de la aplicación?", "Advertencia", MessageBoxButtons.YesNo);

            if (dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


    }
}
