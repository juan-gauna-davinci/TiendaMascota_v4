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

namespace TiendaMascota_v2.Vista.AMBProveedor
{
    public partial class EditarProveedor : Form
    {
        public EditarProveedor()
        {
            InitializeComponent();
        }

        public EditarProveedor(Proveedor proveedor)
        {
            InitializeComponent();
            CargarCombos();

            this.txtId.Text = proveedor.Id.ToString();
            this.txtNombre.Text = proveedor.Nombre;

            if (proveedor.Activo)
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

        private void Regresar()
        {
            Inicio2 inicio2 = new Inicio2();
            inicio2.Show();

            this.Hide();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Proveedor proveedorModificado = new Proveedor()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Activo = Proveedor.EsActivo(comboActivo.Text)
            };


            if (ProveedorControlador.HuboModificaciones(proveedorModificado))
            {
                ProveedorControlador.ActualizarProveedor(proveedorModificado.Id, proveedorModificado);

                Regresar();

            }

            Regresar();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            Regresar();
        }

        private void EditarProveedor_Load_1(object sender, EventArgs e)
        {
            this.txtId.Enabled = false;
        }
    }
}
