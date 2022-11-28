using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaMascota_v2.Controlador;
using TiendaMascota_v2.Modelo;

namespace TiendaMascota_v2.Vista
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            this.lblError.Visible = false;
        }

        private void txtIniciarSesion_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if(UsuarioControlador.ValidarUsuario(usuario, contrasena))
            {
                Usuario usuarioLogueado = UsuarioControlador.ObtenerUsuarioPorNombreYContra(usuario, contrasena);

                InicioControlador.UsuarioLogueado = usuarioLogueado;

                Inicio2 inicio = new Inicio2();

                inicio.Show();
                this.Hide();
            }
            else
            {
                txtUsuario.Text = "";
                txtContrasena.Text = "";
                this.lblError.Visible = true;
            }
        }

    }
}
