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
    public partial class EditarTerapeutas : Form
    {
        public EditarTerapeutas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metodo guarda los datos cambiados por parte del administrador en la BD.
        /// </summary>
        /// <param name="sender"></param> Boton de guardar.
        /// <param name="e"></param> Eventos del boton.
        private void terapeutasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.terapeutasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinectBDDRecursosAdministrador);

        }

        /// <summary>
        /// Metodo que carga los datos en la tabla al cargar el formulario.
        /// </summary>
        /// <param name="sender"></param>  Formulario.
        /// <param name="e"></param> Eventos formulario.
        private void EditarTerapeutas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'kinectBDDRecursosAdministrador.Terapeutas' Puede moverla o quitarla según sea necesario.
            this.terapeutasTableAdapter.Fill(this.kinectBDDRecursosAdministrador.Terapeutas);

        }
    }
}
