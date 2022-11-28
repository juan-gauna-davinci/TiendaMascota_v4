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
using TiendaMascota_v2.Vista.ABMCategoria;

namespace TiendaMascota_v2.Vista.ABMUsuario
{
    public partial class AgregarUsuario : Form
    {
        public AgregarUsuario()
        {
            InitializeComponent();
        }
        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            AsignarIdConsecutivo();
            CargarCombos();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Regresar();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuarioNuevo = new Usuario()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Email = txtEmail.Text,
                Domicilio = txtDomicilio.Text,
                UsuarioLogin = txtUsuario_login.Text,
                Contrasena = txtContraseña.Text,
                Activo = Usuario.EsActivo(comboActivo.Text),
                Admin = Usuario.EsAdministrador(comboEsAdmin.Text)
            };

            UsuarioControlador.AgregarUsuarios(usuarioNuevo);

            Regresar();
        }

        private void Regresar()
        {
            Inicio2 inicio2 = new Inicio2();
            inicio2.Show();

            this.Hide();
        }

        private void AsignarIdConsecutivo()
        {
            int id = UsuarioControlador.ObtenerUltimoId(); // to do: probar

            this.txtId.Text = id.ToString();
        }

        private void CargarCombos()
        {
            CargarComboActivo();
            CargarComboAdmin();
        }
        private void CargarComboActivo()
        {
            this.comboActivo.Items.Add("SI");
            this.comboActivo.Items.Add("NO");
        }

        private void CargarComboAdmin()
        {
            this.comboEsAdmin.Items.Add("SI");
            this.comboEsAdmin.Items.Add("NO");
        }

    }
}
