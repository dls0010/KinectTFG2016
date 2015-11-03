using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KinectTFG2016.Clases
{
    /// <summary>
    /// Clase Usuario que comprueba el acceso tanto con nombre de usuario como con la contraseña.
    /// </summary>
    class Usuario
    {
        /// <summary>
        /// Metodo que controla el crear un nuevo usuario en la base de datos.
        /// </summary>
        /// <param name="pUsuario"></param> Nombre de Usuario.
        /// <param name="pContraseña"></param> Contraseña del Usuario.
        /// <param name="pTipoUsuario"></param> Tipo de Usuario.
        /// <returns>
        /// 0: Ha ocurrido un fallo. No se ha llevado a cabo la inserción.
        /// != 0 Proceso realizado correctamente.
        /// </returns>
        public static int CrearUsuarios(string pUsuario, string pContraseña, string pTipoUsuario)
        {
            int resultado = 0;

            if (Existe(pUsuario) == false && pTipoUsuario.Length != 0)
            {
                SqlConnection conn = BDComun.ObtnerConexion();
                SqlCommand comando = new SqlCommand(string.Format("Insert Into Usuarios (Usuario,Contraseña,TipoUsuario) values ('{0}',PwdEncrypt('{1}'),'{2}')", pUsuario, pContraseña, pTipoUsuario), conn);

                resultado = comando.ExecuteNonQuery();
                conn.Close();

            }
            return resultado;
        }

        /// <summary>
        /// Metodo que controla la autenficacion en el login del usuario.
        /// </summary>
        /// <param name="pUsuario"></param> Nombre del Usuario.
        /// <param name="pContraseña"></param> Contraseña del usuario.
        /// <returns>
        /// -1: No hay usuario en esa base de datos.
        /// != -1: Usuario encontrado. Autentificacion correcta.
        /// </returns>
        public static int Autentificar(String pUsuario, String pContraseña)
        {
            int resultado = -1;
            SqlConnection conn = BDComun.ObtnerConexion();
            SqlCommand comando = new SqlCommand(string.Format("Select * from Usuarios where Usuario = '{0}' and PwdCompare('{1}',Contraseña) = 1 ", pUsuario, pContraseña), conn);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                resultado = 50;
            }
            conn.Close();
            return resultado;
        }

        /// <summary>
        /// Metodo adicional usado para comprobacion de la existencia de ese usuario en la base de datos.
        /// </summary>
        /// <param name="usuario"></param>
        /// <returns>True: Existe un usuario con ese nombre. 
        /// False: No existe un usuario con ese nombre.
        /// </returns>
        public static bool Existe(string usuario)
        {
            using (SqlConnection conexion = BDComun.ObtnerConexion())
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario=@Usuario";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("Usuario", usuario);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                    return false;
                else
                    return true;
            }
        }
    }
}
