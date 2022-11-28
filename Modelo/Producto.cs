using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMascota_v2.Modelo
{
    public class Producto
    {
        public int Id;
        public string Nombre;
        public int Precio;
        public int IdCategoria;
        public int IdAnimal;
        public string RutaImagen;
        public int Stock;
        public bool Activo;

        public Producto()
        {

        }
        public Producto(string[] lineaProducto)
        {
            this.Id = int.Parse(lineaProducto[0]);
            this.Nombre = lineaProducto[1];
            this.Precio = int.Parse(lineaProducto[2]);
            this.Stock = int.Parse(lineaProducto[3]);
            this.IdCategoria = int.Parse(lineaProducto[4]);
            this.IdAnimal = int.Parse(lineaProducto[5]);
            this.RutaImagen = lineaProducto[6];
            this.Activo = EsActivo(lineaProducto[7]);
        }

        public static bool EsActivo(string esActivo)
        {
            if(esActivo.Equals("SI"))
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
