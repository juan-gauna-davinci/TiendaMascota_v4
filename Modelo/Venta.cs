using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMascota_v2.Modelo
{
    public class Venta
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public int Cantidad { get; set; }
        public double PrecioFinal { get; set; }

        public Venta()
        {

        }
        public Venta(string[] lineaVenta)
        {
            this.Id = int.Parse(lineaVenta[0]);
            this.IdProducto = int.Parse(lineaVenta[1]);
            this.Cantidad = int.Parse(lineaVenta[2]);
            this.PrecioFinal = double.Parse(lineaVenta[3]);
        }
    }
}
