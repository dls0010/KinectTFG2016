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
    /// Formulario para visualizar que relaciones tiene asignado un Terapeuta.
    /// </summary>
    public partial class PacientesTerapeuta : Form
    {
        string nombreTerapeuta;
        DataTable tablaPacientes;
        PacientesDatos relaciones;
        public PacientesTerapeuta(string nombre)
        {
            nombreTerapeuta = nombre;
            InitializeComponent();
        }

        /// <summary>
        /// Metodo que carga todo al cargar el formulario.
        /// </summary>
        /// <param name="sender"></param> Propio formulario.
        /// <param name="e"></param> Eventos del formulario.
        private void PacientesTerapeuta_Load(object sender, EventArgs e)
        {
            textBoxNombreTerapeuta.Text = nombreTerapeuta;
            tablaPacientes = Relacion.getRelaciones();
            relaciones = new PacientesDatos();
            relaciones.Tables.Add(tablaPacientes);
            dataGridView1.DataSource = relaciones.Tables[0];
        }

        /// <summary>
        /// Metodo que permite filtrar la tabla con el nombre del terapeuta para obtener los pacientes a su cargo.
        /// </summary>
        /// <param name="sender"></param> Nombre del Terapeuta.
        /// <param name="e"></param> Eventos del nombre.
        private void textBoxNombreTerapeuta_TextChanged(object sender, EventArgs e)
        {
            relaciones.Tables[0].DefaultView.RowFilter = (string.Format("nombreTerapeuta like '{0}'",textBoxNombreTerapeuta.Text));
            dataGridView1.DataSource = relaciones.Tables[0].DefaultView;
        }
    }
}
