using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KinectTFG2016
{
    class Paciente
    {
        public static int RegistrarPaciente(string pNombre, string pApellidos, string pNIF, string pNacimiento, string pEstado)
        {
            int resultado = 0;

            SqlConnection conn = BDComun.ObtnerConexion();
            SqlCommand comando = new SqlCommand(string.Format("Insert Into Pacientes (nombrePaciente,apellidosPaciente,nifPaciente,nacimientoPaciente,estadoPaciente) values ('{0}','{1}','{2}','{3}','{4}')", pNombre, pApellidos, pNIF,pNacimiento,pEstado), conn);

            resultado = comando.ExecuteNonQuery();
            conn.Close();

            return resultado;
        }
    }
}
