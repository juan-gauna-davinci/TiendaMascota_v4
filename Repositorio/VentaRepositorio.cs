using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMascota_v2.Modelo;

namespace TiendaMascota_v2.Repositorio
{
    public class VentaRepositorio
    {
        public static List<Venta> ListaVentas { get; set; }
        public static int UltimoId
        {
            get
            {
                return ObtenerUltimoId();
            }
            set
            {
                UltimoId = value;
            }
        }

        public static void IniciarRepositorio()
        {
            ListaVentas = new List<Venta>();

            if (!File.Exists("Ventas.txt"))
            {
                StreamWriter archivoNuevo = new StreamWriter("Ventas.txt");
                archivoNuevo.Close();
            }
            else
            {
                StreamReader archivo = new StreamReader("Ventas.txt");

                while (!archivo.EndOfStream)
                {
                    string datosVenta = archivo.ReadLine();

                    if (!datosVenta.Equals(""))
                    {
                        string[] datosDivididos = datosVenta.Split(';');

                        Venta usuario = new Venta(datosDivididos);

                        ListaVentas.Add(usuario);
                    }
                }

                archivo.Close();
            }

        }

        public static void AgregarVenta(Venta venta)
        {
            ListaVentas.Add(venta);
            GuardarEnMemoria(venta);
        }

        public static void GuardarEnMemoria(Venta venta)
        {
            StreamWriter archivo = new StreamWriter("Ventas.txt", true);
            archivo.WriteLine(venta.Id + ";" + venta.IdProducto + ";" + venta.Cantidad + ";" + venta.PrecioFinal);
            archivo.Close();
        }

        private static void GuardarEnMemoriaLista()
        {
            StreamWriter archivo = new StreamWriter("Usuarios.txt");
            foreach (Venta venta in ListaVentas)
            {
                archivo.WriteLine(venta.Id + ";" + venta.IdProducto + ";" + venta.Cantidad + ";" + venta.PrecioFinal);
            }
            archivo.Close();
        }

        public static List<Venta> ObtenerVentas()
        {
            return ListaVentas;
        }

        private static int ObtenerUltimoId()
        {
            int ultimoId = 0;

            if (ListaVentas.Count > 0)
            {
                ultimoId = ListaVentas[ListaVentas.Count - 1].Id;

                ultimoId = ultimoId + 1;

                return ultimoId;
            }
            else
            {
                return 1;
            }
        }

    }
}
