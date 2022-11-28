using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMascota_v2.Modelo;
using TiendaMascota_v2.Repositorio;

namespace TiendaMascota_v2.Controlador
{
    public class ClienteControlador
    {

        public static void IniciarRepositorio()
        {
            ClienteRepositorio.IniciarRepositorio();
        }

        public static void AgregarCliente(Cliente cliente)
        {

            ClienteRepositorio.AgregarCliente(cliente);
        }

        public static void ActualizarCliente(int id, Cliente cliente)
        {
            ClienteRepositorio.ActualizarCliente(id, cliente);
        }

        public static void EliminarCliente(int id)
        {
            ClienteRepositorio.EliminarCliente(id);
        }

        public static List<Cliente> ObtenerClientes()
        {
            return ClienteRepositorio.ObtenerClientes();
        }
        public static int ObtenerUltimoId()
        {
            return ClienteRepositorio.UltimoId;
        }

        public static Cliente ObtenerClientePorId(int id)
        {
            return ClienteRepositorio.ObtenerClientePorId(id);
        }

        public static Cliente ObtenerClientePorNombre(string nombre)
        {
            return ClienteRepositorio.ObtenerClientePorNombre(nombre);
        }

        public static bool HuboModificaciones(Cliente clienteModificado)
        {
            bool huboModificaciones = false;

            Cliente clienteBase = ObtenerClientePorId(clienteModificado.Id);

            if (!clienteModificado.Nombre.Equals(clienteBase.Nombre) ||
                !clienteModificado.Activo.Equals(clienteBase.Activo))
            {
                huboModificaciones = true;
            }

            return huboModificaciones;
        }

    }
}
