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
            this.lblErrorClickEditar = new System.Windows.Forms.Label();
            this.btnEditarProducto = new System.Windows.Forms.Button();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.tabVentas = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAgregarVenta = new System.Windows.Forms.Button();
            this.grillaVentas = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imagen_usuario = new System.Windows.Forms.PictureBox();
            this.nombre_usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Petshop = new System.Windows.Forms.Label();
            this.Conexion = new System.Windows.Forms.Label();
            this.tabUsuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaUsuarios)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAnimales)).BeginInit();
            this.tabPageCategorias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCategorias)).BeginInit();
            this.tabPageProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            this.tabVentas.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grillaVentas)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagen_usuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(12, 544);
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
            this.tabUsuarios.Size = new System.Drawing.Size(768, 369);
            this.tabUsuarios.TabIndex = 4;
            this.tabUsuarios.Text = "Usuarios";
            this.tabUsuarios.UseVisualStyleBackColor = true;
            // 
            // lblSinPermisos
            // 
            this.lblSinPermisos.AutoSize = true;
            this.lblSinPermisos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSinPermisos.ForeColor = System.Drawing.Color.Red;
            this.lblSinPermisos.Location = new System.Drawing.Point(246, 159);
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
            this.lblErrorClickEditarUsuario.Location = new System.Drawing.Point(6, 339);
            this.lblErrorClickEditarUsuario.Name = "lblErrorClickEditarUsuario";
            this.lblErrorClickEditarUsuario.Size = new System.Drawing.Size(247, 16);
            this.lblErrorClickEditarUsuario.TabIndex = 17;
            this.lblErrorClickEditarUsuario.Text = "Debe seleccionar un renglón para editar";
            // 
            // btnEditarUsuario
            // 
            this.btnEditarUsuario.Location = new System.Drawing.Point(578, 336);
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
            this.grillaUsuarios.Location = new System.Drawing.Point(6, 6);
            this.grillaUsuarios.Name = "grillaUsuarios";
            this.grillaUsuarios.Size = new System.Drawing.Size(756, 324);
            this.grillaUsuarios.TabIndex = 13;
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(460, 336);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarUsuario.TabIndex = 12;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(687, 336);
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
            this.tabPage1.Size = new System.Drawing.Size(768, 369);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Animales";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblErrorClickEditarAnimal
            // 
            this.lblErrorClickEditarAnimal.AutoSize = true;
            this.lblErrorClickEditarAnimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorClickEditarAnimal.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClickEditarAnimal.Location = new System.Drawing.Point(6, 336);
            this.lblErrorClickEditarAnimal.Name = "lblErrorClickEditarAnimal";
            this.lblErrorClickEditarAnimal.Size = new System.Drawing.Size(247, 16);
            this.lblErrorClickEditarAnimal.TabIndex = 16;
            this.lblErrorClickEditarAnimal.Text = "Debe seleccionar un renglón para editar";
            // 
            // btnEditarAnimal
            // 
            this.btnEditarAnimal.Location = new System.Drawing.Point(556, 336);
            this.btnEditarAnimal.Name = "btnEditarAnimal";
            this.btnEditarAnimal.Size = new System.Drawing.Size(87, 23);
            this.btnEditarAnimal.TabIndex = 11;
            this.btnEditarAnimal.Text = "Editar";
            this.btnEditarAnimal.UseVisualStyleBackColor = true;
            this.btnEditarAnimal.Click += new System.EventHandler(this.btnEditarAnimal_Click);
            // 
            // btnEliminarAnimal
            // 
            this.btnEliminarAnimal.Location = new System.Drawing.Point(435, 336);
            this.btnEliminarAnimal.Name = "btnEliminarAnimal";
            this.btnEliminarAnimal.Size = new System.Drawing.Size(87, 23);
            this.btnEliminarAnimal.TabIndex = 9;
            this.btnEliminarAnimal.Text = "Eliminar";
            this.btnEliminarAnimal.UseVisualStyleBackColor = true;
            this.btnEliminarAnimal.Click += new System.EventHandler(this.btnEliminarAnimal_Click);
            // 
            // grillaAnimales
            // 
            this.grillaAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAnimales.Location = new System.Drawing.Point(6, 6);
            this.grillaAnimales.Name = "grillaAnimales";
            this.grillaAnimales.Size = new System.Drawing.Size(756, 314);
            this.grillaAnimales.TabIndex = 7;
            // 
            // btnAgregarAnimal
            // 
            this.btnAgregarAnimal.Location = new System.Drawing.Point(675, 336);
            this.btnAgregarAnimal.Name = "btnAgregarAnimal";
            this.btnAgregarAnimal.Size = new System.Drawing.Size(87, 23);
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
            this.tabPageCategorias.Size = new System.Drawing.Size(768, 369);
            this.tabPageCategorias.TabIndex = 1;
            this.tabPageCategorias.Text = "Categorias";
            this.tabPageCategorias.UseVisualStyleBackColor = true;
            // 
            // lblErrorClickEditarCat
            // 
            this.lblErrorClickEditarCat.AutoSize = true;
            this.lblErrorClickEditarCat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorClickEditarCat.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClickEditarCat.Location = new System.Drawing.Point(15, 326);
            this.lblErrorClickEditarCat.Name = "lblErrorClickEditarCat";
            this.lblErrorClickEditarCat.Size = new System.Drawing.Size(247, 16);
            this.lblErrorClickEditarCat.TabIndex = 14;
            this.lblErrorClickEditarCat.Text = "Debe seleccionar un renglón para editar";
            // 
            // btnEditarCategoria
            // 
            this.btnEditarCategoria.Location = new System.Drawing.Point(590, 336);
            this.btnEditarCategoria.Name = "btnEditarCategoria";
            this.btnEditarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEditarCategoria.TabIndex = 8;
            this.btnEditarCategoria.Text = "Editar";
            this.btnEditarCategoria.UseVisualStyleBackColor = true;
            this.btnEditarCategoria.Click += new System.EventHandler(this.btnEditarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.Location = new System.Drawing.Point(483, 336);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCategoria.TabIndex = 7;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Location = new System.Drawing.Point(687, 336);
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
            this.grillaCategorias.Location = new System.Drawing.Point(3, 6);
            this.grillaCategorias.Name = "grillaCategorias";
            this.grillaCategorias.Size = new System.Drawing.Size(756, 308);
            this.grillaCategorias.TabIndex = 2;
            // 
            // tabPageProductos
            // 
            this.tabPageProductos.Controls.Add(this.lblErrorClickEditar);
            this.tabPageProductos.Controls.Add(this.btnEditarProducto);
            this.tabPageProductos.Controls.Add(this.btnAgregarProducto);
            this.tabPageProductos.Controls.Add(this.btnEliminarProducto);
            this.tabPageProductos.Controls.Add(this.grillaProductos);
            this.tabPageProductos.Location = new System.Drawing.Point(4, 22);
            this.tabPageProductos.Name = "tabPageProductos";
            this.tabPageProductos.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProductos.Size = new System.Drawing.Size(768, 369);
            this.tabPageProductos.TabIndex = 0;
            this.tabPageProductos.Text = "Productos";
            this.tabPageProductos.UseVisualStyleBackColor = true;
            // 
            // lblErrorClickEditar
            // 
            this.lblErrorClickEditar.AutoSize = true;
            this.lblErrorClickEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblErrorClickEditar.ForeColor = System.Drawing.Color.Red;
            this.lblErrorClickEditar.Location = new System.Drawing.Point(7, 322);
            this.lblErrorClickEditar.Name = "lblErrorClickEditar";
            this.lblErrorClickEditar.Size = new System.Drawing.Size(247, 16);
            this.lblErrorClickEditar.TabIndex = 13;
            this.lblErrorClickEditar.Text = "Debe seleccionar un renglón para editar";
            // 
            // btnEditarProducto
            // 
            this.btnEditarProducto.Location = new System.Drawing.Point(587, 336);
            this.btnEditarProducto.Name = "btnEditarProducto";
            this.btnEditarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProducto.TabIndex = 12;
            this.btnEditarProducto.Text = "Editar";
            this.btnEditarProducto.UseVisualStyleBackColor = true;
            this.btnEditarProducto.Click += new System.EventHandler(this.btnEditarProducto_Click);
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(685, 336);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarProducto.TabIndex = 11;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.Location = new System.Drawing.Point(482, 336);
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
            this.grillaProductos.Location = new System.Drawing.Point(6, 6);
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.Size = new System.Drawing.Size(756, 309);
            this.grillaProductos.TabIndex = 3;
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.tabPageProductos);
            this.tabVentas.Controls.Add(this.tabPageCategorias);
            this.tabVentas.Controls.Add(this.tabPage1);
            this.tabVentas.Controls.Add(this.tabUsuarios);
            this.tabVentas.Controls.Add(this.tabPage3);
            this.tabVentas.Location = new System.Drawing.Point(76, 117);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.SelectedIndex = 0;
            this.tabVentas.Size = new System.Drawing.Size(776, 395);
            this.tabVentas.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAgregarVenta);
            this.tabPage3.Controls.Add(this.grillaVentas);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 369);
            this.tabPage3.TabIndex = 5;
            this.tabPage3.Text = "Ventas";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAgregarVenta
            // 
            this.btnAgregarVenta.Location = new System.Drawing.Point(687, 336);
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
            this.grillaVentas.Location = new System.Drawing.Point(6, 6);
            this.grillaVentas.Name = "grillaVentas";
            this.grillaVentas.Size = new System.Drawing.Size(756, 324);
            this.grillaVentas.TabIndex = 14;
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
            this.panel1.Size = new System.Drawing.Size(943, 96);
            this.panel1.TabIndex = 6;
            // 
            // imagen_usuario
            // 
            this.imagen_usuario.Image = ((System.Drawing.Image)(resources.GetObject("imagen_usuario.Image")));
            this.imagen_usuario.Location = new System.Drawing.Point(860, 18);
            this.imagen_usuario.Name = "imagen_usuario";
            this.imagen_usuario.Size = new System.Drawing.Size(71, 65);
            this.imagen_usuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagen_usuario.TabIndex = 3;
            this.imagen_usuario.TabStop = false;
            // 
            // nombre_usuario
            // 
            this.nombre_usuario.AutoSize = true;
            this.nombre_usuario.Font = new System.Drawing.Font("Caladea", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre_usuario.Location = new System.Drawing.Point(755, 27);
            this.nombre_usuario.Name = "nombre_usuario";
            this.nombre_usuario.Size = new System.Drawing.Size(93, 28);
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
            this.Petshop.Font = new System.Drawing.Font("Caladea", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Petshop.Location = new System.Drawing.Point(102, 27);
            this.Petshop.Name = "Petshop";
            this.Petshop.Size = new System.Drawing.Size(146, 43);
            this.Petshop.TabIndex = 0;
            this.Petshop.Text = "PetShop";
            // 
            // Conexion
            // 
            this.Conexion.AutoSize = true;
            this.Conexion.Font = new System.Drawing.Font("Caladea", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Conexion.Location = new System.Drawing.Point(755, 55);
            this.Conexion.Name = "Conexion";
            this.Conexion.Size = new System.Drawing.Size(104, 28);
            this.Conexion.TabIndex = 4;
            this.Conexion.Text = "Conexion";
            // 
            // Inicio2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(943, 579);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.tabVentas);
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
            this.tabVentas.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grillaVentas)).EndInit();
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
        private System.Windows.Forms.TabControl tabVentas;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.DataGridView grillaVentas;
        private System.Windows.Forms.Label lblSinPermisos;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Petshop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imagen_usuario;
        private System.Windows.Forms.Label nombre_usuario;
        private System.Windows.Forms.Label Conexion;
    }
}