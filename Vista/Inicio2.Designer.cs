namespace TiendaMascota_v2.Vista
{
    partial class Inicio2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio2));
            this.salir = new System.Windows.Forms.Button();
            this.tabUsuarios = new System.Windows.Forms.TabPage();
            this.lblSinPermisos = new System.Windows.Forms.Label();
            this.lblErrorClickEditarUsuario = new System.Windows.Forms.Label();
            this.btnEditarUsuario = new System.Windows.Forms.Button();
            this.grillaUsuarios = new System.Windows.Forms.DataGridView();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblErrorClickEditarAnimal = new System.Windows.Forms.Label();
            this.btnEditarAnimal = new System.Windows.Forms.Button();
            this.btnEliminarAnimal = new System.Windows.Forms.Button();
            this.grillaAnimales = new System.Windows.Forms.DataGridView();
            this.btnAgregarAnimal = new System.Windows.Forms.Button();
            this.tabPageCategorias = new System.Windows.Forms.TabPage();
            this.lblErrorClickEditarCat = new System.Windows.Forms.Label();
            this.btnEditarCategoria = new System.Windows.Forms.Button();
            this.btnEliminarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.grillaCategorias = new System.Windows.Forms.DataGridView();
            this.tabPageProductos = new System.Windows.Forms.TabPage();
            this.btn_FirstPage = new System.Windows.Forms.Button();
            this.btn_last_page = new System.Windows.Forms.Button();
            this.btn_prev_page = new System.Windows.Forms.Button();
            this.btn_next_page = new System.Windows.Forms.Button();
            this.btn_actual_page = new System.Windows.Forms.Button();
            this.boxPaginacion = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label_paginacion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCat = new System.Windows.Forms.Label();
            this.filtroNombre = new System.Windows.Forms.TextBox();
            this.VaciarFiltros = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.boxCategorias = new System.Windows.Forms.ComboBox();
            this.lblErrorClickEditar = new System.Windows.Forms.Label();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.tabGeneral = new System.Windows.Forms.TabControl();
            this.tabVentas = new System.Windows.Forms.TabPage();
            this.btnEditarVenta = new System.Windows.Forms.Button();
            this.btnEliminarVenta = new System.Windows.Forms.Button();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.grillaVentas = new System.Windows.Forms.DataGridView();
            this.tabClientes = new System.Windows.Forms.TabPage();
            this.grillaClientes = new System.Windows.Forms.DataGridView();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.btnEliminarCliente = new System.Windows.Forms.Button();
            this.tabProveedores = new System.Windows.Forms.TabPage();
            this.grillaProveedores = new System.Windows.Forms.DataGridView();
            this.btnEditarProveedor = new System.Windows.Forms.Button();
            this.btnAgregarProveedor = new System.Windows.Forms.Button();
            this.btnEliminarProveedor = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Conexion = new System.Windows.Forms.Label();
            this.imagen_usuario = new System.Windows.Forms.PictureBox();
            this.nombre_usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Petshop = new System.Windows.Forms.Label();
            this.Disconnect = new System.Windows.Forms.Button();
            this.lblErrorClickEditarVenta = new System.Windows.Forms.Label();
            this.lblErrorClickEditarCliente = new System.Windows.Forms.Label();
            this.lblErrorClickEditarProv = new System.Windows.Forms.Label();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAnimales)).BeginInit();
            this.tabPageCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCategorias)).BeginInit();
            this.tabPageProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            this.tabGeneral.SuspendLayout();
            this.tabVentas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVentas)).BeginInit();
            this.tabClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).BeginInit();
            this.tabProveedores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(12, 651);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 5;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // tabUsuarios
            // 
            this.tabUsuarios.Controls.Add(this.lblSinPermisos);
            this.tabUsuarios.Controls.Add(this.lblErrorClickEditarUsuario);
            this.tabUsuarios.Controls.Add(this.btnEditarUsuario);
            this.tabUsuarios.Controls.Add(this.grillaUsuarios);
            this.tabUsuarios.Controls.Add(this.btnEliminarUsuario);
            this.tabUsuarios.Controls.Add(this.btnAgregarUsuario);
            this.tabUsuarios.Location = new System.Drawing.Point(4, 22);
            this.tabUsuarios.Name = "tabUsuarios";
            this.tabUsuarios.Padding = new System.Windows.Forms.Padding(3);
            this.tabUsuarios.Size = new System.Drawing.Size(896, 479);
            this.tabUsuarios.TabIndex = 4;
            this.tabUsuarios.Text = "Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // lblSinPermisos
            // 
            this.lblSinPermisos.AutoSize = true;
            this.lblSinPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinPermisos.ForeColor = System.Drawing.Color.Red;
            this.lblSinPermisos.Location = new System.Drawing.Point(306, 217);
            this.lblSinPermisos.Name = "lblSinPermisos";
            this.lblSinPermisos.Size = new System.Drawing.Size(312, 16);
            this.lblSinPermisos.TabIndex = 18;
            this.lblSinPermisos.Text = "No posee permisos para ver el listado de usuarios.";
            // 
            // lblErrorClickEditarUsuario
            // 
            this.lblErrorClickEditarUsuario.AutoSize = true;
            this.lblErrorClickEditarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorClickEditarUsuario.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClickEditarUsuario.Location = new System.Drawing.Point(7, 371);
            this.lblErrorClickEditarUsuario.Name = "lblErrorClickEditarUsuario";
            this.lblErrorClickEditarUsuario.Size = new System.Drawing.Size(247, 16);
            this.lblErrorClickEditarUsuario.TabIndex = 17;
            this.lblErrorClickEditarUsuario.Text = "Debe seleccionar un renglón para editar";
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(713, 386);
            this.btnEditarUsuario.Name = "btnEditarUsuario";
            this.btnEditarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEditarUsuario.TabIndex = 14;
            this.btnEditarUsuario.Text = "Editar";
            this.btnEditarUsuario.UseVisualStyleBackColor = true;
            this.btnEditarUsuario.Click += new System.EventHandler(this.btnEditarUsuario_Click);
            // 
            // grillaUsuarios
            // 
            this.grillaUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaUsuarios.Location = new System.Drawing.Point(3, 59);
            this.grillaUsuarios.Name = "grillaUsuarios";
            this.grillaUsuarios.Size = new System.Drawing.Size(890, 309);
            this.grillaUsuarios.TabIndex = 13;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(632, 386);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUsuario.TabIndex = 12;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(794, 386);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarUsuario.TabIndex = 11;
            this.btnAgregarUsuario.Text = "Agregar";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblErrorClickEditarAnimal);
            this.tabPage1.Controls.Add(this.btnEditarAnimal);
            this.tabPage1.Controls.Add(this.btnEliminarAnimal);
            this.tabPage1.Controls.Add(this.grillaAnimales);
            this.tabPage1.Controls.Add(this.btnAgregarAnimal);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(896, 479);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Animales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblErrorClickEditarAnimal
            // 
            this.lblErrorClickEditarAnimal.AutoSize = true;
            this.lblErrorClickEditarAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorClickEditarAnimal.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClickEditarAnimal.Location = new System.Drawing.Point(7, 371);
            this.lblErrorClickEditarAnimal.Name = "lblErrorClickEditarAnimal";
            this.lblErrorClickEditarAnimal.Size = new System.Drawing.Size(247, 16);
            this.lblErrorClickEditarAnimal.TabIndex = 16;
            this.lblErrorClickEditarAnimal.Text = "Debe seleccionar un renglón para editar";
            // 
            // btnEditarAnimal
            // 
            this.btnEditarAnimal.Location = new System.Drawing.Point(713, 386);
            this.btnEditarAnimal.Name = "btnEditarAnimal";
            this.btnEditarAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnEditarAnimal.TabIndex = 11;
            this.btnEditarAnimal.Text = "Editar";
            this.btnEditarAnimal.UseVisualStyleBackColor = true;
            this.btnEditarAnimal.Click += new System.EventHandler(this.btnEditarAnimal_Click);
            // 
            // btnEliminarAnimal
            // 
            this.btnEliminarAnimal.Location = new System.Drawing.Point(632, 386);
            this.btnEliminarAnimal.Name = "btnEliminarAnimal";
            this.btnEliminarAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarAnimal.TabIndex = 9;
            this.btnEliminarAnimal.Text = "Eliminar";
            this.btnEliminarAnimal.UseVisualStyleBackColor = true;
            this.btnEliminarAnimal.Click += new System.EventHandler(this.btnEliminarAnimal_Click);
            // 
            // grillaAnimales
            // 
            this.grillaAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAnimales.Location = new System.Drawing.Point(3, 59);
            this.grillaAnimales.Name = "grillaAnimales";
            this.grillaAnimales.Size = new System.Drawing.Size(890, 309);
            this.grillaAnimales.TabIndex = 7;
            // 
            // btnAgregarAnimal
            // 
            this.btnAgregarAnimal.Location = new System.Drawing.Point(794, 386);
            this.btnAgregarAnimal.Name = "btnAgregarAnimal";
            this.btnAgregarAnimal.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarAnimal.TabIndex = 6;
            this.btnAgregarAnimal.Text = "Agregar";
            this.btnAgregarAnimal.UseVisualStyleBackColor = true;
            this.btnAgregarAnimal.Click += new System.EventHandler(this.btnAgregarAnimal_Click);
            // 
            // tabPageCategorias
            // 
            this.tabPageCategorias.Controls.Add(this.lblErrorClickEditarCat);
            this.tabPageCategorias.Controls.Add(this.btnEditarCategoria);
            this.tabPageCategorias.Controls.Add(this.btnEliminarCategoria);
            this.tabPageCategorias.Controls.Add(this.btnAgregarCategoria);
            this.tabPageCategorias.Controls.Add(this.grillaCategorias);
            this.tabPageCategorias.Location = new System.Drawing.Point(4, 22);
            this.tabPageCategorias.Name = "tabPageCategorias";
            this.tabPageCategorias.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategorias.Size = new System.Drawing.Size(896, 479);
            this.tabPageCategorias.TabIndex = 1;
            this.tabPageCategorias.Text = "Categorias";
            this.tabPageCategorias.UseVisualStyleBackColor = true;
            // 
            // lblErrorClickEditarCat
            // 
            this.lblErrorClickEditarCat.AutoSize = true;
            this.lblErrorClickEditarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorClickEditarCat.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClickEditarCat.Location = new System.Drawing.Point(7, 371);
            this.lblErrorClickEditarCat.Name = "lblErrorClickEditarCat";
            this.lblErrorClickEditarCat.Size = new System.Drawing.Size(247, 16);
            this.lblErrorClickEditarCat.TabIndex = 14;
            this.lblErrorClickEditarCat.Text = "Debe seleccionar un renglón para editar";
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Location = new System.Drawing.Point(713, 386);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCategoria.TabIndex = 8;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(632, 386);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCategoria.TabIndex = 7;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(794, 386);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCategoria.TabIndex = 6;
            this.btnAgregarCategoria.Text = "Agregar";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // grillaCategorias
            // 
            this.grillaCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCategorias.Location = new System.Drawing.Point(3, 59);
            this.grillaCategorias.Name = "grillaCategorias";
            this.grillaCategorias.Size = new System.Drawing.Size(890, 308);
            this.grillaCategorias.TabIndex = 2;
            // 
            // tabPageProductos
            // 
            this.tabPageProductos.Controls.Add(this.btn_FirstPage);
            this.tabPageProductos.Controls.Add(this.btn_last_page);
            this.tabPageProductos.Controls.Add(this.btn_prev_page);
            this.tabPageProductos.Controls.Add(this.btn_next_page);
            this.tabPageProductos.Controls.Add(this.btn_actual_page);
            this.tabPageProductos.Controls.Add(this.boxPaginacion);
            this.tabPageProductos.Controls.Add(this.label5);
            this.tabPageProductos.Controls.Add(this.label_paginacion);
            this.tabPageProductos.Controls.Add(this.label6);
            this.tabPageProductos.Controls.Add(this.lblCat);
            this.tabPageProductos.Controls.Add(this.filtroNombre);
            this.tabPageProductos.Controls.Add(this.VaciarFiltros);
            this.tabPageProductos.Controls.Add(this.comboBox2);
            this.tabPageProductos.Controls.Add(this.boxCategorias);
            this.tabPageProductos.Controls.Add(this.lblErrorClickEditar);
            this.tabPageProductos.Controls.Add(this.btnEditarProducto);
            this.tabPageProductos.Controls.Add(this.btnAgregarProducto);
            this.tabPageProductos.Controls.Add(this.btnEliminarProducto);
            this.tabPageProductos.Controls.Add(this.grillaProductos);
            this.tabPageProductos.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductos.Name = "tabPageProductos";
            this.tabPageProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductos.Size = new System.Drawing.Size(896, 479);
            this.tabPageProductos.TabIndex = 0;
            this.tabPageProductos.Text = "Productos";
            this.tabPageProductos.UseVisualStyleBackColor = true;
            // 
            // btn_FirstPage
            // 
            this.btn_FirstPage.Location = new System.Drawing.Point(349, 386);
            this.btn_FirstPage.Name = "btn_FirstPage";
            this.btn_FirstPage.Size = new System.Drawing.Size(43, 23);
            this.btn_FirstPage.TabIndex = 64;
            this.btn_FirstPage.Text = "<<";
            this.btn_FirstPage.UseVisualStyleBackColor = true;
            this.btn_FirstPage.Click += new System.EventHandler(this.btn_FirstPage_Click);
            // 
            // btn_last_page
            // 
            this.btn_last_page.Location = new System.Drawing.Point(531, 386);
            this.btn_last_page.Name = "btn_last_page";
            this.btn_last_page.Size = new System.Drawing.Size(40, 23);
            this.btn_last_page.TabIndex = 63;
            this.btn_last_page.Text = ">>";
            this.btn_last_page.UseVisualStyleBackColor = true;
            this.btn_last_page.Click += new System.EventHandler(this.btn_last_page_Click);
            // 
            // btn_prev_page
            // 
            this.btn_prev_page.Location = new System.Drawing.Point(398, 386);
            this.btn_prev_page.Name = "btn_prev_page";
            this.btn_prev_page.Size = new System.Drawing.Size(30, 23);
            this.btn_prev_page.TabIndex = 62;
            this.btn_prev_page.Text = "<";
            this.btn_prev_page.UseVisualStyleBackColor = true;
            this.btn_prev_page.Click += new System.EventHandler(this.btn_prev_page_Click);
            // 
            // btn_next_page
            // 
            this.btn_next_page.Location = new System.Drawing.Point(495, 386);
            this.btn_next_page.Name = "btn_next_page";
            this.btn_next_page.Size = new System.Drawing.Size(27, 23);
            this.btn_next_page.TabIndex = 61;
            this.btn_next_page.Text = ">";
            this.btn_next_page.UseVisualStyleBackColor = true;
            this.btn_next_page.Click += new System.EventHandler(this.btn_next_page_Click);
            // 
            // btn_actual_page
            // 
            this.btn_actual_page.Location = new System.Drawing.Point(448, 386);
            this.btn_actual_page.Name = "btn_actual_page";
            this.btn_actual_page.Size = new System.Drawing.Size(30, 23);
            this.btn_actual_page.TabIndex = 60;
            this.btn_actual_page.UseVisualStyleBackColor = true;
            // 
            // boxPaginacion
            // 
            this.boxPaginacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxPaginacion.FormattingEnabled = true;
            this.boxPaginacion.Location = new System.Drawing.Point(87, 431);
            this.boxPaginacion.Name = "boxPaginacion";
            this.boxPaginacion.Size = new System.Drawing.Size(37, 21);
            this.boxPaginacion.TabIndex = 57;
            this.boxPaginacion.SelectedIndexChanged += new System.EventHandler(this.boxPaginacion_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(7, 431);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 58;
            this.label5.Text = "Paginación";
            // 
            // label_paginacion
            // 
            this.label_paginacion.AutoSize = true;
            this.label_paginacion.BackColor = System.Drawing.Color.White;
            this.label_paginacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_paginacion.Location = new System.Drawing.Point(7, 405);
            this.label_paginacion.Name = "label_paginacion";
            this.label_paginacion.Size = new System.Drawing.Size(117, 13);
            this.label_paginacion.TabIndex = 59;
            this.label_paginacion.Text = "Mostrando 1 - 10 de 40";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(726, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 56;
            this.label6.Text = "Activo";
            // 
            // lblCat
            // 
            this.lblCat.AutoSize = true;
            this.lblCat.ForeColor = System.Drawing.Color.Black;
            this.lblCat.Location = new System.Drawing.Point(616, 11);
            this.lblCat.Name = "lblCat";
            this.lblCat.Size = new System.Drawing.Size(52, 13);
            this.lblCat.TabIndex = 55;
            this.lblCat.Text = "Categoria";
            // 
            // filtroNombre
            // 
            this.filtroNombre.Location = new System.Drawing.Point(487, 28);
            this.filtroNombre.Name = "filtroNombre";
            this.filtroNombre.Size = new System.Drawing.Size(84, 20);
            this.filtroNombre.TabIndex = 54;
            this.filtroNombre.TextChanged += new System.EventHandler(this.filtroNombre_TextChanged);
            // 
            // VaciarFiltros
            // 
            this.VaciarFiltros.BackColor = System.Drawing.SystemColors.HighlightText;
            this.VaciarFiltros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.VaciarFiltros.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.VaciarFiltros.Location = new System.Drawing.Point(807, 29);
            this.VaciarFiltros.Name = "VaciarFiltros";
            this.VaciarFiltros.Size = new System.Drawing.Size(83, 23);
            this.VaciarFiltros.TabIndex = 53;
            this.VaciarFiltros.Text = "reiniciar filtros";
            this.VaciarFiltros.UseVisualStyleBackColor = false;
            this.VaciarFiltros.Click += new System.EventHandler(this.VaciarFiltros_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(703, 29);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(84, 21);
            this.comboBox2.TabIndex = 52;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // boxCategorias
            // 
            this.boxCategorias.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxCategorias.FormattingEnabled = true;
            this.boxCategorias.Location = new System.Drawing.Point(598, 28);
            this.boxCategorias.Name = "boxCategorias";
            this.boxCategorias.Size = new System.Drawing.Size(84, 21);
            this.boxCategorias.TabIndex = 51;
            this.boxCategorias.SelectedIndexChanged += new System.EventHandler(this.boxCategorias_SelectedIndexChanged);
            // 
            // lblErrorClickEditar
            // 
            this.lblErrorClickEditar.AutoSize = true;
            this.lblErrorClickEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorClickEditar.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClickEditar.Location = new System.Drawing.Point(7, 371);
            this.lblErrorClickEditar.Name = "lblErrorClickEditar";
            this.lblErrorClickEditar.Size = new System.Drawing.Size(247, 16);
            this.lblErrorClickEditar.TabIndex = 13;
            this.lblErrorClickEditar.Text = "Debe seleccionar un renglón para editar";
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Location = new System.Drawing.Point(713, 386);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProducto.TabIndex = 12;
            this.btnEditarProducto.Text = "Editar";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(794, 386);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProducto.TabIndex = 11;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(632, 386);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 10;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = true;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // grillaProductos
            // 
            this.grillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProductos.Location = new System.Drawing.Point(3, 59);
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.Size = new System.Drawing.Size(890, 309);
            this.grillaProductos.TabIndex = 3;
            // 
            // tabGeneral
            // 
            this.tabGeneral.Controls.Add(this.tabPageProductos);
            this.tabGeneral.Controls.Add(this.tabPageCategorias);
            this.tabGeneral.Controls.Add(this.tabPage1);
            this.tabGeneral.Controls.Add(this.tabUsuarios);
            this.tabGeneral.Controls.Add(this.tabVentas);
            this.tabGeneral.Controls.Add(this.tabClientes);
            this.tabGeneral.Controls.Add(this.tabProveedores);
            this.tabGeneral.Location = new System.Drawing.Point(76, 117);
            this.tabGeneral.Name = "tabGeneral";
            this.tabGeneral.SelectedIndex = 0;
            this.tabGeneral.Size = new System.Drawing.Size(904, 505);
            this.tabGeneral.TabIndex = 0;
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.lblErrorClickEditarVenta);
            this.tabVentas.Controls.Add(this.btnEditarVenta);
            this.tabVentas.Controls.Add(this.btnEliminarVenta);
            this.tabVentas.Controls.Add(this.btnAgregarVenta);
            this.tabVentas.Controls.Add(this.grillaVentas);
            this.tabVentas.Location = new System.Drawing.Point(4, 22);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.Padding = new System.Windows.Forms.Padding(3);
            this.tabVentas.Size = new System.Drawing.Size(896, 479);
            this.tabVentas.TabIndex = 5;
            this.tabVentas.Text = "Ventas";
            this.tabVentas.UseVisualStyleBackColor = true;
            // 
            // btnEditarVenta
            // 
            this.btnEditarVenta.Location = new System.Drawing.Point(713, 386);
            this.btnEditarVenta.Name = "btnEditarVenta";
            this.btnEditarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnEditarVenta.TabIndex = 17;
            this.btnEditarVenta.Text = "Editar";
            this.btnEditarVenta.UseVisualStyleBackColor = true;
            this.btnEditarVenta.Click += new System.EventHandler(this.btnEditarVenta_Click);
            // 
            // btnEliminarVenta
            // 
            this.btnEliminarVenta.Location = new System.Drawing.Point(632, 386);
            this.btnEliminarVenta.Name = "btnEliminarVenta";
            this.btnEliminarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarVenta.TabIndex = 16;
            this.btnEliminarVenta.Text = "Eliminar";
            this.btnEliminarVenta.UseVisualStyleBackColor = true;
            this.btnEliminarVenta.Click += new System.EventHandler(this.btnEliminarVenta_Click);
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(794, 386);
            this.btnAgregarVenta.Name = "btnAgregarVenta";
            this.btnAgregarVenta.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarVenta.TabIndex = 15;
            this.btnAgregarVenta.Text = "Agregar";
            this.btnAgregarVenta.UseVisualStyleBackColor = true;
            this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
            // 
            // grillaVentas
            // 
            this.grillaVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaVentas.Location = new System.Drawing.Point(3, 59);
            this.grillaVentas.Name = "grillaVentas";
            this.grillaVentas.Size = new System.Drawing.Size(890, 309);
            this.grillaVentas.TabIndex = 14;
            // 
            // tabClientes
            // 
            this.tabClientes.Controls.Add(this.lblErrorClickEditarCliente);
            this.tabClientes.Controls.Add(this.grillaClientes);
            this.tabClientes.Controls.Add(this.btnEditarCliente);
            this.tabClientes.Controls.Add(this.btnAgregarCliente);
            this.tabClientes.Controls.Add(this.btnEliminarCliente);
            this.tabClientes.Location = new System.Drawing.Point(4, 22);
            this.tabClientes.Name = "tabClientes";
            this.tabClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabClientes.Size = new System.Drawing.Size(896, 479);
            this.tabClientes.TabIndex = 6;
            this.tabClientes.Text = "Clientes";
            this.tabClientes.UseVisualStyleBackColor = true;
            // 
            // grillaClientes
            // 
            this.grillaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaClientes.Location = new System.Drawing.Point(3, 59);
            this.grillaClientes.Name = "grillaClientes";
            this.grillaClientes.Size = new System.Drawing.Size(890, 309);
            this.grillaClientes.TabIndex = 16;
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(713, 386);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCliente.TabIndex = 15;
            this.btnEditarCliente.Text = "Editar";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Location = new System.Drawing.Point(794, 386);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCliente.TabIndex = 14;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.Location = new System.Drawing.Point(632, 386);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCliente.TabIndex = 13;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            // 
            // tabProveedores
            // 
            this.tabProveedores.Controls.Add(this.lblErrorClickEditarProv);
            this.tabProveedores.Controls.Add(this.grillaProveedores);
            this.tabProveedores.Controls.Add(this.btnEditarProveedor);
            this.tabProveedores.Controls.Add(this.btnAgregarProveedor);
            this.tabProveedores.Controls.Add(this.btnEliminarProveedor);
            this.tabProveedores.Location = new System.Drawing.Point(4, 22);
            this.tabProveedores.Name = "tabProveedores";
            this.tabProveedores.Padding = new System.Windows.Forms.Padding(3);
            this.tabProveedores.Size = new System.Drawing.Size(896, 479);
            this.tabProveedores.TabIndex = 7;
            this.tabProveedores.Text = "Proveedores";
            this.tabProveedores.UseVisualStyleBackColor = true;
            // 
            // grillaProveedores
            // 
            this.grillaProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProveedores.Location = new System.Drawing.Point(3, 59);
            this.grillaProveedores.Name = "grillaProveedores";
            this.grillaProveedores.Size = new System.Drawing.Size(890, 309);
            this.grillaProveedores.TabIndex = 17;
            // 
            // btnEditarProveedor
            // 
            this.btnEditarProveedor.Location = new System.Drawing.Point(713, 386);
            this.btnEditarProveedor.Name = "btnEditarProveedor";
            this.btnEditarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProveedor.TabIndex = 15;
            this.btnEditarProveedor.Text = "Editar";
            this.btnEditarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnAgregarProveedor
            // 
            this.btnAgregarProveedor.Location = new System.Drawing.Point(794, 386);
            this.btnAgregarProveedor.Name = "btnAgregarProveedor";
            this.btnAgregarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProveedor.TabIndex = 14;
            this.btnAgregarProveedor.Text = "Agregar";
            this.btnAgregarProveedor.UseVisualStyleBackColor = true;
            // 
            // btnEliminarProveedor
            // 
            this.btnEliminarProveedor.Location = new System.Drawing.Point(632, 386);
            this.btnEliminarProveedor.Name = "btnEliminarProveedor";
            this.btnEliminarProveedor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProveedor.TabIndex = 13;
            this.btnEliminarProveedor.Text = "Eliminar";
            this.btnEliminarProveedor.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.Conexion);
            this.panel1.Controls.Add(this.imagen_usuario);
            this.panel1.Controls.Add(this.nombre_usuario);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Petshop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 96);
            this.panel1.TabIndex = 6;
            // 
            // Conexion
            // 
            this.Conexion.AutoSize = true;
            this.Conexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conexion.Location = new System.Drawing.Point(869, 55);
            this.Conexion.Name = "Conexion";
            this.Conexion.Size = new System.Drawing.Size(115, 29);
            this.Conexion.TabIndex = 4;
            this.Conexion.Text = "Conexion";
            // 
            // imagen_usuario
            // 
            this.imagen_usuario.Image = ((System.Drawing.Image)(resources.GetObject("imagen_usuario.Image")));
            this.imagen_usuario.Location = new System.Drawing.Point(1016, 19);
            this.imagen_usuario.Name = "imagen_usuario";
            this.imagen_usuario.Size = new System.Drawing.Size(71, 65);
            this.imagen_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen_usuario.TabIndex = 3;
            this.imagen_usuario.TabStop = false;
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.AutoSize = true;
            this.nombre_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_usuario.Location = new System.Drawing.Point(869, 27);
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.Size = new System.Drawing.Size(101, 29);
            this.nombre_usuario.TabIndex = 2;
            this.nombre_usuario.Text = "Nombre";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(96, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Petshop
            // 
            this.Petshop.AutoSize = true;
            this.Petshop.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Petshop.Location = new System.Drawing.Point(102, 27);
            this.Petshop.Name = "Petshop";
            this.Petshop.Size = new System.Drawing.Size(162, 42);
            this.Petshop.TabIndex = 0;
            this.Petshop.Text = "PetShop";
            // 
            // Disconnect
            // 
            this.Disconnect.Location = new System.Drawing.Point(1016, 102);
            this.Disconnect.Name = "Disconnect";
            this.Disconnect.Size = new System.Drawing.Size(75, 23);
            this.Disconnect.TabIndex = 8;
            this.Disconnect.Text = "Disconnect";
            this.Disconnect.UseVisualStyleBackColor = true;
            this.Disconnect.Click += new System.EventHandler(this.Disconnect_Click);
            // 
            // lblErrorClickEditarVenta
            // 
            this.lblErrorClickEditarVenta.AutoSize = true;
            this.lblErrorClickEditarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorClickEditarVenta.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClickEditarVenta.Location = new System.Drawing.Point(6, 371);
            this.lblErrorClickEditarVenta.Name = "lblErrorClickEditarVenta";
            this.lblErrorClickEditarVenta.Size = new System.Drawing.Size(247, 16);
            this.lblErrorClickEditarVenta.TabIndex = 18;
            this.lblErrorClickEditarVenta.Text = "Debe seleccionar un renglón para editar";
            // 
            // lblErrorClickEditarCliente
            // 
            this.lblErrorClickEditarCliente.AutoSize = true;
            this.lblErrorClickEditarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorClickEditarCliente.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClickEditarCliente.Location = new System.Drawing.Point(6, 371);
            this.lblErrorClickEditarCliente.Name = "lblErrorClickEditarCliente";
            this.lblErrorClickEditarCliente.Size = new System.Drawing.Size(247, 16);
            this.lblErrorClickEditarCliente.TabIndex = 18;
            this.lblErrorClickEditarCliente.Text = "Debe seleccionar un renglón para editar";
            // 
            // lblErrorClickEditarProv
            // 
            this.lblErrorClickEditarProv.AutoSize = true;
            this.lblErrorClickEditarProv.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorClickEditarProv.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClickEditarProv.Location = new System.Drawing.Point(6, 371);
            this.lblErrorClickEditarProv.Name = "lblErrorClickEditarProv";
            this.lblErrorClickEditarProv.Size = new System.Drawing.Size(247, 16);
            this.lblErrorClickEditarProv.TabIndex = 18;
            this.lblErrorClickEditarProv.Text = "Debe seleccionar un renglón para editar";
            // 
            // Inicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1103, 686);
            this.Controls.Add(this.Disconnect);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.tabGeneral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Inicio2";
            this.Text = "PetShop";
            this.Load += new System.EventHandler(this.Inicio2_Load);
            this.tabUsuarios.ResumeLayout(false);
            this.tabUsuarios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAnimales)).EndInit();
            this.tabPageCategorias.ResumeLayout(false);
            this.tabPageCategorias.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCategorias)).EndInit();
            this.tabPageProductos.ResumeLayout(false);
            this.tabPageProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).EndInit();
            this.tabGeneral.ResumeLayout(false);
            this.tabVentas.ResumeLayout(false);
            this.tabVentas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVentas)).EndInit();
            this.tabClientes.ResumeLayout(false);
            this.tabClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaClientes)).EndInit();
            this.tabProveedores.ResumeLayout(false);
            this.tabProveedores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProveedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_usuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.TabPage tabUsuarios;
        private System.Windows.Forms.Label lblErrorClickEditarUsuario;
        private System.Windows.Forms.Button btnEditarUsuario;
        private System.Windows.Forms.DataGridView grillaUsuarios;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lblErrorClickEditarAnimal;
        private System.Windows.Forms.Button btnEditarAnimal;
        private System.Windows.Forms.Button btnEliminarAnimal;
        private System.Windows.Forms.DataGridView grillaAnimales;
        private System.Windows.Forms.Button btnAgregarAnimal;
        private System.Windows.Forms.TabPage tabPageCategorias;
        private System.Windows.Forms.Label lblErrorClickEditarCat;
        private System.Windows.Forms.Button btnEditarCategoria;
        private System.Windows.Forms.Button btnEliminarCategoria;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.DataGridView grillaCategorias;
        private System.Windows.Forms.TabPage tabPageProductos;
        private System.Windows.Forms.Label lblErrorClickEditar;
        private System.Windows.Forms.Button btnEditarProducto;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.DataGridView grillaProductos;
        private System.Windows.Forms.TabControl tabGeneral;
        private System.Windows.Forms.TabPage tabVentas;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.DataGridView grillaVentas;
        private System.Windows.Forms.Label lblSinPermisos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Petshop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imagen_usuario;
        private System.Windows.Forms.Label nombre_usuario;
        private System.Windows.Forms.Label Conexion;
        private System.Windows.Forms.Button btn_FirstPage;
        private System.Windows.Forms.Button btn_last_page;
        private System.Windows.Forms.Button btn_prev_page;
        private System.Windows.Forms.Button btn_next_page;
        private System.Windows.Forms.Button btn_actual_page;
        private System.Windows.Forms.ComboBox boxPaginacion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label_paginacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCat;
        private System.Windows.Forms.TextBox filtroNombre;
        private System.Windows.Forms.Button VaciarFiltros;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox boxCategorias;
        private System.Windows.Forms.Button Disconnect;
        private System.Windows.Forms.TabPage tabClientes;
        private System.Windows.Forms.TabPage tabProveedores;
        private System.Windows.Forms.Button btnEditarVenta;
        private System.Windows.Forms.Button btnEliminarVenta;
        private System.Windows.Forms.DataGridView grillaClientes;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.Button btnEliminarCliente;
        private System.Windows.Forms.DataGridView grillaProveedores;
        private System.Windows.Forms.Button btnEditarProveedor;
        private System.Windows.Forms.Button btnAgregarProveedor;
        private System.Windows.Forms.Button btnEliminarProveedor;
        private System.Windows.Forms.Label lblErrorClickEditarVenta;
        private System.Windows.Forms.Label lblErrorClickEditarCliente;
        private System.Windows.Forms.Label lblErrorClickEditarProv;
    }
}