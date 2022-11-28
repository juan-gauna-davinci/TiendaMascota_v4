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

namespace TiendaMascota_v2.Vista.ABMAnimal
{
    public partial class VerAnimales : Form
    {
        public VerAnimales()
        {
            InitializeComponent();
        }

        private void VerAnimales_Load(object sender, EventArgs e)
        {
            InicializarGrilla();

        }

        private void btnAgregarAnimal_Click(object sender, EventArgs e)
        {
            AgregarAnimal vistaAgregarAnimal = new AgregarAnimal();
            vistaAgregarAnimal.Show();
            this.Hide();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            EliminarAnimal vistaEliminarAnimal = new EliminarAnimal();
            vistaEliminarAnimal.Show();
            this.Hide();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            RegresarFormInicio();
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
            tabla.Columns.Add("Activo");
            grillaAnimales.DataSource = tabla;

            return tabla;
        }

        private void LlenarTabla(DataTable tabla)
        {

            foreach (var item in AnimalControlador.ObtenerAnimales())
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = item.Id;
                fila["Nombre"] = item.Nombre;
                fila["Activo"] = Animal.EsActivo(item.Activo);

                tabla.Rows.Add(fila);
            }

        }

        private void RegresarFormInicio()
        {
            Inicio vistaInicio = InicioControlador.Inicio;
            //vistaInicio.InicializarGrilla();
            vistaInicio.Show();
            this.Hide();
        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if(this.grillaAnimales.SelectedRows.Count == 1)
            {
                var idSeleccionado = this.grillaAnimales.SelectedRows[0].Cells[0].Value.ToString();

                Animal animalSeleccionado = AnimalRepositorio.ObtenerAnimalPorId(int.Parse(idSeleccionado));

                EditarAnimal editarAnimal = new EditarAnimal(animalSeleccionado);

                editarAnimal.Show();

                this.Hide();
            }
        }
    }
}
