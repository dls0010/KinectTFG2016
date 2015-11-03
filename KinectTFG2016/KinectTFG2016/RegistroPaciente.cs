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
    /// <summary>
    /// Registro del paciente en la base de datos.
    /// </summary>
    public partial class RegistroPaciente : Form
    {
        public RegistroPaciente()
        {
            InitializeComponent();
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
        ///  Comportamiento de registro del paciente en la base de datos.
        /// </summary>
        /// <param name="sender"></param> Boton de registro.
        /// <param name="e"></param> Argumento del evento.
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            if (Paciente.RegistrarPaciente(textBoxPaciente.Text, textBoxApellidos.Text, textBoxNIF.Text, textBoxNacimiento.Text, textBoxEstado.Text) > 0)
            {
                MessageBox.Show("Paciente registrado con exito.");
            }
            else
            {
                MessageBox.Show("El paciente ha completado mal el formulario.");
            }
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
