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
    public partial class P_AlumnosInscritos : Form
    {
        public P_AlumnosInscritos()
        {
            InitializeComponent();
        }
        private string idProfesor;

        public String IdProfesor
        { set { idProfesor = value; } }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas salir?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void P_AlumnosInscritos_Load(object sender, EventArgs e)
        {
            lbIdProfesor.Text = idProfesor;
            Profesor profesor = new Profesor();
            profesor.Id = idProfesor;
            profesor.obtener_nombreP();
            textBoxProfesor.Text = profesor.Tabla.Rows[0][0].ToString();
            Cargar_Cursos();
        }

        private void linkLabelLogoutAI_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profesor profesor = new Profesor();
            profesor.Id = idProfesor;
            profesor.Logout_Profesor();
            Application.Restart();
        }
        public void Cargar_Cursos()
        {
            try
            {
                Profesor profesor = new Profesor();
                comboBoxCursos.DisplayMember = "curso";
                comboBoxCursos.ValueMember = "idcurso";
                profesor.Id = idProfesor;
                profesor.cursos_a_impartir();
                comboBoxCursos.DataSource = profesor.Tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void comboBoxCursos_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            String valor_curso;
            valor_curso = comboBoxCursos.SelectedValue.ToString();
            Profesor profesor = new Profesor();
            profesor.Id_Curso = valor_curso;
            profesor.alumnos_inscritos();
            dataGridViewAlumnosInscritos.DataSource = profesor.Tabla;
        }
    }
}
