using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using TiendaMascota_v2.Modelo;

namespace TiendaMascota_v2.Repositorio
{
    public class ProveedorRepositorio
    {

        public static List<Proveedor> ListaProveedores { get; set; }
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
            ListaProveedores = new List<Proveedor>();

            if (!File.Exists("Proveedores.txt"))
            {
                StreamWriter archivoNuevo = new StreamWriter("Proveedores.txt");
                archivoNuevo.Close();
            }
            else
            {
                StreamReader archivo = new StreamReader("Proveedores.txt");

                while (!archivo.EndOfStream)
                {
                    string datosProveedor = archivo.ReadLine();

                    string[] datosDivididos = datosProveedor.Split(';');

                    Proveedor proveedor = new Proveedor(datosDivididos);

                    ListaProveedores.Add(proveedor);
                }

                archivo.Close();
            }

        }

        public static void AgregarProveedor(Proveedor proveedor)
        {
            ListaProveedores.Add(proveedor);
            GuardarEnMemoria(proveedor);
        }

        public static void ActualizarProveedor(int id, Proveedor proveedor)
        {
            int indice = ListaProveedores.FindIndex(a => a.Id == id);

            if (indice != -1)
            {
                ListaProveedores[indice] = proveedor;
            }

            GuardarEnMemoriaLista();
        }

        public static void EliminarProveedor(int id)
        {
            Proveedor proveedor = ListaProveedores.FirstOrDefault(a => a.Id == id);
            proveedor.Activo = false;

            ActualizarProveedor(proveedor.Id, proveedor);
        }

        public static void GuardarEnMemoria(Proveedor proveedor)
        {
            StreamWriter archivo = new StreamWriter("Proveedores.txt", true);
            archivo.WriteLine(proveedor.Id + ";" + proveedor.Nombre + ";" + Proveedor.EsActivo(proveedor.Activo));
            archivo.Close();
        }

        private static void GuardarEnMemoriaLista()
        {
            StreamWriter archivo = new StreamWriter("Proveedores.txt");
            foreach (Proveedor proveedor in ListaProveedores)
            {
                archivo.WriteLine(proveedor.Id + ";" + proveedor.Nombre + ";" + Proveedor.EsActivo(proveedor.Activo));
            }
            archivo.Close();
        }

        public static List<Proveedor> ObtenerProveedores()
        {
            return ListaProveedores;
        }

        private static int ObtenerUltimoId()
        {
            int ultimoId = 0;

            if (ListaProveedores.Count > 0)
            {
                ultimoId = ListaProveedores[ListaProveedores.Count - 1].Id;

                ultimoId = ultimoId + 1;

                return ultimoId;
            }
            else
            {
                return 1;
            }
        }

        public static Proveedor ObtenerProveedorPorId(int id)
        {
            Proveedor proveedor = ListaProveedores.FirstOrDefault(a => a.Id == id);

            return proveedor;
        }

        public static Proveedor ObtenerProveedorPorNombre(string nombre)
        {
            Proveedor proveedor = ListaProveedores.FirstOrDefault(a => a.Nombre == nombre);

            return proveedor;
        }

    }
}
