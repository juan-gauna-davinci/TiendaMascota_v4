using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TiendaMascota_v2.Modelo;
using TiendaMascota_v2.Vista.ABMAnimal;
using TiendaMascota_v2.Vista.ABMCategoria;

namespace TiendaMascota_v2.Controlador
{
    public class InicioControlador
    {
        public static Inicio Inicio
        {
            get
            {
                if (_inicio == null)
                {
                    _inicio = new Inicio();
                }
                return _inicio;


            }

        }

        public static Inicio _inicio;

        public static VerAnimales VerAnimales
        {
            get
            {
                if (_verAnimales == null)
                {
                    _verAnimales = new VerAnimales();
                }
                return _verAnimales;

            }

        }

        public static VerAnimales _verAnimales;

        public static VerCategorias VerCategorias
        {
            get
            {
                if (_verCategorias == null)
                {
                    _verCategorias = new VerCategorias();
                }
                return _verCategorias;


            }

        }

        public static VerCategorias _verCategorias;

        public static Usuario _usuarioLogueado;

        public static Usuario UsuarioLogueado
        {
            get
            {
                return _usuarioLogueado;
            }
            set
            {
                _usuarioLogueado = value;
            }

        }

    }
}
