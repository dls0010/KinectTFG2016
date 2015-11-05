using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinectTFG2016.RecursosAdministrador;

namespace KinectTFG2016
{
    public partial class InicioAdministrador : Form
    {
        /// <summary>
        /// Formulario encargado en las acciones del Administrador.
        /// </summary>
        public InicioAdministrador()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que enlaza con el formulario de editar pacientes.
        /// </summary>
        /// <param name="sender"></param> Boton EditarPacientes.
        /// <param name="e"></param> Eventos del boton.
        private void buttonEditarPacientes_Click(object sender, EventArgs e)
        {
            EditarPacientes editarPacientes = new EditarPacientes();
            editarPacientes.Show();
        }

        /// <summary>
        /// Metodo que enlaza con el formulario de editar terapeutas.
        /// </summary>
        /// <param name="sender"></param> Boton EditarTerapeutas.
        /// <param name="e"></param> Eventos del boton.
        private void buttonEditarTerapeutas_Click(object sender, EventArgs e)
        {
            EditarTerapeutas editarTerapeutas = new EditarTerapeutas();
            editarTerapeutas.Show();
        }
    }
}
