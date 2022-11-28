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
using TiendaMascota_v2.Vista.ABMAnimal;
using TiendaMascota_v2.Vista.ABMCategoria;
using TiendaMascota_v2.Vista.ABMProducto;
using TiendaMascota_v2.Vista.ABMUsuario;

namespace TiendaMascota_v2.Vista
{
    public partial class Inicio2 : Form
    {
        public Inicio2()
        {
            InitializeComponent();
        
        }

        private void Inicio2_Load(object sender, EventArgs e)
        {
            InicializarGrillaProductos();
            InicializarGrillaCategorias();
            InicializarGrillaAnimales();
            InicializarGrillaVentas();

            this.lblErrorClickEditar.Visible = false;
            this.lblErrorClickEditarCat.Visible = false;
            this.lblErrorClickEditarAnimal.Visible = false;
            this.lblErrorClickEditarUsuario.Visible = false;
            this.lblSinPermisos.Visible = false;

            if (InicioControlador.UsuarioLogueado.Admin)
            {
                InicializarGrillaUsuarios();
            }
            else
            {
                this.lblSinPermisos.Visible = true;
            }



        }

        #region Productos

        #region Tabla
        private void InicializarGrillaProductos()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Precio");
            tabla.Columns.Add("Stock");
            tabla.Columns.Add("Categoria");
            tabla.Columns.Add("Animal");

            DataColumn dataColumnImg = new DataColumn();
            dataColumnImg.DataType = System.Type.GetType("System.Byte[]");
            dataColumnImg.ColumnName = "Imagen";
            tabla.Columns.Add(dataColumnImg);

            tabla.Columns.Add("Activo");

            

            grillaProductos.DataSource = tabla;

            LlenarTablaProductos(tabla);
        }

        private void LlenarTablaProductos(DataTable tabla)
        {

            foreach (var item in ProductoControlador.ObtenerProductos())
            {
                var categoria = CategoriaControlador.ObtenerCategoriaPorId(item.IdCategoria);

                DataRow fila = tabla.NewRow();
                fila["Id"] = item.Id;
                fila["Nombre"] = item.Nombre;
                fila["Precio"] = item.Precio;
                fila["Stock"] = item.Stock;
                fila["Categoria"] = CategoriaControlador.ObtenerCategoriaPorId(item.IdCategoria).Nombre;
                fila["Animal"] = AnimalControlador.ObtenerAnimalPorId(item.IdAnimal).Nombre;

                //var imageConverter = new ImageConverter();
                //Bitmap img;
                //img = new Bitmap(@"D:\Documents\GitHub\TiendaMascota_v3\bin\Debug\imagenes\" + item.RutaImagen + ".jpg");
                //fila["Imagen"] = imageConverter.ConvertTo(img, System.Type.GetType("System.Byte[]"));

                fila["Activo"] = Producto.EsActivo(item.Activo);

                
                tabla.Rows.Add(fila);
            }
        }
        #endregion

