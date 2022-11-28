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
    public class CategoriaControlador
    {
        public static void IniciarRepositorio()
        {
            CategoriaRepositorio.IniciarRepositorio();
        }

        public static void AgregarCategoria(Categoria categoria)
        {
            // Validaciones: ValidarCategoria();

            CategoriaRepositorio.AgregarCategoria(categoria);
        }

        public static void ActualizarCategoria(int id, Categoria categoria)
        {
            CategoriaRepositorio.ActualizarCategoria(id, categoria);
        }

        public static void EliminarCategoria(int id)
        {
            CategoriaRepositorio.EliminarCategoria(id);
        }

        public static List<Categoria> ObtenerCategorias()
        {
            return CategoriaRepositorio.ObtenerCategorias();
        }
        public static int ObtenerUltimoId()
        {
            return CategoriaRepositorio.UltimoId;
        }

        public static Categoria ObtenerCategoriaPorId(int id)
        {
            return CategoriaRepositorio.ObtenerCategoriaPorId(id);
        }

        public static Categoria ObtenerCategoriaPorNombre(string nombre)
        {
            return CategoriaRepositorio.ObtenerCategoriaPorNombre(nombre);
        }
    }
}
