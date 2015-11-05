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
    public partial class InicioPaciente : Form
    {
        string nombreUsuario;
        public InicioPaciente(string usuario)
        {
            nombreUsuario = usuario;
            InitializeComponent();
        }

        private void InicioPaciente_Load(object sender, EventArgs e)
        {
            textBoxNombreUsuario.Text = nombreUsuario;
        }
    }
}
