using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMascota_v2.Modelo;
using TiendaMascota_v2.Repositorio;

namespace TiendaMascota_v2.Controlador
{
    public class VentaControlador
    {
        public static void IniciarRepositorio()
        {
            VentaRepositorio.IniciarRepositorio();
        }

        public static void AgregarVenta(Venta venta)
        {
            VentaRepositorio.AgregarVenta(venta);

            ProductoRepositorio.ActualizarStock(venta.IdProducto, venta.Cantidad);
        }

        public static List<Venta> ObtenerVentas()
        {
            return VentaRepositorio.ObtenerVentas();
        }
        public static int ObtenerUltimoId()
        {
            return VentaRepositorio.UltimoId;
        }

    }
}
