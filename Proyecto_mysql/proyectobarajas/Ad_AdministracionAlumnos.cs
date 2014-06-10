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
    public partial class Ad_AdministracionAlumnos : Form
    {
        Alumno alumno;
        DialogResult res;

        public Ad_AdministracionAlumnos()
        {
            InitializeComponent();
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
            this.Close();
        }

        private void buttonAceptar_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Desea guardar cambios?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonCancelar_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Seguro que deseas salir?", "Advertencia", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.Id = txtBusqueda.Text;
            if (alumno.Id != "")
            {
                    alumno.BuscarAlumno();
                    dataGridViewAlumnos.DataSource = alumno.Tabla;

                    if (dataGridViewAlumnos.Rows.Count <= 0)
                    {
                        MessageBox.Show("No Existe Dato");
                        LlenarGrid();
                    }
            }
            else
            {
                LlenarGrid();
            }
        }


        private void Ad_AdministracionAlumnos_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        public void LlenarGrid()
        {
            alumno = new Alumno();
            if (alumno.leerAlumnos())
            {
                dataGridViewAlumnos.DataSource = alumno.Tabla;
            }
            else
            {
                MessageBox.Show(alumno.Error);
            }
        }


        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if ((txtcontrasena.Text != "") && (txtNombre.Text != "") && (txtApepat.Text != "") && (txtApemat.Text != "") && (txtDomicilio.Text != "")
                    && (txtCp.Text != "") && (txtColonia.Text != "") && (txtMunicipio.Text != "") && (txtEstado.Text != ""))
            {
                res = MessageBox.Show("¿Desea guardar el registro?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {

                    Alumno alumno = new Alumno(txtId.Text, txtcontrasena.Text, txtNombre.Text, txtApepat.Text, txtApemat.Text, txtDomicilio.Text,
                                            txtCp.Text, txtColonia.Text, txtMunicipio.Text, txtEstado.Text, "", "");
                        alumno.AgregarAlumno();
                        LlenarGrid();
                }
            }
            else
            {
                MessageBox.Show("Datos incompletos");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            res = MessageBox.Show("¿Desea eliminar el registro?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Alumno alumno = new Alumno();
                alumno.Id = txtId.Text;
                alumno.EliminarAlumno();
                LlenarGrid();
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            res = MessageBox.Show("¿Desea modificar el registro?","Aviso",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Alumno alumno = new Alumno(txtId.Text, txtcontrasena.Text, txtNombre.Text, txtApepat.Text, txtApemat.Text, txtDomicilio.Text,
                                    txtCp.Text, txtColonia.Text, txtMunicipio.Text, txtEstado.Text, "", "");
                alumno.ModificarAlumno();
                LlenarGrid();
            }
        }

        private void dataGridViewAlumnos_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridViewAlumnos.CurrentRow.Cells[0].Value.ToString();
            txtcontrasena.Text = dataGridViewAlumnos.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dataGridViewAlumnos.CurrentRow.Cells[2].Value.ToString();
            txtApepat.Text = dataGridViewAlumnos.CurrentRow.Cells[3].Value.ToString();
            txtApemat.Text = dataGridViewAlumnos.CurrentRow.Cells[4].Value.ToString();
            txtDomicilio.Text = dataGridViewAlumnos.CurrentRow.Cells[5].Value.ToString();
            txtCp.Text = dataGridViewAlumnos.CurrentRow.Cells[6].Value.ToString();
            txtColonia.Text = dataGridViewAlumnos.CurrentRow.Cells[7].Value.ToString();
            txtMunicipio.Text = dataGridViewAlumnos.CurrentRow.Cells[8].Value.ToString();
            txtEstado.Text = dataGridViewAlumnos.CurrentRow.Cells[9].Value.ToString();
        }

    }
}
