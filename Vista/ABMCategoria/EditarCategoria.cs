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

namespace TiendaMascota_v2.Vista.ABMCategoria
{
    public partial class EditarCategoria : Form
    {
        public EditarCategoria()
        {
            InitializeComponent();
        }

        private void EditarCategoria_Load(object sender, EventArgs e)
        {
            this.txtId.Enabled = false;
        }

        public EditarCategoria(Categoria categoria)
        {
            InitializeComponent();
            CargarCombos();

            txtId.Text = categoria.Id.ToString();
            txtNombre.Text = categoria.Nombre;

            if (categoria.Activo)
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


        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Categoria categoriaModificada = new Categoria()
            {
                Id = int.Parse(txtId.Text),
                Nombre = txtNombre.Text,
                Activo = Categoria.EsActivo(comboActivo.Text)
            };

            CategoriaControlador.ActualizarCategoria(categoriaModificada.Id, categoriaModificada);

            VerCategorias verCategorias = new VerCategorias();
            verCategorias.Show();
            this.Hide();

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
