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

namespace TiendaMascota_v2.Vista.ABMProveedor
{
    public partial class AgregarProveedor : Form
    {
        public AgregarProveedor()
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
            int id =ProveedorControlador.ObtenerUltimoId();

            this.txtId.Text = id.ToString();
        }

        private void CargarCombos()
        {
            this.comboActivo.Items.Add("SI");
            this.comboActivo.Items.Add("NO");
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Proveedor proveedorNuevo = new Proveedor()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Activo = Proveedor.EsActivo(comboActivo.Text)
            };

            ProveedorControlador.AgregarProveedor(proveedorNuevo);

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

        private void AgregarProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
