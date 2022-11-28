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
using TiendaMascota_v2.Repositorio;
using TiendaMascota_v2.Vista.ABMCategoria;

namespace TiendaMascota_v2.Vista.ABMProducto
{
    public partial class EditarProducto : Form
    {
        public EditarProducto()
        {
            InitializeComponent();
        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            this.txtId.Enabled = false;
        }

        public EditarProducto(Producto producto)
        {
            InitializeComponent();
            CargarCombos();



            txtId.Text = producto.Id.ToString();
            txtNombre.Text = producto.Nombre;
            txtPrecio.Text = producto.Precio.ToString();
            txtStock.Text = producto.Stock.ToString();
            comboAnimales.SelectedIndex = comboAnimales.FindString(AnimalControlador.ObtenerAnimalPorId(producto.IdAnimal).Nombre);
            comboCategorias.SelectedIndex = comboCategorias.FindStringExact(CategoriaControlador.ObtenerCategoriaPorId(producto.IdCategoria).Nombre);
            txtRutaImagen.Text = producto.RutaImagen;
            if (producto.Activo)
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

            CargarComboAnimales();

        }


        private void CargarComboAnimales()
        {
            foreach (var animal in AnimalControlador.ObtenerAnimales())
            {
                this.comboAnimales.Items.Add(animal.Nombre);
            }
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {

            Producto productoModificado = new Producto()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Precio = int.Parse(txtPrecio.Text),
                Stock = int.Parse(txtStock.Text),
                IdCategoria = CategoriaControlador.ObtenerCategoriaPorNombre(comboCategorias.Text).Id,
                IdAnimal = AnimalControlador.ObtenerAnimalPorNombre(comboAnimales.Text).Id,
                RutaImagen = txtRutaImagen.Text,
                Activo = Categoria.EsActivo(comboActivo.Text)
            };

            ProductoControlador.ActualizarProducto(productoModificado.Id, productoModificado);

            Inicio inicio = new Inicio();
            inicio.Show();
            this.Hide();
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
