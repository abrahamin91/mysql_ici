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
    public partial class P_CursoAImpartir : Form
    {
        public P_CursoAImpartir()
        {
            InitializeComponent();
        }
        private string idProfesor;

        public String IdProfesor
        { set { idProfesor = value; } }

        private void P_CursoAImpartir_Load(object sender, EventArgs e)
        {
            lbIdprofesor.Text = idProfesor;
            Profesor profesor = new Profesor();
            profesor.Id = idProfesor;
            profesor.cursos_a_impartir();
            dataGridViewCursosImpartir.DataSource = profesor.Tabla;
        }

        private void linkLabelLogout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Profesor profesor = new Profesor();
            profesor.Id = idProfesor;
            profesor.Logout_Profesor();
            Application.Restart();
        }

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
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas no impartit este curso?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                String curso = "";
                foreach (DataGridViewRow row in dataGridViewCursosImpartir.Rows)
                {
                    if (row.Cells["noimpartir"].Value != null &&
                        (Boolean)row.Cells["noimpartir"].Value == true)
                    {
                        curso = row.Cells[1].Value.ToString();
                    }
                }
                Profesor profesor = new Profesor();
                profesor.Id = idProfesor;
                profesor.Id_Curso = curso;
                profesor.no_impartir_curso();
                profesor.cursos_a_impartir();
                dataGridViewCursosImpartir.DataSource = profesor.Tabla;
            }
        }
    }
}
