using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaMascota_v2.Modelo;
using TiendaMascota_v2.Controlador;
using TiendaMascota_v2.Repositorio;

namespace TiendaMascota_v2.Vista.ABMCliente
{
    public partial class EditarCliente : Form
    {
        public EditarCliente()
        {
            InitializeComponent();
        }

        public EditarCliente(Cliente cliente)
        {
            InitializeComponent();
            CargarCombos();

            this.txtId.Text = cliente.Id.ToString();
            this.txtNombre.Text = cliente.Nombre;

            if (cliente.Activo)
            {
                this.comboActivo.SelectedItem = this.comboActivo.Items[0];
            }
            else
            {
                this.comboActivo.SelectedItem = this.comboActivo.Items[1];
            }
        }

        private void CargarCombos()
        {
            this.comboActivo.Items.Add("SI");
            this.comboActivo.Items.Add("NO");
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
            this.txtId.Enabled = false;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Cliente clienteModificado = new Cliente()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtEmail.Text,
                Domicilio = txtDomicilio.Text,
                Activo = Cliente.EsActivo(comboActivo.Text)
            };


            if (ClienteControlador.HuboModificaciones(clienteModificado))
            {
                ClienteControlador.ActualizarCliente(clienteModificado.Id, clienteModificado);

                VerCliente vistaVerCliente = new VerCliente();
                vistaVerCliente.Show();
                this.Hide();

            }

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
    }
}
