using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using upc.order.entities;

namespace upc.order.business
{
    public interface IVenta
    {
        double AsignarPrecio(Venta v);
        double CalcularSubtotal(Venta v);
        double CalcularDescuento(Venta v);
        double CalcularNeto(Venta v);
    }
}
