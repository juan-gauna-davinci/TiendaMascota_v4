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

namespace TiendaMascota_v2.Vista.ABMCliente
{
    public partial class VerCliente : Form
    {
        public VerCliente()
        {
            InitializeComponent();
        }

        private void VerCliente_Load(object sender, EventArgs e)
        {
            InicializarGrilla();
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            AgregarCliente vistaAgregarCliente = new AgregarCliente();
            vistaAgregarCliente.Show();
            this.Hide();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            EliminarCliente vistaEliminarCliente = new EliminarCliente();
            vistaEliminarCliente.Show();
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
            tabla.Columns.Add("Domicilio");
            tabla.Columns.Add("Activo");
            grillaClientes.DataSource = tabla;

            return tabla;
        }

        private void LlenarTabla(DataTable tabla)
        {

            foreach (var item in ClienteControlador.ObtenerClientes())
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = item.Id;
                fila["Nombre"] = item.Nombre;
                fila["Apellido"] = item.Apellido;
                fila["Email"] = item.Email;
                fila["Domicilio"] = item.Domicilio;
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
            if (this.grillaClientes.SelectedRows.Count == 1)
            {
                var idSeleccionado = this.grillaClientes.SelectedRows[0].Cells[0].Value.ToString();

                Cliente clienteSeleccionado = ClienteRepositorio.ObtenerClientePorId(int.Parse(idSeleccionado));

                EditarCliente editarCliente = new EditarCliente(clienteSeleccionado);

                editarCliente.Show();

                this.Hide();
            }
        }

        private void btnAgregarCliente_Click_1(object sender, EventArgs e)
        {

        }

        private void botonEliminar_Click_1(object sender, EventArgs e)
        {

        }
    }
}

