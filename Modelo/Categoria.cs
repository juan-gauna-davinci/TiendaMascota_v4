using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMascota_v2.Modelo
{
    public class Categoria
    {
        public int Id;
        public string Nombre;
        public bool Activo;

        public Categoria()
        {

        }

        public Categoria(string[] lineaCategoria)
        {
            this.Id = int.Parse(lineaCategoria[0]);
            this.Nombre = lineaCategoria[1];
            this.Activo = EsActivo(lineaCategoria[2]);
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
