using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace KinectTFG2016
{
    class BDComun
    {
        public static SqlConnection ObtnerConexion()
        {
            SqlConnection Conn = new SqlConnection(@"Data source=DAVID-PORTATIL\DAVID; Initial Catalog = KinectBD; Integrated Security=True");
            Conn.Open();

            return Conn;
        }
    }
}
