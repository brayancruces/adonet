using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace upc.order.entities
{
    public class Venta
    {
        //Propiedades automaticas , como atributos en c++
        public int Id { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }

        //Principio de UNICA RESPONSABILIDAD
        //Principios SOLID
    }
}
