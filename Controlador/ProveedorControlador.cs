using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMascota_v2.Modelo;
using TiendaMascota_v2.Repositorio;

namespace TiendaMascota_v2.Controlador
{
    public class ProveedorControlador
    {

        public static void IniciarRepositorio()
        {
            ProveedorRepositorio.IniciarRepositorio();
        }

        public static void AgregarProveedor(Proveedor proveedor)
        {

            ProveedorRepositorio.AgregarProveedor(proveedor);
        }

        public static void ActualizarProveedor(int id, Proveedor proveedor)
        {
            ProveedorRepositorio.ActualizarProveedor(id, proveedor);
        }

        public static void EliminarProveedor(int id)
        {
            ProveedorRepositorio.EliminarProveedor(id);
        }

        public static List<Proveedor> ObtenerProveedores()
        {
            return ProveedorRepositorio.ObtenerProveedores();
        }
        public static int ObtenerUltimoId()
        {
            return ProveedorRepositorio.UltimoId;
        }

        public static Proveedor ObtenerProveedorPorId(int id)
        {
            return ProveedorRepositorio.ObtenerProveedorPorId(id);
        }

        public static Proveedor ObtenerProveedorPorNombre(string nombre)
        {
            return ProveedorRepositorio.ObtenerProveedorPorNombre(nombre);
        }

        public static bool HuboModificaciones(Proveedor proveedorModificado)
        {
            bool huboModificaciones = false;

            Proveedor proveedorBase = ObtenerProveedorPorId(proveedorModificado.Id);

            if (!proveedorModificado.Nombre.Equals(proveedorBase.Nombre) ||
                !proveedorModificado.Activo.Equals(proveedorBase.Activo))
            {
                huboModificaciones = true;
            }

            return huboModificaciones;
        }

    }
}
