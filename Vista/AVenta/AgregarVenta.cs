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
using TiendaMascota_v2.Vista.ABMAnimal;

namespace TiendaMascota_v2.Vista.ABMCategoria
{
    public partial class AgregarVenta : Form
    {
        public AgregarVenta()
        {
            InitializeComponent();
        }

        private void AgregarCategoria_Load(object sender, EventArgs e)
        {
            AsignarIdConsecutivo();
            this.txtId.Enabled = false;
            this.txtPrecioFinal.Enabled = false;
            CargarCombos();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Venta ventaNuevo = new Venta()
            {
                Id = int.Parse(txtId.Text),
                IdProducto = ProductoControlador.ObtenerProductoPorNombre(this.comboProductos.Text).Id,
                Cantidad = int.Parse(txtCantidad.Text),
                PrecioFinal = double.Parse(txtPrecioFinal.Text)
            };

            VentaControlador.AgregarVenta(ventaNuevo);

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

        private void AsignarIdConsecutivo()
        {
            int id = VentaControlador.ObtenerUltimoId();

            if (id == 0)
                id = 1;

            this.txtId.Text = id.ToString();
        }

        private void CargarCombos()
        {
            CargarComboProductos();
        }

        private void CargarComboProductos()
        {
            foreach (var producto in ProductoControlador.ObtenerProductos())
            {
                this.comboProductos.Items.Add(producto.Nombre);
            }
        }

        private void txtCantidad_ValueChanged(object sender, EventArgs e)
        {
            if (this.comboProductos.Text != "" && this.txtCantidad.Value != 0)
            {
                Producto productoSeleccionado = ProductoControlador.ObtenerProductoPorNombre(comboProductos.Text);

                int cantidadSeleccionada = int.Parse(this.txtCantidad.Text);

                double precioFinal = cantidadSeleccionada * productoSeleccionado.Precio;

                this.txtPrecioFinal.Text = precioFinal.ToString();
            }

            if (this.txtCantidad.Value == 0)
            {
                this.txtPrecioFinal.Text = "0";
            }
        }
    }
}
