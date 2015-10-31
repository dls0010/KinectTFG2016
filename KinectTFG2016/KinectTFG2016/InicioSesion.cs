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
    /// Autentificarse en la Base de Datos o registrarse en ella.
    /// </summary>
    public partial class InicioSesion : Form
    {
        public InicioSesion()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Comportamiento del botón Iniciar Sesión.
        /// </summary>
        /// <param name="sender"></param> Boton Iniciar Sesion.
        /// <param name="e"></param> Argumento del evento.
        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            if (Usuario.Autentificar(textBoxUsuario.Text, textBoxContraseña.Text) > 0)
            {
                MessageBox.Show("Usuario correcto");

            }
            else
            {
                MessageBox.Show("Usuario no registrado, por favor registrase");
                RegistroUsuario ventana = new RegistroUsuario();
                ventana.ShowDialog();
            }
        }

        /// <summary>
        ///  Comportamiento del botón Registrarse.
        /// </summary>
        /// <param name="sender"></param> Boton Registrarse.
        /// <param name="e"></param> Argumento del evento.
        private void buttonRegistrarse_Click(object sender, EventArgs e)
        {
            RegistroUsuario ventana = new RegistroUsuario();
            ventana.Show();
        }
    }
}
