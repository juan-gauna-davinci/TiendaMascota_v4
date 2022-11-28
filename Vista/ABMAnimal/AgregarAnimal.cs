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

namespace TiendaMascota_v2.Vista.ABMAnimal
{
    public partial class AgregarAnimal : Form
    {
        public AgregarAnimal()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            AsignarIdConsecutivo();
            CargarCombos();
        }

        private void AsignarIdConsecutivo()
        {
            int id = AnimalControlador.ObtenerUltimoId();

            this.txtId.Text = id.ToString();
        }

        private void CargarCombos()
        {
            this.comboActivo.Items.Add("SI");
            this.comboActivo.Items.Add("NO");
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Animal animalNuevo = new Animal()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Activo = Animal.EsActivo(comboActivo.Text)// to do: agregar combo activo SI / NO
            };

            AnimalControlador.AgregarAnimal(animalNuevo);

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
