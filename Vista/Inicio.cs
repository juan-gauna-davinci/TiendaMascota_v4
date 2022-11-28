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
using TiendaMascota_v2.Vista;
using TiendaMascota_v2.Vista.ABMAnimal;
using TiendaMascota_v2.Vista.ABMCategoria;
using TiendaMascota_v2.Vista.ABMProducto;
using TiendaMascota_v2.Vista.ABMUsuario;

namespace TiendaMascota_v2
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InicializarGrilla();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            AgregarProducto vistaAgregar = new AgregarProducto();
            vistaAgregar.Show();
            this.Hide();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            EliminarProducto vistaEliminar = new EliminarProducto();
            vistaEliminar.Show();
            this.Hide();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void InicializarGrilla()
        {
            DataTable tabla = CrearTabla();
            LlenarTabla(tabla);
        }

        private DataTable CrearTabla()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Precio");
            tabla.Columns.Add("Stock");
            tabla.Columns.Add("SubCategoria");
            tabla.Columns.Add("Animal");
            tabla.Columns.Add("RutaImagen");
            tabla.Columns.Add("Activo");

            grilla.DataSource = tabla;

            return tabla;
        }

        private void LlenarTabla(DataTable tabla)
        {
            
            foreach (var item in ProductoControlador.ObtenerProductos())
            {
                var categoria = CategoriaControlador.ObtenerCategoriaPorId(item.IdCategoria);

                DataRow fila = tabla.NewRow();
                fila["Id"] = item.Id;
                fila["Nombre"] = item.Nombre;
                fila["Precio"] = item.Precio;
                fila["Stock"] = item.Stock;
                fila["Categoria"] = categoria.Nombre;
                fila["Animal"] = item.IdAnimal;
                fila["RutaImagen"] = item.RutaImagen;
                fila["Activo"] = Producto.EsActivo(item.Activo);
                

                tabla.Rows.Add(fila);
            }

        }

        private void btnVerAnimales_Click(object sender, EventArgs e)
        {
            VerAnimales vistaAnimales = new VerAnimales();
            vistaAnimales.Show();
            this.Hide();
        }

        private void botonVerCategorias_Click(object sender, EventArgs e)
        {
            VerCategorias vistaCategorias = new VerCategorias();
            vistaCategorias.Show();
            this.Hide();
        }

        private void btnVerUsr_Click(object sender, EventArgs e)
        {
            VerUsuarios vistaUsuarios = new VerUsuarios();
            vistaUsuarios.Show();
            this.Hide();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.grilla.SelectedRows.Count == 1)
            {
                var idSeleccionado = this.grilla.SelectedRows[0].Cells[0].Value.ToString();

                Producto productoSeleccionado = ProductoRepositorio.ObtenerProductoPorId(int.Parse(idSeleccionado));

                EditarProducto editarProducto = new EditarProducto(productoSeleccionado);

                editarProducto.Show();

                this.Hide();
            }
        }

    }
}
