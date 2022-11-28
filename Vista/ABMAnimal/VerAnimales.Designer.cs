namespace TiendaMascota_v2.Vista.ABMAnimal
{
    partial class VerAnimales
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
            this.btnAgregarAnimal = new System.Windows.Forms.Button();
            this.grillaAnimales = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.botonEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaAnimales)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAgregarAnimal
            // 
            this.btnAgregarAnimal.Location = new System.Drawing.Point(375, 91);
            this.btnAgregarAnimal.Name = "btnAgregarAnimal";
            this.btnAgregarAnimal.Size = new System.Drawing.Size(87, 23);
            this.btnAgregarAnimal.TabIndex = 0;
            this.btnAgregarAnimal.Text = "Agregar";
            this.btnAgregarAnimal.UseVisualStyleBackColor = true;
            this.btnAgregarAnimal.Click += new System.EventHandler(this.btnAgregarAnimal_Click);
            // 
            // grillaAnimales
            // 
            this.grillaAnimales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaAnimales.Location = new System.Drawing.Point(12, 53);
            this.grillaAnimales.Name = "grillaAnimales";
            this.grillaAnimales.Size = new System.Drawing.Size(341, 150);
            this.grillaAnimales.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Animales";
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(375, 149);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(87, 23);
            this.botonEliminar.TabIndex = 3;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            this.botonEliminar.Click += new System.EventHandler(this.botonEliminar_Click);
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(375, 179);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(87, 23);
            this.botonAtras.TabIndex = 4;
            this.botonAtras.Text = "Atrás";
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(375, 120);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(87, 23);
            this.botonEditar.TabIndex = 5;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = true;
            this.botonEditar.Click += new System.EventHandler(this.botonEditar_Click);
            // 
            // VerAnimales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaAnimales);
            this.Controls.Add(this.btnAgregarAnimal);
            this.Name = "VerAnimales";
            this.Text = "VerAnimales";
            this.Load += new System.EventHandler(this.VerAnimales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaAnimales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarAnimal;
        private System.Windows.Forms.DataGridView grillaAnimales;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Button botonEditar;
    }
}