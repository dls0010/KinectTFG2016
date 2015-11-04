using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KinectTFG2016.RecursosTerapeuta;

namespace KinectTFG2016
{
    public partial class InicioTerapeuta : Form
    {
        string nombreUsuario;
        public InicioTerapeuta(string usuario)
        {
            nombreUsuario = usuario;
            InitializeComponent();
        }

        private void buttonAdquerir_Click(object sender, EventArgs e)
        {
            AdquerirPacientes adquerirPaciente = new AdquerirPacientes(nombreUsuario);
            adquerirPaciente.Show();
        }

        private void buttonConsultar_Click(object sender, EventArgs e)
        {
            PacientesTerapeuta pacientesTerapeuta = new PacientesTerapeuta(nombreUsuario);
            pacientesTerapeuta.Show();
        }
    }
}
