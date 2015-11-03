using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KinectTFG2016.Clases
{
    /// <summary>
    /// Clase Terapeuta que registrar en la base de datos.
    /// </summary>
    class Terapeuta
    {

        public static int registrarTerapeuta(string pNombre, string pApellidos, string pNIF, string pNacimiento)
        {
            int resultado = 0;

            SqlConnection conn = BDComun.ObtnerConexion();
            SqlCommand comando = new SqlCommand(string.Format("Insert Into Terapeutas (nombreTerapeuta,apellidosTerapeuta,nifTerapeuta,nacimientoTerapeuta) values ('{0}','{1}','{2}','{3}')", pNombre, pApellidos, pNIF, pNacimiento), conn);

            resultado = comando.ExecuteNonQuery();
            conn.Close();

            return resultado;
        }
    }
}
