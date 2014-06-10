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
    public partial class Al_CalificacionesAlumnos : Form
    {
        public Al_CalificacionesAlumnos()
        {
            InitializeComponent();
        }
        private string idAlumno;

        public String IdAlumno
        { set { idAlumno = value; } } 

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas salir?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }


        public void LlenarGrid()
        {
            Alumno alumno = new Alumno();
            alumno.Id = idAlumno;
            if (alumno.consultar_calificaciones())
            {
                dataGridViewCalificaciones.DataSource = alumno.Tabla;
            }
            else
            {
                MessageBox.Show(alumno.Error);
            }
        }

        private void linkLabelLogutCA_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Id = idAlumno;
            alumno.Logout_Alumno();
            Application.Restart();
        }

        private void Al_CalificacionesAlumnos_Load(object sender, EventArgs e)
        {
            lbidAlumno.Text = idAlumno;
            Alumno alumno = new Alumno();
            alumno.Id = idAlumno;
            alumno.obtener_nombreA();
            textBoxAlumno.Text = alumno.Tabla.Rows[0][0].ToString();
            LlenarGrid();
        }
    }
}
