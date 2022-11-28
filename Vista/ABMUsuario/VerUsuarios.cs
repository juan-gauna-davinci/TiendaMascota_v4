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
using TiendaMascota_v2.Vista.ABMCategoria;

namespace TiendaMascota_v2.Vista.ABMUsuario
{
    public partial class VerUsuarios : Form
    {
        public VerUsuarios()
        {
            InitializeComponent();
        }

        private void VerUsuarios_Load(object sender, EventArgs e)
        {
            InicializarGrilla();
        }

        private void botonAgregar_Click(object sender, EventArgs e)
        {
            AgregarUsuario vistaAgregarUsuario = new AgregarUsuario();
            vistaAgregarUsuario.Show();
            this.Hide();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
            EliminarUsuario vistaEliminarUsuario = new EliminarUsuario();
            vistaEliminarUsuario.Show();
            this.Hide();
        }

        private void botonAtras_Click(object sender, EventArgs e)
        {
            RegresarFormInicio();
        }

        private void RegresarFormInicio()
        {
            Inicio vistaInicio = InicioControlador.Inicio;
            //vistaInicio.InicializarGrilla();
            vistaInicio.Show();
            this.Hide();
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
            tabla.Columns.Add("Email");
            tabla.Columns.Add("Domicilio");
            tabla.Columns.Add("Usuario_login");
            tabla.Columns.Add("Contraseña");
            tabla.Columns.Add("Activo");
            grillaUsuarios.DataSource = tabla;

            return tabla;
        }

        private void LlenarTabla(DataTable tabla)
        {

            foreach (var item in UsuarioControlador.ObtenerUsuarios())
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = item.Id;
                fila["Nombre"] = item.Nombre;
                fila["Email"] = item.Email;
                fila["Domicilio"] = item.Domicilio;
                fila["Usuario_login"] = item.UsuarioLogin;
                fila["Contraseña"] = item.Contrasena;
                fila["Activo"] = Usuario.EsActivo(item.Activo);

                tabla.Rows.Add(fila);
            }

        }

        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (this.grillaUsuarios.SelectedRows.Count == 1)
            {
                var idSeleccionado = this.grillaUsuarios.SelectedRows[0].Cells[0].Value.ToString();

                Usuario usuarioSeleccionada = UsuarioRepositorio.ObtenerUsuarioPorId(int.Parse(idSeleccionado));

                EditarUsuario editarUsuario = new EditarUsuario(usuarioSeleccionada);

                editarUsuario.Show();

                this.Hide();

            }
        }
    }
}
