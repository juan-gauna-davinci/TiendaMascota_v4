using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using TiendaMascota_v2.Modelo;

namespace TiendaMascota_v2.Repositorio
{
    public class EmpleadoRepositorio
    {

        public static List<Empleado> ListaEmpleados { get; set; }
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
            ListaEmpleados = new List<Empleado>();

            if (!File.Exists("Empleados.txt"))
            {
                StreamWriter archivoNuevo = new StreamWriter("Empleados.txt");
                archivoNuevo.Close();
            }
            else
            {
                StreamReader archivo = new StreamReader("Empleados.txt");

                while (!archivo.EndOfStream)
                {
                    string datosEmpleado = archivo.ReadLine();

                    string[] datosDivididos = datosEmpleado.Split(';');

                    Empleado empleado = new Empleado(datosDivididos);

                    ListaEmpleados.Add(empleado);
                }

                archivo.Close();
            }

        }

        public static void AgregarEmpleado(Empleado empleado)
        {
            ListaEmpleados.Add(empleado);
            GuardarEnMemoria(empleado);
        }

        public static void ActualizarEmpleado(int id, Empleado empleado)
        {
            int indice = ListaEmpleados.FindIndex(a => a.Id == id);

            if (indice != -1)
            {
                ListaEmpleados[indice] = empleado;
            }

            GuardarEnMemoriaLista();
        }

        public static void EliminarEmpleado(int id)
        {
            Empleado empleado = ListaEmpleados.FirstOrDefault(a => a.Id == id);
            empleado.Activo = false;

            ActualizarEmpleado(empleado.Id, empleado);
        }

        public static void GuardarEnMemoria(Empleado empleado)
        {
            StreamWriter archivo = new StreamWriter("Empleados.txt", true);
            archivo.WriteLine(empleado.Id + ";" + empleado.Nombre + ";" + Empleado.EsActivo(empleado.Activo));
            archivo.Close();
        }

        private static void GuardarEnMemoriaLista()
        {
            StreamWriter archivo = new StreamWriter("Empleados.txt");
            foreach (Empleado empleado in ListaEmpleados)
            {
                archivo.WriteLine(empleado.Id + ";" + empleado.Nombre + ";" + Empleado.EsActivo(empleado.Activo));
            }
            archivo.Close();
        }

        public static List<Empleado> ObtenerEmpleados()
        {
            return ListaEmpleados;
        }

        private static int ObtenerUltimoId()
        {
            int ultimoId = 0;

            if (ListaEmpleados.Count > 0)
            {
                ultimoId = ListaEmpleados[ListaEmpleados.Count - 1].Id;

                ultimoId = ultimoId + 1;

                return ultimoId;
            }
            else
            {
                return 1;
            }
        }

        public static Empleado ObtenerEmpleadoPorId(int id)
        {
            Empleado empleado = ListaEmpleados.FirstOrDefault(a => a.Id == id);

            return empleado;
        }

        public static Empleado ObtenerEmpleadoPorNombre(string nombre)
        {
            Empleado empleado = ListaEmpleados.FirstOrDefault(a => a.Nombre == nombre);

            return empleado;
        }

    }
}
