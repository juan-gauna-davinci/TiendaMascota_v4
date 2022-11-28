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

namespace TiendaMascota_v2.Vista.ABMEmpleado
{
    public partial class VerEmpleado : Form
    {
        public VerEmpleado()
        {
            InitializeComponent();
        }

        private void VerEmpleado_Load(object sender, EventArgs e)
        {
            InicializarGrilla();
        }

        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            AgregarEmpleado vistaAgregarEmpleado = new AgregarEmpleado();
            vistaAgregarEmpleado.Show();
            this.Hide();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            EliminarEmpleado vistaEliminarEmpleado = new EliminarEmpleado();
            vistaEliminarEmpleado.Show();
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
            tabla.Columns.Add("Apellido");
            tabla.Columns.Add("Email");
            tabla.Columns.Add("Activo");
            grillaEmpleados.DataSource = tabla;

            return tabla;
        }

        private void LlenarTabla(DataTable tabla)
        {

            foreach (var item in EmpleadoControlador.ObtenerEmpleados())
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = item.Id;
                fila["Nombre"] = item.Nombre;
                fila["Apellido"] = item.Apellido;
                fila["Email"] = item.Email;
                fila["Activo"] = Cliente.EsActivo(item.Activo);

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
            if (this.grillaEmpleados.SelectedRows.Count == 1)
            {
                var idSeleccionado = this.grillaEmpleados.SelectedRows[0].Cells[0].Value.ToString();

                Empleado empleadoSeleccionado = EmpleadoRepositorio.ObtenerEmpleadoPorId(int.Parse(idSeleccionado));

                EditarEmpleado editarEmpleado = new EditarEmpleado(empleadoSeleccionado);

                editarEmpleado.Show();

                this.Hide();
            }
        }
    }
}
