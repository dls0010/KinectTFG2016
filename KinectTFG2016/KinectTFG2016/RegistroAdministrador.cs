﻿using KinectTFG2016.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinectTFG2016
{
    public partial class RegistroAdministrador : Form
    {
        string nombreUsuario;
        public RegistroAdministrador(string usuario)
        {
            nombreUsuario = usuario;
            InitializeComponent();
        }

        /// <summary>
        /// Comportamiento de registro del administrador en la base de datos.
        /// </summary>
        /// <param name="sender"></param> Boton de registro.
        /// <param name="e"></param>  Argumento del evento.
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (Administrador.registrarAdministrador(textBoxPaciente.Text, textBoxApellidos.Text, nombreUsuario, textBoxNIF.Text, textBoxNacimiento.Text) > 0)
            {
                MessageBox.Show("Administrador registrado con exito.");
                this.Close();
            }
            else
            {
                MessageBox.Show("El administrador ha completado mal el formulario.");
            }
        }

        /// <summary>
        /// Comportamiento del boton cancelar. Cerrará la ventana.
        /// </summary>
        /// <param name="sender"></param> Boton cancelar.
        /// <param name="e"></param> Argumento del evento.
        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Inserccion de la fecha seleccionada por el usuario en un texbox.
        /// </summary>
        /// <param name="sender"></param> DateTimePicker
        /// <param name="e"></param> Argumento del evento.
        private void calendarioDate_ValueChanged(object sender, EventArgs e)
        {
            textBoxNacimiento.Text = calendarioDate.Value.ToString("yyyy/MM/dd");
        }
    }
}
