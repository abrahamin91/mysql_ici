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
    public partial class Al_CatalogoCursos : Form
    {
        public Al_CatalogoCursos()
        {
            InitializeComponent();
        }
        private string idAlumno;
        private Alumno alumno;
        private String id_carrera;
        private int filaseleccionada;


        public String IdAlumno
        { set { idAlumno = value; } } 

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas salir?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void dataGridViewCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filaseleccionada = Convert.ToInt16(this.dataGridViewCursos.CurrentRow.Index);
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas inscribirse a este curso?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String curso = "";
                foreach (DataGridViewRow row in dataGridViewCursos.Rows)
                {
                    if (row.Cells["inscribir"].Value != null &&
                        (Boolean)row.Cells["inscribir"].Value == true)
                    {
                        curso = row.Cells["ClaveMateria"].Value.ToString();
                    }
                }
                Alumno alumno = new Alumno();
                alumno.Id = idAlumno;
                alumno.Id_Materia = curso;
                alumno.inscribirAlumno();
                alumno.Id_Carrera = id_carrera;
                alumno.mostrar_cursos_disponibles();
                dataGridViewCursos.DataSource = alumno.Tabla;
            }
        }

        private int RowCheckBoxClick()
        {
            int valor = 0;

            if (Convert.ToInt32(dataGridViewCursos.Rows[filaseleccionada].Cells[4].Value) == 1)
            {
                valor = 1;
            }
            else
            {   
                valor = 0; ;
            }



            return valor;
        }

        private void Al_CatalogoCursos_Load(object sender, EventArgs e)
        {
            lbIdAlumno.Text = idAlumno;
            Alumno alumno = new Alumno();
            alumno.Id = idAlumno;
            Cargar_Centros();
        }

        public void Cargar_Centros()
        {
            try
            {
                Alumno alumno = new Alumno();
                comboBoxCentro.DisplayMember = "centro";
                comboBoxCentro.ValueMember = "idcentro";
                alumno.leer_centros();
                comboBoxCentro.DataSource = alumno.Tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void linkLabelLogoutCC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Id = idAlumno;
            alumno.Logout_Alumno();
            Application.Restart();
        }

        private void comboBoxCentro_SelectedIndexChanged(object sender, EventArgs e)
        {
            String valor_curso;
            valor_curso = comboBoxCentro.SelectedValue.ToString();
            Profesor profesor = new Profesor();
            Cargar_Carreras(valor_curso);
        }

        public void Cargar_Carreras(string idcentro)
        {
            try
            {
                Alumno alumno = new Alumno();
                comboBoxCarrera.DisplayMember = "carrera";
                comboBoxCarrera.ValueMember = "idcarrera";
                alumno.Id_Centro = idcentro;
                alumno.consultar_carrerasC();
                comboBoxCarrera.DataSource = alumno.Tabla;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxCarrera_SelectedIndexChanged(object sender, EventArgs e)
        {
            id_carrera = comboBoxCarrera.SelectedValue.ToString();
            LlenarGrid();
        }

        public void LlenarGrid()
        {
            alumno = new Alumno();
            alumno.Id = idAlumno;
            alumno.Id_Carrera = id_carrera;
            if (alumno.mostrar_cursos_disponibles())
            {
                dataGridViewCursos.DataSource = alumno.Tabla;
            }
            else
            {
                MessageBox.Show(alumno.Error);
            }
        }

       

        
    }
}
