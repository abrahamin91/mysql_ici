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
    public partial class P_Cursos : Form
    {
        public P_Cursos()
        {
            InitializeComponent();
        }
        private string idProfesor;

        public String IdProfesor
        { set { idProfesor = value; } }

        private String id_carrera;

        private void P_Cursos_Load(object sender, EventArgs e)
        {
            lbIdProfesor.Text = idProfesor;
            Profesor profesor = new Profesor();
            profesor.Id = idProfesor;
            profesor.obtener_nombreP();
            textBoxProfesor.Text = profesor.Tabla.Rows[0][0].ToString();
            Cargar_Cursos();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
                comboBoxCentros.DisplayMember = "centro";
                comboBoxCentros.ValueMember = "idcentro";
                profesor.leer_centros();
                comboBoxCentros.DataSource = profesor.Tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void Cargar_Materias(string idcentro)
        {
            try
            {
                Profesor profesor = new Profesor();
                comboBoxCarreras.DisplayMember = "carrera";
                comboBoxCarreras.ValueMember = "idcarrera";
                profesor.Id_Centro = idcentro;
                profesor.consultar_carrerasC();
                comboBoxCarreras.DataSource = profesor.Tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            String valor_curso;
            valor_curso = comboBoxCentros.SelectedValue.ToString();
            Profesor profesor = new Profesor();
            Cargar_Materias(valor_curso);
        }

        private void comboBoxCarreras_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            id_carrera = comboBoxCarreras.SelectedValue.ToString();
            Profesor profesor = new Profesor();
            profesor.Id_Carrera = id_carrera;
            profesor.mostrar_cursos_disponibles();
            dataGridViewCursos.DataSource = profesor.Tabla;
        }

        private void textBoxProfesor_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas impartir este curso?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String curso = "";
                foreach (DataGridViewRow row in dataGridViewCursos.Rows)
                {
                    if (row.Cells["impartir"].Value != null &&
                        (Boolean)row.Cells["impartir"].Value == true)
                    {
                        curso = row.Cells[1].Value.ToString();
                    }
                }
                Profesor profesor = new Profesor();
                profesor.Id = idProfesor;
                profesor.Id_Curso = curso;
                profesor.impartir_Cursos();
                profesor.Id_Carrera = id_carrera;
                profesor.mostrar_cursos_disponibles();
                dataGridViewCursos.DataSource = profesor.Tabla;
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas salir?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }


    }
}
