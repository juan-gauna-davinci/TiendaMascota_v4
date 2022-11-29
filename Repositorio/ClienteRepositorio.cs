using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TiendaMascota_v2.Modelo;

namespace TiendaMascota_v2.Repositorio
{
    public class ClienteRepositorio
    {

        public static List<Cliente> ListaClientes { get; set; }
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
            ListaClientes = new List<Cliente>();

            if (!File.Exists("Clientes.txt"))
            {
                StreamWriter archivoNuevo = new StreamWriter("Clientes.txt");
                archivoNuevo.Close();
            }
            else
            {
                StreamReader archivo = new StreamReader("Clientes.txt");

                while (!archivo.EndOfStream)
                {
                    string datosCliente = archivo.ReadLine();

                    string[] datosDivididos = datosCliente.Split(';');

                    Cliente cliente = new Cliente(datosDivididos);

                    ListaClientes.Add(cliente);
                }

                archivo.Close();
            }

        }

        public static void AgregarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
            GuardarEnMemoria(cliente);
        }

        public static void ActualizarCliente(int id, Cliente cliente)
        {
            int indice = ListaClientes.FindIndex(a => a.Id == id);

            if (indice != -1)
            {
                ListaClientes[indice] = cliente;
            }

            GuardarEnMemoriaLista();
        }

        public static void EliminarCliente(int id)
        {
            Cliente cliente = ListaClientes.FirstOrDefault(a => a.Id == id);
            cliente.Activo = false;

            ActualizarCliente(cliente.Id, cliente);
        }

        public static void GuardarEnMemoria(Cliente cliente)
        {
            StreamWriter archivo = new StreamWriter("Clientes.txt", true);
            archivo.WriteLine(cliente.Id + ";" + cliente.Nombre + ";" + Cliente.EsActivo(cliente.Activo));
            archivo.Close();
        }

        private static void GuardarEnMemoriaLista()
        {
            StreamWriter archivo = new StreamWriter("Clientes.txt");
            foreach (Cliente cliente in ListaClientes)
            {
                archivo.WriteLine(cliente.Id + ";" + cliente.Nombre + ";" + Empleado.EsActivo(cliente.Activo));
            }
            archivo.Close();
        }

        public static List<Cliente> ObtenerClientes()
        {
            return ListaClientes;
        }

        private static int ObtenerUltimoId()
        {
            int ultimoId = 0;

            if (ListaClientes.Count > 0)
            {
                ultimoId = ListaClientes[ListaClientes.Count - 1].Id;

                ultimoId = ultimoId + 1;

                return ultimoId;
            }
            else
            {
                return 1;
            }
        }

        public static Cliente ObtenerClientePorId(int id)
        {
            Cliente cliente = ListaClientes.FirstOrDefault(a => a.Id == id);

            return cliente;
        }

        public static Cliente ObtenerClientePorNombre(string nombre)
        {
            Cliente cliente = ListaClientes.FirstOrDefault(a => a.Nombre == nombre);

            return cliente;
        }

    }
}