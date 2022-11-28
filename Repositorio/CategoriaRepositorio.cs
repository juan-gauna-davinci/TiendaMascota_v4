using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMascota_v2.Modelo;

namespace TiendaMascota_v2.Repositorio
{
    public class CategoriaRepositorio
    {
        public static List<Categoria> ListaCategorias { get; set; }
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
            ListaCategorias = new List<Categoria>();

            if(!File.Exists("Categorias.txt"))
            {
                StreamWriter archivoNuevo = new StreamWriter("Categorias.txt");
                archivoNuevo.Close();
            }
            else
            {
                StreamReader archivo = new StreamReader("Categorias.txt");

                while(!archivo.EndOfStream)
                {
                    string datosCategoria = archivo.ReadLine();

                    if(!datosCategoria.Equals(""))
                    {
                        string[] datosDivididos = datosCategoria.Split(';');

                        Categoria categoria = new Categoria(datosDivididos);

                        ListaCategorias.Add(categoria);
                        //
                    }
                }

                archivo.Close();
            }
            
        }

        public static void AgregarCategoria(Categoria categoria)
        {
            ListaCategorias.Add(categoria);
            GuardarEnMemoria(categoria);
        }

        public static void ActualizarCategoria(int id, Categoria categoria)
        {
            int indice = ListaCategorias.FindIndex(a => a.Id == id);

            if(indice != -1)
            {
                ListaCategorias[indice] = categoria;
            }

            GuardarEnMemoriaLista();
        }

        public static void EliminarCategoria(int id)
        {
            Categoria Categoria = ListaCategorias.FirstOrDefault(a => a.Id == id);
            Categoria.Activo = false;

            ActualizarCategoria(Categoria.Id, Categoria);
        }

        public static void GuardarEnMemoria(Categoria categoria)
        {
            StreamWriter archivo = new StreamWriter("Categorias.txt", true);
            archivo.WriteLine(categoria.Id + ";" + categoria.Nombre + ";"  + Categoria.EsActivo(categoria.Activo));
            archivo.Close();
        }

        private static void GuardarEnMemoriaLista()
        {
            StreamWriter archivo = new StreamWriter("Categorias.txt");
            foreach(Categoria categoria in ListaCategorias)
            {
                archivo.WriteLine(categoria.Id + ";" + categoria.Nombre + ";" + Categoria.EsActivo(categoria.Activo));
            }
            archivo.Close();
        }

        public static List<Categoria> ObtenerCategorias()
        {
            return ListaCategorias;
        }

        private static int ObtenerUltimoId()
        {
            int ultimoId = 0;

            if(ListaCategorias.Count > 0)
            {
                ultimoId = ListaCategorias[ListaCategorias.Count - 1].Id;

                ultimoId = ultimoId + 1;

                return ultimoId;
            }
            else
            {
                return 1;
            }
        }

        public static Categoria ObtenerCategoriaPorId(int id)
        {
            Categoria categoria = ListaCategorias.FirstOrDefault(a => a.Id == id);

            return categoria;
        }

        public static Categoria ObtenerCategoriaPorNombre(string nombre)
        {
            Categoria categoria = ListaCategorias.FirstOrDefault(a => a.Nombre == nombre);

            return categoria;
        }
    }
}
