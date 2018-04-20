using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using upc.order.entities;

namespace upc.order.business
{
    public class VentaB : IVenta
    {
        public double AsignarPrecio(Venta v)
        {
            switch (v.Producto)
            {
                case "Mouse": return 20;
                case "Teclado": return 35;
                case "Impresora": return 350;
                case "Monitor": return 550;
                case "Parlantes": return 50;
            }
            return 0;
        }

        public double CalcularDescuento(Venta v)
        {
            double subtotal = CalcularSubtotal(v);
            if (subtotal <= 300)
                return 0.05*subtotal;
            else if (subtotal > 300 && subtotal <= 500)
                return 0.10* subtotal;
            else
                return 0.13* subtotal;
            
        }

        public double CalcularNeto(Venta v)
        {
            return CalcularSubtotal(v) - CalcularDescuento(v);
        }

        public double CalcularSubtotal(Venta v)
        {
            return AsignarPrecio(v) * v.Cantidad;
        }
    }
}
