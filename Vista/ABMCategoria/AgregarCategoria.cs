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
using TiendaMascota_v2.Vista.ABMAnimal;

namespace TiendaMascota_v2.Vista.ABMCategoria
{
    public partial class AgregarCategoria : Form
    {
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void AgregarCategoria_Load(object sender, EventArgs e)
        {
            AsignarIdConsecutivo();
            CargarCombos();
        }

        private void botonAceptar_Click(object sender, EventArgs e)
        {
            Categoria categoriaNuevo = new Categoria()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Activo = Categoria.EsActivo(comboActivo.Text)
            };

            CategoriaControlador.AgregarCategoria(categoriaNuevo);

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

        private void AsignarIdConsecutivo()
        {
            int id = CategoriaControlador.ObtenerUltimoId();

            if (id == 0)
                id = 1;

            this.txtId.Text = id.ToString();
        }

        private void CargarCombos()
        {
            CargarComboActivo();
        }

        private void CargarComboActivo()
        {
            this.comboActivo.Items.Add("SI");
            this.comboActivo.Items.Add("NO");
        }

    }
}
