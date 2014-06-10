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
    public partial class Ad_AdministracionProfesores : Form
    {
        Profesor profesor;
        DialogResult res;

        public Ad_AdministracionProfesores()
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

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Profesor profesor = new Profesor();
            profesor.Id = txtBusqueda.Text;
            if (profesor.Id != "")
            {
                profesor.BuscarProfesor();
                dataGridViewProfesores.DataSource = profesor.Tabla;

                if (dataGridViewProfesores.Rows.Count <= 0)
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


        private void dataGridViewAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ad_AdministracionProfesores_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        public void LlenarGrid()
        {
            profesor = new Profesor();
            if (profesor.leerProfesor())
            {
                dataGridViewProfesores.DataSource = profesor.Tabla;
            }
            else
            {
                MessageBox.Show(profesor.Error);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            res = MessageBox.Show("¿Desea guardar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Profesor profesor = new Profesor(txtId.Text, txtContrasena.Text, txtNombre.Text, txtApepat.Text, txtApemat.Text, txtDomicilio.Text,
                                    txtCp.Text, txtColonia.Text, txtMunicipio.Text, txtEstado.Text, "", "", "");
                profesor.AgregarProfesor();
                LlenarGrid();
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            res = MessageBox.Show("¿Desea eliminar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Profesor profesor = new Profesor();
                profesor.Id = txtId.Text;
                profesor.EliminarProfesor();
                LlenarGrid();
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            res = MessageBox.Show("¿Desea modificar el registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Profesor profesor = new Profesor(txtId.Text, txtContrasena.Text, txtNombre.Text, txtApepat.Text, txtApemat.Text, txtDomicilio.Text,
                                    txtCp.Text, txtColonia.Text, txtMunicipio.Text, txtEstado.Text, "", "", "");
                profesor.ModificarProfesor();
                LlenarGrid();
            }
        }

        private void dataGridViewProfesores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridViewProfesores.CurrentRow.Cells[0].Value.ToString();
            txtContrasena.Text = dataGridViewProfesores.CurrentRow.Cells[1].Value.ToString();
            txtNombre.Text = dataGridViewProfesores.CurrentRow.Cells[2].Value.ToString();
            txtApepat.Text = dataGridViewProfesores.CurrentRow.Cells[3].Value.ToString();
            txtApemat.Text = dataGridViewProfesores.CurrentRow.Cells[4].Value.ToString();
            txtDomicilio.Text = dataGridViewProfesores.CurrentRow.Cells[5].Value.ToString();
            txtCp.Text = dataGridViewProfesores.CurrentRow.Cells[6].Value.ToString();
            txtColonia.Text = dataGridViewProfesores.CurrentRow.Cells[7].Value.ToString();
            txtMunicipio.Text = dataGridViewProfesores.CurrentRow.Cells[8].Value.ToString();
            txtEstado.Text = dataGridViewProfesores.CurrentRow.Cells[9].Value.ToString();
        }

    }
}
