using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaMascota_v2.Modelo;
using TiendaMascota_v2.Controlador;
using TiendaMascota_v2.Repositorio;

namespace TiendaMascota_v2.Vista.ABMEmpleado
{
    public partial class EditarEmpleado : Form
    {
        public EditarEmpleado()
        {
            InitializeComponent();
        }

        public EditarEmpleado(Empleado empleado)
        {
            InitializeComponent();
            CargarCombos();

            this.txtId.Text = empleado.Id.ToString();
            this.txtNombre.Text = empleado.Nombre;

            if (empleado.Activo)
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
        }

        private void EditarEmpleado_Load(object sender, EventArgs e)
        {
            this.txtId.Enabled = false;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Empleado empleadoModificado = new Empleado()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Email = txtEmail.Text,
                Activo = Empleado.EsActivo(comboActivo.Text)
            };


            if (EmpleadoControlador.HuboModificaciones(empleadoModificado))
            {
                EmpleadoControlador.ActualizarEmpleado(empleadoModificado.Id, empleadoModificado);

                VerEmpleado vistaVerEmpleado = new VerEmpleado();
                vistaVerEmpleado.Show();
                this.Hide();

            }

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

        //private void EditarEmpleado_Load(object sender, EventArgs e)
        //{

        //}
    }
}
