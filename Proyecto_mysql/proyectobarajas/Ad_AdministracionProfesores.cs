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
        public Ad_AdministracionProfesores()
        {
            InitializeComponent();
        }

        private Ad_NuevoProfesor nuevoPr;
        private Ad_ContactosProfesores contactPr;

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
            MessageBox.Show("Resultados de la busqueda...");
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

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            nuevoPr = new Ad_NuevoProfesor();
            nuevoPr.Show();
        }

        private void dataGridViewAlumnos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewAlumnos.Columns[8].Index && e.RowIndex >= 0)
            {
                contactPr = new Ad_ContactosProfesores();
                contactPr.Show();
            }
        }

    }
}
