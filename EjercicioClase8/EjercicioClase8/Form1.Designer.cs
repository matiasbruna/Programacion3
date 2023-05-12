namespace EjercicioClase8
{
    partial class frmProductos
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
            this.gbId = new System.Windows.Forms.GroupBox();
            this.txtBuscarPorId = new System.Windows.Forms.TextBox();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.bgMarcas = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorMarca = new System.Windows.Forms.Button();
            this.txtBuscarPorMarca = new System.Windows.Forms.TextBox();
            this.gbDescripcion = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorDescripcion = new System.Windows.Forms.Button();
            this.txtBuscarPorDescripcion = new System.Windows.Forms.TextBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.gbId.SuspendLayout();
            this.bgMarcas.SuspendLayout();
            this.gbDescripcion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // gbId
            // 
            this.gbId.Controls.Add(this.btnBuscarPorId);
            this.gbId.Controls.Add(this.txtBuscarPorId);
            this.gbId.Location = new System.Drawing.Point(26, 32);
            this.gbId.Name = "gbId";
            this.gbId.Size = new System.Drawing.Size(208, 56);
            this.gbId.TabIndex = 0;
            this.gbId.TabStop = false;
            this.gbId.Text = "Buscar por Id";
            // 
            // txtBuscarPorId
            // 
            this.txtBuscarPorId.Location = new System.Drawing.Point(6, 19);
            this.txtBuscarPorId.Name = "txtBuscarPorId";
            this.txtBuscarPorId.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarPorId.TabIndex = 0;
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.Location = new System.Drawing.Point(112, 19);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorId.TabIndex = 1;
            this.btnBuscarPorId.Text = "Buscar";
            this.btnBuscarPorId.UseVisualStyleBackColor = true;
            this.btnBuscarPorId.Click += new System.EventHandler(this.btnBuscarPorId_Click);
            // 
            // bgMarcas
            // 
            this.bgMarcas.Controls.Add(this.btnBuscarPorMarca);
            this.bgMarcas.Controls.Add(this.txtBuscarPorMarca);
            this.bgMarcas.Location = new System.Drawing.Point(240, 32);
            this.bgMarcas.Name = "bgMarcas";
            this.bgMarcas.Size = new System.Drawing.Size(208, 56);
            this.bgMarcas.TabIndex = 1;
            this.bgMarcas.TabStop = false;
            this.bgMarcas.Text = "Buscar por Marca";
            // 
            // btnBuscarPorMarca
            // 
            this.btnBuscarPorMarca.Location = new System.Drawing.Point(112, 19);
            this.btnBuscarPorMarca.Name = "btnBuscarPorMarca";
            this.btnBuscarPorMarca.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorMarca.TabIndex = 1;
            this.btnBuscarPorMarca.Text = "Buscar";
            this.btnBuscarPorMarca.UseVisualStyleBackColor = true;
            this.btnBuscarPorMarca.Click += new System.EventHandler(this.btnBuscarPorMarca_Click);
            // 
            // txtBuscarPorMarca
            // 
            this.txtBuscarPorMarca.Location = new System.Drawing.Point(6, 19);
            this.txtBuscarPorMarca.Name = "txtBuscarPorMarca";
            this.txtBuscarPorMarca.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarPorMarca.TabIndex = 0;
            // 
            // gbDescripcion
            // 
            this.gbDescripcion.Controls.Add(this.btnBuscarPorDescripcion);
            this.gbDescripcion.Controls.Add(this.txtBuscarPorDescripcion);
            this.gbDescripcion.Location = new System.Drawing.Point(454, 32);
            this.gbDescripcion.Name = "gbDescripcion";
            this.gbDescripcion.Size = new System.Drawing.Size(208, 56);
            this.gbDescripcion.TabIndex = 2;
            this.gbDescripcion.TabStop = false;
            this.gbDescripcion.Text = "Buscar por Descripcion";
            // 
            // btnBuscarPorDescripcion
            // 
            this.btnBuscarPorDescripcion.Location = new System.Drawing.Point(112, 19);
            this.btnBuscarPorDescripcion.Name = "btnBuscarPorDescripcion";
            this.btnBuscarPorDescripcion.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorDescripcion.TabIndex = 1;
            this.btnBuscarPorDescripcion.Text = "Buscar";
            this.btnBuscarPorDescripcion.UseVisualStyleBackColor = true;
            this.btnBuscarPorDescripcion.Click += new System.EventHandler(this.btnBuscarPorDescripcion_Click);
            // 
            // txtBuscarPorDescripcion
            // 
            this.txtBuscarPorDescripcion.Location = new System.Drawing.Point(6, 19);
            this.txtBuscarPorDescripcion.Name = "txtBuscarPorDescripcion";
            this.txtBuscarPorDescripcion.Size = new System.Drawing.Size(100, 20);
            this.txtBuscarPorDescripcion.TabIndex = 0;
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Location = new System.Drawing.Point(26, 95);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(106, 23);
            this.btnBuscarTodos.TabIndex = 3;
            this.btnBuscarTodos.Text = "Buscar Todos";
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(26, 133);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(636, 150);
            this.dgvProductos.TabIndex = 4;
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(566, 294);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(26, 294);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(107, 294);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 7;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(188, 294);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 8;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(687, 329);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.btnBuscarTodos);
            this.Controls.Add(this.gbDescripcion);
            this.Controls.Add(this.bgMarcas);
            this.Controls.Add(this.gbId);
            this.Name = "frmProductos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.gbId.ResumeLayout(false);
            this.gbId.PerformLayout();
            this.bgMarcas.ResumeLayout(false);
            this.bgMarcas.PerformLayout();
            this.gbDescripcion.ResumeLayout(false);
            this.gbDescripcion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbId;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.TextBox txtBuscarPorId;
        private System.Windows.Forms.GroupBox bgMarcas;
        private System.Windows.Forms.Button btnBuscarPorMarca;
        private System.Windows.Forms.TextBox txtBuscarPorMarca;
        private System.Windows.Forms.GroupBox gbDescripcion;
        private System.Windows.Forms.Button btnBuscarPorDescripcion;
        private System.Windows.Forms.TextBox txtBuscarPorDescripcion;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}

