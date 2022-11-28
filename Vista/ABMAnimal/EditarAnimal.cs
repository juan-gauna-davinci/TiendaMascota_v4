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
    public partial class EditarAnimal : Form
    {
        public EditarAnimal()
        {
            InitializeComponent();
        }

        public EditarAnimal(Animal animal)
        {
            InitializeComponent();
            CargarCombos();

            this.txtId.Text = animal.Id.ToString();
            this.txtNombre.Text = animal.Nombre;

            if(animal.Activo)
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

        private void EditarAnimal_Load(object sender, EventArgs e)
        {
            this.txtId.Enabled = false;
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Animal animalModificado = new Animal()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Activo = Animal.EsActivo(comboActivo.Text)
            };


            if(AnimalControlador.HuboModificaciones(animalModificado))
            {
                AnimalControlador.ActualizarAnimal(animalModificado.Id, animalModificado);

                VerAnimales vistaVerAnimales = new VerAnimales();
                vistaVerAnimales.Show();
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
    }
}
