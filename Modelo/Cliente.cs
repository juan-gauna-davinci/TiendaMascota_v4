using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaMascota_v2.Modelo
{
    public class Cliente
    {

        public int Id;
        public string Nombre;
        public string Apellido;
        public string Email;
        public string Domicilio;
        public bool Activo;




        public Cliente()
        {

        }

        public Cliente(string[] lineaCliente)
        {
            this.Id = int.Parse(lineaCliente[0]);
            this.Nombre = lineaCliente[1];
            this.Apellido = lineaCliente[2];
            this.Email = lineaCliente[3];
            this.Domicilio = lineaCliente[4];
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

