using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using upc.order.business;
using upc.order.entities;

namespace upc.order.presentation
{
    public partial class Form1 : Form
    {
        double totalneto = 0;
        string[] productos =
        {
            "Teclado" ,"Impresora","Monitor","Mouse","Parlantes"
        };

        Venta objVenta = new Venta();
        IVenta objVentaBusiness = new VentaB();


        public Form1()
        {
            InitializeComponent();
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            //Obtenemos los datos del formulario para pasarlo a los atributos del objeto
            objVenta.Producto = cboproducto.Text;
            objVenta.Cantidad = int.Parse(txtcantidad.Text);

            //Con los datos obtenidos realizamos los calculos
            double precio = objVentaBusiness.AsignarPrecio(objVenta);
            double subtotal = objVentaBusiness.CalcularSubtotal(objVenta);
            double descuento = objVentaBusiness.CalcularDescuento(objVenta);
            double neto = objVentaBusiness.CalcularNeto(objVenta);

            //Visualizar los datos en el listview
            ListViewItem nuevalista = new ListViewItem(objVenta.Producto);
            nuevalista.SubItems.Add(objVenta.Cantidad.ToString());
            nuevalista.SubItems.Add(precio.ToString());
            nuevalista.SubItems.Add(subtotal.ToString());
            nuevalista.SubItems.Add(descuento.ToString());
            nuevalista.SubItems.Add(neto.ToString());

            lstventa.Items.Add(nuevalista);
                      
            totalneto += neto;         
         
            lblprecio.Text = precio.ToString();
            lbltotalneto.Text = totalneto.ToString();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarProductos();
        }

        //Methods

        void llenarProductos()
        {
            foreach(string p in productos)
            {
                cboproducto.Items.Add(p);
            }
        }
    }
}
