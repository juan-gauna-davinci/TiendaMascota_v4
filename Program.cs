using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaMascota_v2.Controlador;
using TiendaMascota_v2.Vista;

namespace TiendaMascota_v2
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ProductoControlador.IniciarRepositorio();
            AnimalControlador.IniciarRepositorio();
            CategoriaControlador.IniciarRepositorio();
            UsuarioControlador.IniciarRepositorio();
            VentaControlador.IniciarRepositorio();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
