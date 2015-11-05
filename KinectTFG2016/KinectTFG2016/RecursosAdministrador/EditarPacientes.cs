using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KinectTFG2016.RecursosAdministrador
{
    /// <summary>
    /// Formulario para editar los datos de los pacientes.
    /// </summary>
    public partial class EditarPacientes : Form
    {
        public EditarPacientes()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo guarda los datos cambiados por parte del administrador en la BD.
        /// </summary>
        /// <param name="sender"></param> Boton de guardar.
        /// <param name="e"></param> Eventos del boton.
        private void pacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinectBDDRecursosAdministrador);

        }

        /// <summary>
        /// Metodo que carga los datos en la tabla al cargar el formulario.
        /// </summary>
        /// <param name="sender"></param>  Formulario.
        /// <param name="e"></param> Eventos formulario.
        private void EditarPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'kinectBDDRecursosAdministrador.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.kinectBDDRecursosAdministrador.Pacientes);

        }
    }
}
