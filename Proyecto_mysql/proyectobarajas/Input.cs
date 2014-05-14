using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace ProyectoBarajas
{

    public static class Inputbox
    {

        // Conserva esta cabecera

        static Form formNuevoCliente;
        static Label label;
        static TextBox textbox; // Elementos necesarios
        static Button botonAceptar;
        static Button botonCancelar;
        static string nombre;

        /// <summary>
        /// Objeto Estático que muestra un pequeño diálogo para introducir datos
        /// </summary>
        /// <param name="title">Título del diálogo</param>
        /// <param name="prompt">Texto de información</param>
        /// <param name="posicion">Posición de inicio</param>
        /// <returns>Devuelve la escrito en la caja de texto como string</returns>
        public static string Show(String texto)
        {

            formNuevoCliente = new Form();
            formNuevoCliente.Text = "Ingresar";
            formNuevoCliente.ShowIcon = false;
            formNuevoCliente.Icon = null;
            formNuevoCliente.KeyPreview = true;
            formNuevoCliente.ShowInTaskbar = false;
            formNuevoCliente.MaximizeBox = false;
            formNuevoCliente.MinimizeBox = false;
            formNuevoCliente.FormBorderStyle = FormBorderStyle.FixedDialog;
            formNuevoCliente.StartPosition = FormStartPosition.CenterScreen;
            formNuevoCliente.Size = new System.Drawing.Size(600, 300);
            formNuevoCliente.KeyPress += new KeyPressEventHandler(f_KeyPress);

            label = new Label();
            label.AutoSize = true;
            label.Text = texto;
            label.Top = 20;
            label.Left = 20;
            label.Font = new Font("Microsoft Sans Serif", 18);

            textbox = new TextBox();
            textbox.Size = new Size(550, 35);
            textbox.Top = 80;
            textbox.Left = 20;
            textbox.Font = new Font("Microsoft Sans Serif", 18);

            botonAceptar = new Button();
            botonAceptar.Text = "Aceptar";
            botonAceptar.Click += new EventHandler(b1_Click);
            botonAceptar.Size = new Size(150, 40);
            botonAceptar.Top = 130;
            botonAceptar.Left = 270;
            botonAceptar.Font = new Font("Microsoft Sans Serif", 18);

            botonCancelar = new Button();
            botonCancelar.Text = "Cancelar";
            botonCancelar.Click += new EventHandler(b2_Click);
            botonCancelar.Size = new Size(150, 40);
            botonCancelar.Top = 130;
            botonCancelar.Left = botonAceptar.Left + 160;
            botonCancelar.Font = new Font("Microsoft Sans Serif", 18);


            formNuevoCliente.Controls.Add(label);
            formNuevoCliente.Controls.Add(textbox);
            formNuevoCliente.Controls.Add(botonAceptar);
            formNuevoCliente.Controls.Add(botonCancelar);


            formNuevoCliente.ShowDialog();
            return (nombre);
        }

        static void f_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (Convert.ToChar(e.KeyChar))
            {

                case ('\r'):
                    Acepta();
                    break; ;

                case (''):
                    Cancela();
                    break; ;
            }
        }
        static void b2_Click(object sender, EventArgs e)
        {
            Cancela();
        }
        static void b1_Click(object sender, EventArgs e)
        {
            Acepta();
        }
        private static string Val
        {
            get { return (nombre); }
            set { nombre = value; }
        }
        private static void Acepta()
        {
            Val = textbox.Text;
            formNuevoCliente.Dispose();
        }
        private static void Cancela()
        {
            Val = null;
            formNuevoCliente.Dispose();
        }


    }
}
