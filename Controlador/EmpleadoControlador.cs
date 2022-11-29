using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMascota_v2.Modelo;
using TiendaMascota_v2.Repositorio;

namespace TiendaMascota_v2.Controlador
{
    public class EmpleadoControlador
    {

        public static void IniciarRepositorio()
        {
            EmpleadoRepositorio.IniciarRepositorio();
        }

        public static void AgregarEmpleado(Empleado empleado)
        {

            EmpleadoRepositorio.AgregarEmpleado(empleado);
        }

        public static void ActualizarEmpleado(int id, Empleado empleado)
        {
            EmpleadoRepositorio.ActualizarEmpleado(id, empleado);
        }

        public static void EliminarEmpleado(int id)
        {
            EmpleadoRepositorio.EliminarEmpleado(id);
        }

        public static List<Empleado> ObtenerEmpleados()
        {
            return EmpleadoRepositorio.ObtenerEmpleados();
        }
        public static int ObtenerUltimoId()
        {
            return EmpleadoRepositorio.UltimoId;
        }

        public static Empleado ObtenerEmpleadoPorId(int id)
        {
            return EmpleadoRepositorio.ObtenerEmpleadoPorId(id);
        }

        public static Empleado ObtenerEmpleadoPorNombre(string nombre)
        {
            return EmpleadoRepositorio.ObtenerEmpleadoPorNombre(nombre);
        }

        public static bool HuboModificaciones(Empleado empleadoModificado)
        {
            bool huboModificaciones = false;

            Empleado empleadoBase = ObtenerEmpleadoPorId(empleadoModificado.Id);

            if (!empleadoModificado.Nombre.Equals(empleadoBase.Nombre) ||
                !empleadoModificado.Activo.Equals(empleadoBase.Activo))
            {
                huboModificaciones = true;
            }

            return huboModificaciones;
        }
    }
}