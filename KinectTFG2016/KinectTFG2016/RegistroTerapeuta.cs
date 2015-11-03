using KinectTFG2016.Clases;
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
    public partial class RegistroTerapeuta : Form
    {
        public RegistroTerapeuta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Comportamiento de registro del terapeuta en la base de datos.
        /// </summary>
        /// <param name="sender"></param> Boton de registro.
        /// <param name="e"></param>  Argumento del evento.
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (Terapeuta.registrarTerapeuta(textBoxPaciente.Text, textBoxApellidos.Text, textBoxNIF.Text, textBoxNacimiento.Text) > 0)
            {
                MessageBox.Show("Terapeuta registrado con exito.");
                this.Close();

            }
            else
            {
                MessageBox.Show("El terapeuta ha completado mal el formulario.");
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
