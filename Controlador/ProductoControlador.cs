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
    public class ProductoControlador
    {
        public static void IniciarRepositorio()
        {
            ProductoRepositorio.IniciarRepositorio();
        }

        public static void AgregarProducto(Producto producto)
        {
            // Validaciones: ValidarProducto();

            ProductoRepositorio.AgregarProducto(producto);
        }

        public static void ActualizarProducto(int id, Producto producto)
        {
            ProductoRepositorio.ActualizarProducto(id, producto);
        }

        public static void EliminarProducto(int id)
        {
            ProductoRepositorio.EliminarProducto(id);
        }

        public static List<Producto> ObtenerProductos()
        {
            return ProductoRepositorio.ObtenerProductos();
        }
        public static List<Producto> ObtenerProductosPaginado(List<Producto> paginado)
        {
            return ProductoRepositorio.ObtenerProductos();
        }
        
        public static int ObtenerUltimoId()
        {
            return ProductoRepositorio.UltimoId;
        }

        public static Producto ObtenerProductoPorId(int id)
        {
            return ProductoRepositorio.ObtenerProductoPorId(id);
        }

        public static Producto ObtenerProductoPorNombre(string nombre)
        {
            return ProductoRepositorio.ObtenerProductoPorNombre(nombre);
        }
    }
}
