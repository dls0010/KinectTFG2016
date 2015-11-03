using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KinectTFG2016.Clases
{
    /// <summary>
    /// Clase Paciente que registrar en la base de datos.
    /// </summary>
    class Paciente
    {
        /// <summary>
        /// Metodo que controla el registro un nuevo paciente en la base de datos.
        /// </summary>
        /// <param name="pNombre"></param> Nombre del paciente.
        /// <param name="pApellidos"></param> Apellidos del paciente.   
        /// <param name="pNIF"></param> NIF del paciente.
        /// <param name="pNacimiento"></param> Nacimiento del paciente.
        /// <param name="pEstado"></param> Estado del paciente.
        /// <returns>
        /// 0: Ha ocurrido un fallo. No se ha llevado a cabo la inserción.
        /// != 0 Proceso realizado correctamente.
        /// </returns>
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
