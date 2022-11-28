using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMascota_v2.Modelo
{
    public class Empleado
    {

        public int Id;
        public string Nombre;
        public string Apellido;
        public string Email;
        public bool Activo;

        public Empleado()
        {
            
        }

        public Empleado(string[] lineaEmpledo)
        {
            this.Id = int.Parse(lineaEmpledo[0]);
            this.Nombre = lineaEmpledo[1];
            this.Apellido = lineaEmpledo[2];
            this.Email = lineaEmpledo[3];
            this.Activo = EsActivo(lineaEmpledo[4]);
         
        }

        public static bool EsActivo(string esActivo)
        {
            if (esActivo.Equals("SI"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string EsActivo(bool esActivo)
        {
            if (esActivo)
            {
                return "SI";
            }
            else
            {
                return "NO";
            }
        }

    }
}
