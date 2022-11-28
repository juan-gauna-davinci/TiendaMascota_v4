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
        private static Producto filtro = new Producto();
        private List<Producto> Productos_Completo = new List<Producto>();
        private List<Producto> Productos_Filtrado = new List<Producto>();
        private List<Producto> Productos_Paginados = new List<Producto>();

        private List<Venta> Ventas_Completas = new List<Venta>();
        private List<Venta> Ventas_Paginadas = new List<Venta>();

        private static int current = 0;
        private static int paginador = 10;
        private static int total = 0;
        private static int last_pag = 0;
        private static int current_pag = 1;
        public Inicio2()
        {
            InitializeComponent();
        
        }

        private void Inicio2_Load(object sender, EventArgs e)
        {
            InicializarNombreUsuario();
            InicializarComponentes();
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
                btnEliminarUsuario.Show();
                btnEditarUsuario.Show();
                btnAgregarUsuario.Show();
            }
            else
            {
                this.lblSinPermisos.Visible = true;
                btnEliminarUsuario.Hide();
                btnEditarUsuario.Hide();
                btnAgregarUsuario.Hide();
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

                var imageConverter = new ImageConverter();
                Bitmap img;
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

        private void InicializarComponentes()
        {
            Paginar(Productos_Completo);
            llenarBoxPaginacion();
        }

        private void Paginar(List<Producto> prodMostrar)
        {
            Productos_Paginados = prodMostrar.Skip(current).Take(paginador).ToList();
            ProductoControlador.ObtenerProductosPaginado(Productos_Paginados);
            label_paginacion.Text = "Mostrando " + (current + 1) + " - " + (current + paginador) + "de " + total;


            if (current_pag == 1)
            {
                btn_FirstPage.Hide();
                btn_prev_page.Hide();

            }
            else
            {
                btn_FirstPage.Show();
                btn_FirstPage.Text = "1";
                btn_prev_page.Show();
                btn_prev_page.Text = (current_pag - 1).ToString();
            }

            if (current_pag == last_pag)
            {
                btn_last_page.Hide();
                btn_next_page.Hide();
            }
            else
            {
                btn_last_page.Show();
                btn_next_page.Show();
            }

            if (btn_FirstPage.Text == btn_prev_page.Text)
            {
                btn_FirstPage.Hide();
            }

            if (btn_last_page.Text == btn_next_page.Text)
            {
                btn_last_page.Hide();
            }

            btn_next_page.Text = (current_pag + 1).ToString();
            btn_prev_page.Text = (current_pag - 1).ToString();
            btn_actual_page.Text = (current_pag).ToString();

        }

        private void btn_next_page_Click(object sender, EventArgs e)
        {
            current = current + paginador;
            current_pag = (current_pag + 1);
            btn_actual_page.Text = current_pag.ToString();
            Paginar(Productos_Filtrado);
        }

        private void btn_last_page_Click(object sender, EventArgs e)
        {
            current = last_pag + paginador;
            current_pag = last_pag;
            btn_actual_page.Text = current_pag.ToString();
            Paginar(Productos_Filtrado);
        }

        private void btn_prev_page_Click(object sender, EventArgs e)
        {
            current = current - paginador;
            current_pag = (current_pag - 1);
            btn_actual_page.Text = current_pag.ToString();

            Paginar(Productos_Filtrado);
        }

        private void btn_FirstPage_Click(object sender, EventArgs e)
        {
            current = 0;
            current_pag = 1;
            Paginar(Productos_Filtrado);
            btn_actual_page.Text = current_pag.ToString();
        }

        private void VaciarFiltros_Click(object sender, EventArgs e)
        {
            boxCategorias.SelectedItem = null;
            filtroNombre.Text = null;
            comboBox2.Text = null;

            filtro.Nombre = null;
            filtro.IdCategoria = 0;

            lblCat.Text = "Categoria";

            Productos_Filtrado = Productos_Completo;

            Paginar(Productos_Completo);
            btn_last_page.Show();
            btn_next_page.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                filtro.Activo = bool.Parse(comboBox2.Text);
                filtrar();
            }
        }

        private void boxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (boxCategorias.SelectedItem != null)
            {
                Categoria seleccionado = CategoriaControlador.ObtenerCategoriaPorNombre(boxCategorias.SelectedItem.ToString());
                //filtro.IdCategoria = CategoriaControlador.ObtenerCategoriaPorId(seleccionado);
                lblCat.Text = seleccionado.Nombre;
                filtrar();
            }

        }

        private void filtroNombre_TextChanged(object sender, EventArgs e)
        {
            string nombreFiltrar = filtroNombre.Text.ToString().ToLower();

            if (string.IsNullOrEmpty(filtroNombre.Text))
            {
                filtro.Nombre = null;
            }
            else
            {
                filtro.Nombre = nombreFiltrar;
                filtrar();
            }
        }

        private void boxPaginacion_SelectedIndexChanged(object sender, EventArgs e)
        {
            paginador = int.Parse(boxPaginacion.SelectedItem.ToString());
            current = 0;
            last_pag = (total / paginador) + 1;
            Paginar(Productos_Filtrado);
        }

        private void filtrar()
        {

            if (filtro.Nombre != null)
            {
                Productos_Filtrado = Productos_Completo.Where(x => x.Nombre.ToLower().Contains(filtro.Nombre)).ToList();
                vaciarCombos();
                llenarCombos();

            }

            if (filtro.IdCategoria != 0)
            {
                Productos_Filtrado = Productos_Filtrado.Where(x => x.IdCategoria == filtro.IdCategoria).ToList();

            }


            if (filtro.Activo != false)
            {
                Productos_Filtrado = Productos_Filtrado.Where(x => x.Activo == filtro.Activo).ToList();
            }

            total = Productos_Filtrado.Count();
            last_pag = (total / paginador) + 1;
            current = 0;
            current_pag = 1;

            Paginar(Productos_Filtrado);

        }
        private void llenarCombos()
        {
            List<Categoria> listCat = new List<Categoria>();
            listCat = CategoriaControlador.ObtenerCategorias().ToList();
            llenarBoxCategorias(listCat);

            llenarBoxPaginacion();
            llenarBoxEstado();
        }
        private void llenarBoxCategorias(List<Categoria> listaCategorias)
        {
            foreach (Categoria cat in listaCategorias)
            {
                if (cat.Activo == true)
                {
                    boxCategorias.Items.Add(cat.Nombre);
                }
            }
        }
        private void vaciarCombos()
        {
            boxCategorias.Items.Clear();
        }
        private void llenarBoxEstado()
        {
            comboBox2.Items.Add("SI");
            comboBox2.Items.Add("NO");
        }
        private void llenarBoxPaginacion()
        {
            boxPaginacion.Items.Add("10");
            boxPaginacion.Items.Add("20");
            boxPaginacion.Items.Add("30");
            boxPaginacion.Items.Add("40");
            boxPaginacion.SelectedItem = "10";
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Close();
            login.Show();
        }

        private void InicializarNombreUsuario()
        {
            nombre_usuario.Text = InicioControlador.UsuarioLogueado.Nombre;
            nombre_usuario.Show();
        }

        private void InicializarConexion()
        {
            // Nos va a mostrar si la conexion a la base de datos es valida o esta desconectado
            // Conexion.Text = 
            // Conexion.show();
        }
    }
}
