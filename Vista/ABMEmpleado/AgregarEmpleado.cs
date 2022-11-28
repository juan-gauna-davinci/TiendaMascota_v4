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

namespace TiendaMascota_v2.Vista.ABMEmpleado
{
    public partial class AgregarEmpleado : Form
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
        }

        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            AsignarIdConsecutivo();
            CargarCombos();
        }

        private void AsignarIdConsecutivo()
        {
            int id = EmpleadoControlador.ObtenerUltimoId();

            this.txtId.Text = id.ToString();
        }

        private void CargarCombos()
        {
            this.comboActivo.Items.Add("SI");
            this.comboActivo.Items.Add("NO");
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Empleado empleadoNuevo = new Empleado()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtEmail.Text,
                Activo = Empleado.EsActivo(comboActivo.Text)
            };

            EmpleadoControlador.AgregarEmpleado(empleadoNuevo);

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
    }
}
