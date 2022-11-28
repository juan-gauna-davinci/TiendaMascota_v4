namespace TiendaMascota_v2.Vista.ABMEmpleado
{
    partial class VerEmpleado
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
            this.botonEditar = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.botonEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grillaEmpleados = new System.Windows.Forms.DataGridView();
            this.btnAgregarEmpleado = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // botonEditar
            // 
            this.botonEditar.Location = new System.Drawing.Point(375, 125);
            this.botonEditar.Name = "botonEditar";
            this.botonEditar.Size = new System.Drawing.Size(87, 23);
            this.botonEditar.TabIndex = 17;
            this.botonEditar.Text = "Editar";
            this.botonEditar.UseVisualStyleBackColor = true;
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(375, 184);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(87, 23);
            this.botonAtras.TabIndex = 16;
            this.botonAtras.Text = "Atrás";
            this.botonAtras.UseVisualStyleBackColor = true;
            // 
            // botonEliminar
            // 
            this.botonEliminar.Location = new System.Drawing.Point(375, 154);
            this.botonEliminar.Name = "botonEliminar";
            this.botonEliminar.Size = new System.Drawing.Size(87, 23);
            this.botonEliminar.TabIndex = 15;
            this.botonEliminar.Text = "Eliminar";
            this.botonEliminar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 25);
            this.label1.TabIndex = 14;
            this.label1.Text = "Empleados";
            // 
            // grillaEmpleados
            // 
            this.grillaEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaEmpleados.Location = new System.Drawing.Point(12, 58);
            this.grillaEmpleados.Name = "grillaEmpleados";
            this.grillaEmpleados.Size = new System.Drawing.Size(341, 150);
            this.grillaEmpleados.TabIndex = 13;
            // 
            // btnAgregarEmpleado
            // 
            this.btnAgregarEmpleado.Location = new System.Drawing.Point(375, 96);
            this.btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            this.btnAgregarEmpleado.Size = new System.Drawing.Size(87, 23);
            this.btnAgregarEmpleado.TabIndex = 12;
            this.btnAgregarEmpleado.Text = "Agregar";
            this.btnAgregarEmpleado.UseVisualStyleBackColor = true;
            // 
            // VerEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 256);
            this.Controls.Add(this.botonEditar);
            this.Controls.Add(this.botonAtras);
            this.Controls.Add(this.botonEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaEmpleados);
            this.Controls.Add(this.btnAgregarEmpleado);
            this.Name = "VerEmpleado";
            this.Text = "VerEmpleado";
            this.Load += new System.EventHandler(this.VerEmpleado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaEmpleados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botonEditar;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Button botonEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaEmpleados;
        private System.Windows.Forms.Button btnAgregarEmpleado;
    }
}