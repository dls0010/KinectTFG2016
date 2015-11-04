using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinectTFG2016.Clases;

namespace KinectTFG2016.RecursosTerapeuta
{
    /// <summary>
    /// Formulario para asignar los relaciones libres a los terapeutas.
    /// </summary>
    public partial class AdquerirPacientes : Form
    {
        string nombreTerapeuta;
        public AdquerirPacientes(string nombre)
        {
            nombreTerapeuta = nombre;
            InitializeComponent();
        }
        /// <summary>
        /// Asignar y guardar datos.
        /// </summary>
        /// <param name="sender"></param> Boton asignar.
        /// <param name="e"></param> Eventos del boton.
        private void pacientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinectBDDataSet);

        }

        /// <summary>
        /// Metodo que carga datos al cargar el formulario.
        /// </summary>
        /// <param name="sender"></param> Cargar datos al formulario.
        /// <param name="e"></param> Eventos de carga.
        private void AsignarPacientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'kinectBDDataSet.Pacientes' Puede moverla o quitarla según sea necesario.
            this.pacientesTableAdapter.Fill(this.kinectBDDataSet.Pacientes);

        }

        /// <summary>
        /// Carga datos en la tabla.
        /// </summary>
        /// <param name="sender"></param> Carga datos en tabla.
        /// <param name="e"></param> eventos de cargar.
        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacientesTableAdapter.FillBy(this.kinectBDDataSet.Pacientes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        /// <summary>
        /// Metodo que guarda los cambios realizados en la asignacion
        /// </summary>
        /// <param name="sender"></param> Boton Asignar
        /// <param name="e"></param> Eventos de asignar
        private void buttonAsignar_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.pacientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinectBDDataSet);
            DateTime hoy = DateTime.Today;
            string fechaInicio = hoy.ToString("yyyy/MM/dd");
            if (Relacion.registrarRelacion(textBoxIDPaciente.Text,nombreTerapeuta, textBoxNombrePaciente.Text, textBoxApellidosPaciente.Text, fechaInicio) > 0)
            {
                MessageBox.Show("Atendido.");
            }
            else
            {
                MessageBox.Show("No atendido");
            }
        }

        /// <summary>
        /// Filtrar y cargar datos de relaciones libres.
        /// </summary>
        /// <param name="sender"></param> Cargar datos de relaciones libres.
        /// <param name="e"></param> Eventos de carga.
        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.pacientesTableAdapter.FillBy(this.kinectBDDataSet.Pacientes);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
