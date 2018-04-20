using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upc.order.entities;

namespace upc.order.repository
{
    public class VentaR : IVentaR
    {
        SqlConnection SqlCon;
        
        //Static ==> Patron Singleton
        Conexion cn = new Conexion();

        public bool Create(Venta v)
        {
            SqlCon = cn.getConexion();
            //SQL 
            SqlCommand cmd = new SqlCommand("sp_addventa", SqlCon);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@producto", v.Producto);
            cmd.Parameters.AddWithValue("@cantidad", v.Cantidad);

            SqlCon.Open();

            int i=cmd.ExecuteNonQuery();

            SqlCon.Close();

            if (i >=-1)
                return true;
            else
                return false;
        }
    }
}
