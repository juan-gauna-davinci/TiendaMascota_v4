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

namespace TiendaMascota_v2.Vista.ABMCategoria
{
    public partial class EliminarCategoria : Form
    {
        public EliminarCategoria()
        {
            InitializeComponent();
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

        private void botonEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
