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
    public partial class EditarUsuario : Form
    {

        public EditarUsuario()
        {
            InitializeComponent();
        }

        public EditarUsuario(Usuario usuario)
        {
            InitializeComponent();
            CargarCombos();
            CargarComboAdmin();

            txtId.Text = usuario.Id.ToString();
            txtNombre.Text = usuario.Nombre;
            txtEmail.Text = usuario.Email;
            txtDomicilio.Text = usuario.Domicilio;
            txtLogin.Text = usuario.UsuarioLogin;
            txtContraseña.Text = usuario.Contrasena;

            if (usuario.Activo)
            {
                this.comboActivo.SelectedItem = this.comboActivo.Items[0];
            }
            else
            {
                this.comboActivo.SelectedItem = this.comboActivo.Items[1];
            }

            if(usuario.Admin)
            {
                this.comboEsAdmin.SelectedItem = this.comboEsAdmin.Items[0];
            }
            else
            {
                this.comboEsAdmin.SelectedItem = this.comboEsAdmin.Items[1];
            }

        }

        private void EditarUsuario_Load(object sender, EventArgs e)
        {
            this.txtDomicilio.Enabled = false;
        }

        private void CargarCombos()
        {
            this.comboActivo.Items.Add("SI");
            this.comboActivo.Items.Add("NO");

        }


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuarioModificada = new Usuario()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Email = txtEmail.Text,
                Domicilio = txtDomicilio.Text,
                UsuarioLogin = txtLogin.Text,
                Contrasena = txtContraseña.Text,
                Activo = Usuario.EsActivo(comboActivo.Text),
                Admin = Usuario.EsAdministrador(comboEsAdmin.Text)
            };

            UsuarioControlador.ActualizarUsuarios(usuarioModificada.Id, usuarioModificada);

            Regresar();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Regresar();
        }

        private void Regresar()
        {
            Inicio2 inicio2 = new Inicio2();
            inicio2.Show();

            this.Hide();
        }


        private void CargarComboAdmin()
        {
            this.comboEsAdmin.Items.Add("SI");
            this.comboEsAdmin.Items.Add("NO");
        }

    }
}
