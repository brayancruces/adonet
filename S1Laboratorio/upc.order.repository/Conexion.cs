using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Data.SqlClient;
using System.Configuration;

namespace upc.order.repository
{
    public class Conexion
    {

        public SqlConnection getConexion()
        {
            SqlConnection cn=new SqlConnection(ConfigurationManager
                                               .ConnectionStrings["cn"]
                                               .ConnectionString);
            return cn;
        }
    }
}
