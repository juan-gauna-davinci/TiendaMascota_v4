using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMascota_v2.Modelo;

namespace TiendaMascota_v2.Controlador
{
    public class ProductoRepositorio
    {
        public static List<Producto> ListaProductos { get; set; }
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
            ListaProductos = new List<Producto>();

            if (!File.Exists("Productos.txt"))
            {

                StreamWriter archivoNuevo = new StreamWriter("Productos.txt");
                archivoNuevo.Close();

            }
            else
            {

                StreamReader archivo = new StreamReader("Productos.txt");

                while (!archivo.EndOfStream)
                {
                    string datosProducto = archivo.ReadLine();

                    string[] datosDivididos = datosProducto.Split(';');

                    Producto producto = new Producto(datosDivididos);

                    ListaProductos.Add(producto);
                }

                archivo.Close();

            }
        }

        public static void AgregarProducto(Producto producto)
        {
            ListaProductos.Add(producto);
            GuardarEnMemoria(producto);
        }

        public static void ActualizarProducto(int id, Producto producto)
        {
            int indice = ListaProductos.FindIndex(p => p.Id == id);

            if(indice != -1)
            {
                ListaProductos[indice] = producto;
            }

            GuardarEnMemoriaLista();
        }

        public static void EliminarProducto(int id)
        {
            Producto producto = ListaProductos.FirstOrDefault(p => p.Id == id);
            producto.Activo = false;

            ActualizarProducto(producto.Id, producto);
        }
        public static void GuardarEnMemoria(Producto prod)
        {
            StreamWriter archivo = new StreamWriter("Productos.txt", true);
            archivo.WriteLine(prod.Id + ";" + prod.Nombre + ";" + prod.Precio + ";" + prod.Stock + ";" + prod.IdCategoria + ";" + prod.IdAnimal + ";" + prod.RutaImagen + ";" + Producto.EsActivo(prod.Activo));
            archivo.Close();
        }

        private static void GuardarEnMemoriaLista()
        {
            StreamWriter archivo = new StreamWriter("Productos.txt");
            foreach (Producto prod in ListaProductos)
            {
                archivo.WriteLine(prod.Id + ";" + prod.Nombre + ";" + prod.Precio + ";" + prod.Stock + ";" + prod.IdCategoria + ";" + prod.IdAnimal + ";" + prod.RutaImagen + ";" + Producto.EsActivo(prod.Activo));
            }
            archivo.Close();
        }

        public static List<Producto> ObtenerProductos()
        {
            return ListaProductos;
        }

        public static Producto ObtenerProductoPorId(int id)
        {
            Producto producto = ListaProductos.FirstOrDefault(a => a.Id == id);

            return producto;
        }

        public static Producto ObtenerProductoPorNombre(string nombre)
        {
            Producto producto = ListaProductos.FirstOrDefault(a => a.Nombre == nombre);

            return producto;
        }

        private static int ObtenerUltimoId()
        {
            int ultimoId = 0;

            if (ListaProductos.Count > 0)
            {
                ultimoId = ListaProductos[ListaProductos.Count - 1].Id;

                ultimoId = ultimoId + 1;

                return ultimoId;
            }
            else
            {
                return 1;
            }
        }

        public static void ActualizarStock(int idProducto, int cantidad)
        {
            Producto producto = ObtenerProductoPorId(idProducto);

            producto.Stock = producto.Stock - cantidad;

            ActualizarProducto(producto.Id, producto);
        }
    }
}
