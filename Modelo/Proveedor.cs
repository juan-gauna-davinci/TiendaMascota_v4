using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMascota_v2.Modelo
{
    public class Proveedor
    {

        public int Id;
        public string Nombre;
        public bool Activo;


        public Proveedor()
        {

        }

        public Proveedor(string[] lineaProveedor)
        {
            this.Id = int.Parse(lineaProveedor[0]);
            this.Nombre = lineaProveedor[1];
            this.Activo = EsActivo(lineaProveedor[2]);

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
