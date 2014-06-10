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
    public partial class Al_CursosSolicitados : Form
    {
        public Al_CursosSolicitados()
        {
            InitializeComponent();
        }
        private string idAlumno;
        private int filaseleccionada;


        public String IdAlumno
        { set { idAlumno = value; } } 

        private Alumno alumno;

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas salir?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas desincribirse de este curso?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String curso = "";
                foreach (DataGridViewRow row in dataGridViewCursosSolicitados.Rows)
                {
                    if (row.Cells["desinscribirse"].Value != null &&
                        (Boolean)row.Cells["desinscribirse"].Value == true)
                    {
                        curso = row.Cells["clavemateria"].Value.ToString();
                    }
                }
                Alumno alumno = new Alumno();
                alumno.Id = idAlumno;
                alumno.Id_Materia = curso;
                alumno.desinscribirAlumno();
                LlenarGrid();
            }
        }

        private int RowCheckBoxClick()
        {
            int valor = 0;

            if ((bool)(dataGridViewCursosSolicitados.Rows[filaseleccionada].Cells[4].Value) == true)
            {
                valor = 1;
            }
            else
            {
                valor = 0; ;
            }

            return valor;
        }

        private void Al_CursosSolicitados_Load(object sender, EventArgs e)
        {
            lbIdalumno.Text = idAlumno;
            LlenarGrid();
        }

        public void LlenarGrid()
        {
            alumno = new Alumno();
            alumno.Id = idAlumno;
            if (alumno.consultar_materiasinscritas())
            {
                dataGridViewCursosSolicitados.DataSource = alumno.Tabla;
            }
            else
            {
                MessageBox.Show(alumno.Error);
            }
        }

        private void linkLabelLogoutCS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Id = idAlumno;
            alumno.Logout_Alumno();
            Application.Restart();
        }

        private void dataGridViewCursosSolicitados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            filaseleccionada = Convert.ToInt16(this.dataGridViewCursosSolicitados.CurrentRow.Index);
        }
    }
}
