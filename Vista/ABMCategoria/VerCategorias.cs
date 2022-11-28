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
using TiendaMascota_v2.Vista.ABMAnimal;

namespace TiendaMascota_v2.Vista.ABMCategoria
{
    public partial class VerCategorias : Form
    {
        public VerCategorias()
        {
            InitializeComponent();
        }

        private void VerCategorias_Load(object sender, EventArgs e)
        {
            InicializarGrilla();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            AgregarCategoria vistaAgregarCategoria = new AgregarCategoria();
            vistaAgregarCategoria.Show();
            this.Hide();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            EliminarCategoria vistaEliminarCategoria = new EliminarCategoria();
            vistaEliminarCategoria.Show();
            this.Hide();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            RegresarFormInicio();
        }

        private void RegresarFormInicio()
        {
            Inicio vistaInicio = InicioControlador.Inicio;
            //vistaInicio.InicializarGrilla();
            vistaInicio.Show();
            this.Hide();
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
            tabla.Columns.Add("Animal");
            tabla.Columns.Add("Activo");
            grillaCategorias.DataSource = tabla;

            return tabla;
        }

        private void LlenarTabla(DataTable tabla)
        {

            foreach (var item in CategoriaControlador.ObtenerCategorias())
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = item.Id;
                fila["Nombre"] = item.Nombre;
                fila["Activo"] = Categoria.EsActivo(item.Activo);

                tabla.Rows.Add(fila);
            }

        }

        private void grillaCategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (this.grillaCategorias.SelectedRows.Count == 1)
            {
                var idSeleccionado = this.grillaCategorias.SelectedRows[0].Cells[0].Value.ToString();

                Categoria categoriaSeleccionada = CategoriaRepositorio.ObtenerCategoriaPorId(int.Parse(idSeleccionado));

                EditarCategoria editarCategoria= new EditarCategoria(categoriaSeleccionada);

                editarCategoria.Show();

                this.Hide();
            }

        }
    }
}
