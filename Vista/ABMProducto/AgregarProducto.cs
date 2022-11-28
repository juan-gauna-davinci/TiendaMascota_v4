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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            AsignarIdConsecutivo();
            this.txtID.Enabled = false;
            CargarCombos();
        }
        private void botonAtras_Click(object sender, EventArgs e)
        {
            Regresar();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            Producto productoNuevo = new Producto()
            {
                Id = int.Parse(txtID.Text),
                Nombre = txtNombre.Text,
                Precio = int.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text),
                IdCategoria = CategoriaControlador.ObtenerCategoriaPorNombre(comboCategoria.Text).Id,
                IdAnimal = AnimalControlador.ObtenerAnimalPorNombre(comboAnimales.Text).Id,
                RutaImagen = txtRutaImagen.Text,
                Activo = Producto.EsActivo(comboActivo.Text)
            };

            ProductoControlador.AgregarProducto(productoNuevo);
                
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
            int id = ProductoControlador.ObtenerUltimoId();

            if(id == 0)
            {
                id = 1;
            }

            this.txtID.Text = id.ToString();
        }

        private void CargarCombos()
        {
            CargarComboAnimales();
            CargarComboActivo();
            CargarComboCategorias();
        }

        private void CargarComboAnimales()
        {
            foreach (var animal in AnimalControlador.ObtenerAnimales())
            {
                this.comboAnimales.Items.Add(animal.Nombre);
            }
        }

        private void CargarComboCategorias()
        {
            foreach(var categoria in CategoriaControlador.ObtenerCategorias())
            {
                this.comboCategoria.Items.Add(categoria.Nombre);
            }
        }

        private void CargarComboActivo()
        {
            this.comboActivo.Items.Add("SI");
            this.comboActivo.Items.Add("NO");
        }

    }
}