        // Agregar
        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto vistaAgregar = new AgregarProducto();
            vistaAgregar.Show();
            this.Hide();
        }

        // Editar
        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (this.grillaProductos.SelectedRows.Count == 1)
            {
                var idSeleccionado = this.grillaProductos.SelectedRows[0].Cells[0].Value.ToString();

                Producto productoSeleccionado = ProductoRepositorio.ObtenerProductoPorId(int.Parse(idSeleccionado));

                EditarProducto editarProducto = new EditarProducto(productoSeleccionado);

                editarProducto.Show();

                this.Hide();
            }
            else
            {
                lblErrorClickEditar.Visible = true;
            }
        }

        // Eliminar
        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto vistaEliminar = new EliminarProducto();
            vistaEliminar.Show();
            this.Hide();
        }

        #endregion

        #region Categorias

        #region Tabla   

        private void InicializarGrillaCategorias()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Activo");
            grillaCategorias.DataSource = tabla;

            LlenarTablaCategorias(tabla);
        }

        private void LlenarTablaCategorias(DataTable tabla)
        {
            foreach (var item in CategoriaControlador.ObtenerCategorias())
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = item.Id;
                fila["Nombre"] = item.Nombre;
                fila["Activo"] = Categoria.EsActivo(item.Activo);

                tabla.Rows.Add(fila);
            }
        }


        #endregion

        // Agregar
        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            AgregarCategoria vistaAgregarCategoria = new AgregarCategoria();
            vistaAgregarCategoria.Show();
            this.Hide();
        }

        // Editar
        private void btnEditarCategoria_Click(object sender, EventArgs e)
        {
            if (this.grillaCategorias.SelectedRows.Count == 1)
            {
                var idSeleccionado = this.grillaCategorias.SelectedRows[0].Cells[0].Value.ToString();

                Categoria categoriaSeleccionada = CategoriaRepositorio.ObtenerCategoriaPorId(int.Parse(idSeleccionado));

                EditarCategoria editarCategoria = new EditarCategoria(categoriaSeleccionada);

                editarCategoria.Show();

                this.Hide();
            }
            else
            {
                lblErrorClickEditarCat.Visible = true;
            }
        }

        // Eliminar
        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            EliminarCategoria vistaEliminarCategoria = new EliminarCategoria();
            vistaEliminarCategoria.Show();
            this.Hide();
        }

        #endregion

        #region Animales

        private void InicializarGrillaAnimales()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Activo");
            grillaAnimales.DataSource = tabla;

            LlenarTablaAnimales(tabla);
        }

        private void LlenarTablaAnimales(DataTable tabla)
        {
            foreach (var item in AnimalControlador.ObtenerAnimales())
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = item.Id;
                fila["Nombre"] = item.Nombre;
                fila["Activo"] = Animal.EsActivo(item.Activo);

                tabla.Rows.Add(fila);
            }
        }

        // Agregar
        private void btnAgregarAnimal_Click(object sender, EventArgs e)
        {
            AgregarAnimal vistaAgregarAnimal = new AgregarAnimal();
            vistaAgregarAnimal.Show();
            this.Hide();
        }

        //Editar
        private void btnEditarAnimal_Click(object sender, EventArgs e)
        {
            if (this.grillaAnimales.SelectedRows.Count == 1)
            {
                var idSeleccionado = this.grillaAnimales.SelectedRows[0].Cells[0].Value.ToString();

                Animal animalSeleccionado = AnimalRepositorio.ObtenerAnimalPorId(int.Parse(idSeleccionado));

                EditarAnimal editarAnimal = new EditarAnimal(animalSeleccionado);

                editarAnimal.Show();

                this.Hide();
            }
            else
            {
                lblErrorClickEditarAnimal.Visible = true;
            }
        }

        //Eliminar
        private void btnEliminarAnimal_Click(object sender, EventArgs e)
        {
            EliminarAnimal vistaEliminarAnimal = new EliminarAnimal();
            vistaEliminarAnimal.Show();
            this.Hide();
        }



        #endregion

        #region Usuarios

        private void InicializarGrillaUsuarios()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Email");
            tabla.Columns.Add("Domicilio");
            tabla.Columns.Add("Usuario_login");
            tabla.Columns.Add("Contraseña");
            tabla.Columns.Add("Activo");
            tabla.Columns.Add("EsAdmin");

            grillaUsuarios.DataSource = tabla;

            LlenarTablaUsuarios(tabla);
        }

        private void LlenarTablaUsuarios(DataTable tabla)
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
                fila["EsAdmin"] = Usuario.EsAdministrador(item.Admin);

                tabla.Rows.Add(fila);
            }
        }

        //Agregar
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            AgregarUsuario vistaAgregarUsuario = new AgregarUsuario();
            vistaAgregarUsuario.Show();
            this.Hide();
        }

        //Editar
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {

            if (this.grillaUsuarios.SelectedRows.Count == 1)
            {
                var idSeleccionado = this.grillaUsuarios.SelectedRows[0].Cells[0].Value.ToString();

                Usuario usuarioSeleccionada = UsuarioRepositorio.ObtenerUsuarioPorId(int.Parse(idSeleccionado));

                EditarUsuario editarUsuario = new EditarUsuario(usuarioSeleccionada);

                editarUsuario.Show();

                this.Hide();

            }
            else
            {
                this.lblErrorClickEditarUsuario.Visible = true;
            }    
        }

        //Eliminar
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            EliminarUsuario vistaEliminarUsuario = new EliminarUsuario();
            vistaEliminarUsuario.Show();
            this.Hide();
        }
        #endregion

        private void salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region Ventas

        private void InicializarGrillaVentas()
        {
            DataTable tabla = new DataTable();
            tabla.Columns.Add("Id");
            tabla.Columns.Add("Producto");
            tabla.Columns.Add("Cantidad");
            tabla.Columns.Add("PrecioFinal");

            grillaVentas.DataSource = tabla;

            LlenarTablaVentas(tabla);
        }

        private void LlenarTablaVentas(DataTable tabla)
        {

            foreach (var item in VentaControlador.ObtenerVentas())
            {
                DataRow fila = tabla.NewRow();
                fila["Id"] = item.Id;
                fila["Producto"] = ProductoControlador.ObtenerProductoPorId(item.IdProducto).Nombre;
                fila["Cantidad"] = item.Cantidad;
                fila["PrecioFinal"] = item.PrecioFinal;
        

                tabla.Rows.Add(fila);
            }
        }


        private void btnAgregarVenta_Click(object sender, EventArgs e)
        {
            AgregarVenta agregarVenta = new AgregarVenta();
            agregarVenta.Show();
            this.Hide();
        }


        #endregion


    }
}
