using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upc.order.entities;

namespace upc.order.repository
{
    public interface IVentaR
    {
        bool Create(Venta v);
    }
}
