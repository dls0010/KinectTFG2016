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
    public partial class EditarTerapeutas : Form
    {
        public EditarTerapeutas()
        {
            InitializeComponent();
        }

        private void terapeutasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.terapeutasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.kinectBDDRecursosAdministrador);

        }

        private void EditarTerapeutas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'kinectBDDRecursosAdministrador.Terapeutas' Puede moverla o quitarla según sea necesario.
            this.terapeutasTableAdapter.Fill(this.kinectBDDRecursosAdministrador.Terapeutas);

        }
    }
}
