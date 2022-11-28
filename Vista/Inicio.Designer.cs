namespace TiendaMascota_v2
{
    partial class Inicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.botonAgregar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnVerAnimales = new System.Windows.Forms.Button();
            this.botonVerCategorias = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnVerUsr = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "TIENDA DE MASCOTAS";
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(627, 406);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonEliminar.TabIndex = 1;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(16, 100);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(929, 278);
            this.grilla.TabIndex = 2;
            // 
            // botonAgregar
            // 
            this.botonAgregar.Location = new System.Drawing.Point(870, 406);
            this.botonAgregar.Name = "botonAgregar";
            this.botonAgregar.Size = new System.Drawing.Size(75, 23);
            this.botonAgregar.TabIndex = 3;
            this.botonAgregar.Text = "Agregar";
            this.botonAgregar.UseVisualStyleBackColor = true;
            this.botonAgregar.Click += new System.EventHandler(this.botonAgregar_Click);
            // 
            // salir
            // 
            this.salir.Location = new System.Drawing.Point(16, 406);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(75, 23);
            this.salir.TabIndex = 4;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Productos:";
            // 
            // btnVerAnimales
            // 
            this.btnVerAnimales.Location = new System.Drawing.Point(834, 11);
            this.btnVerAnimales.Name = "btnVerAnimales";
            this.btnVerAnimales.Size = new System.Drawing.Size(111, 23);
            this.btnVerAnimales.TabIndex = 6;
            this.btnVerAnimales.Text = "Ver Animales";
            this.btnVerAnimales.UseVisualStyleBackColor = true;
            this.btnVerAnimales.Click += new System.EventHandler(this.btnVerAnimales_Click);
            // 
            // botonVerCategorias
            // 
            this.botonVerCategorias.Location = new System.Drawing.Point(834, 40);
            this.botonVerCategorias.Name = "botonVerCategorias";
            this.botonVerCategorias.Size = new System.Drawing.Size(111, 23);
            this.botonVerCategorias.TabIndex = 7;
            this.botonVerCategorias.Text = "Ver Categorias";
            this.botonVerCategorias.UseVisualStyleBackColor = true;
            this.botonVerCategorias.Click += new System.EventHandler(this.botonVerCategorias_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(751, 406);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnVerUsr
            // 
            this.btnVerUsr.Location = new System.Drawing.Point(834, 71);
            this.btnVerUsr.Name = "btnVerUsr";
            this.btnVerUsr.Size = new System.Drawing.Size(111, 23);
            this.btnVerUsr.TabIndex = 10;
            this.btnVerUsr.Text = "Ver Usuarios";
            this.btnVerUsr.UseVisualStyleBackColor = true;
            this.btnVerUsr.Click += new System.EventHandler(this.btnVerUsr_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 450);
            this.Controls.Add(this.btnVerUsr);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.botonVerCategorias);
            this.Controls.Add(this.btnVerAnimales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.botonAgregar);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.label1);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button botonAgregar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnVerAnimales;
        private System.Windows.Forms.Button botonVerCategorias;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnVerUsr;
    }
}

