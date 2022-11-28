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

namespace TiendaMascota_v2.Vista.ABMCliente
{
    public partial class AgregarCliente : Form
    {
        public AgregarCliente()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            AsignarIdConsecutivo();
            CargarCombos();
        }

        private void AsignarIdConsecutivo()
        {
            int id = ClienteControlador.ObtenerUltimoId();

            this.txtId.Text = id.ToString();
        }

        private void CargarCombos()
        {
            this.comboActivo.Items.Add("SI");
            this.comboActivo.Items.Add("NO");
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Cliente clienteNuevo = new Cliente()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtEmail.Text,
                Domicilio = txtDomicilio.Text,
                Activo = Cliente.EsActivo(comboActivo.Text)
            };

            ClienteControlador.AgregarCliente(clienteNuevo);

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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
