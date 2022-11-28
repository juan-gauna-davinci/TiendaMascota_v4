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

namespace TiendaMascota_v2.Vista.ABMProveedor
{
    public partial class VerProveedor : Form
    {
        public VerProveedor()
        {
            InitializeComponent();
        }

        private void VerProveedor_Load(object sender, EventArgs e)
        {

            InicializarGrilla();

        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            AgregarProveedor vistaAgregarProveedor = new AgregarProveedor();
            vistaAgregarProveedor.Show();
            this.Hide();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            EliminarProveedor vistaEliminarProveedor = new EliminarProveedor();
            vistaEliminarProveedor.Show();
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
            grillaProveedor.DataSource = tabla;

            return tabla;
        }

        private void LlenarTabla(DataTable tabla)
        {

            foreach (var item in ProveedorControlador.ObtenerProveedores())
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = item.Id;
                fila["Nombre"] = item.Nombre;
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
            if (this.grillaProveedor.SelectedRows.Count == 1)
            {
                var idSeleccionado = this.grillaProveedor.SelectedRows[0].Cells[0].Value.ToString();

                Proveedor proveedorSeleccionado = ProveedorRepositorio.ObtenerProveedorPorId(int.Parse(idSeleccionado));

                EditarProveedor editarProveedor = new EditarProveedor(proveedorSeleccionado);

                editarProveedor.Show();

                this.Hide();
            }
        }
    }
}
