namespace EjPacientes
{
    partial class frmSexos
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorId = new System.Windows.Forms.Button();
            this.txtBuscarPorId = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnBuscarPorDescripcion = new System.Windows.Forms.Button();
            this.txtBuscarPorDescripcion = new System.Windows.Forms.TextBox();
            this.btnBuscarTodos = new System.Windows.Forms.Button();
            this.dgvSexos = new System.Windows.Forms.DataGridView();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSexos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarPorId);
            this.groupBox1.Controls.Add(this.txtBuscarPorId);
            this.groupBox1.Location = new System.Drawing.Point(38, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(592, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar por Id";
            // 
            // btnBuscarPorId
            // 
            this.btnBuscarPorId.Location = new System.Drawing.Point(316, 28);
            this.btnBuscarPorId.Name = "btnBuscarPorId";
            this.btnBuscarPorId.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorId.TabIndex = 1;
            this.btnBuscarPorId.Text = "Buscar";
            this.btnBuscarPorId.UseVisualStyleBackColor = true;
            this.btnBuscarPorId.Click += new System.EventHandler(this.btnBuscarPorId_Click);
            // 
            // txtBuscarPorId
            // 
            this.txtBuscarPorId.Location = new System.Drawing.Point(17, 28);
            this.txtBuscarPorId.Name = "txtBuscarPorId";
            this.txtBuscarPorId.Size = new System.Drawing.Size(200, 20);
            this.txtBuscarPorId.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnBuscarPorDescripcion);
            this.groupBox2.Controls.Add(this.txtBuscarPorDescripcion);
            this.groupBox2.Location = new System.Drawing.Point(38, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 64);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Buscar por Descripción";
            // 
            // btnBuscarPorDescripcion
            // 
            this.btnBuscarPorDescripcion.Location = new System.Drawing.Point(316, 31);
            this.btnBuscarPorDescripcion.Name = "btnBuscarPorDescripcion";
            this.btnBuscarPorDescripcion.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarPorDescripcion.TabIndex = 1;
            this.btnBuscarPorDescripcion.Text = "Buscar";
            this.btnBuscarPorDescripcion.UseVisualStyleBackColor = true;
            this.btnBuscarPorDescripcion.Click += new System.EventHandler(this.btnBuscarPorDescripcion_Click);
            // 
            // txtBuscarPorDescripcion
            // 
            this.txtBuscarPorDescripcion.Location = new System.Drawing.Point(17, 31);
            this.txtBuscarPorDescripcion.Name = "txtBuscarPorDescripcion";
            this.txtBuscarPorDescripcion.Size = new System.Drawing.Size(200, 20);
            this.txtBuscarPorDescripcion.TabIndex = 0;
            // 
            // btnBuscarTodos
            // 
            this.btnBuscarTodos.Location = new System.Drawing.Point(291, 221);
            this.btnBuscarTodos.Name = "btnBuscarTodos";
            this.btnBuscarTodos.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarTodos.TabIndex = 2;
            this.btnBuscarTodos.Text = "Buscar";
            this.btnBuscarTodos.UseVisualStyleBackColor = true;
            this.btnBuscarTodos.Click += new System.EventHandler(this.btnBuscarTodos_Click);
            // 
            // dgvSexos
            // 
            this.dgvSexos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSexos.Location = new System.Drawing.Point(38, 260);
            this.dgvSexos.Name = "dgvSexos";
            this.dgvSexos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSexos.Size = new System.Drawing.Size(592, 150);
            this.dgvSexos.TabIndex = 3;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(191, 416);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 4;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(272, 416);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(353, 416);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // frmSexos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgvSexos);
            this.Controls.Add(this.btnBuscarTodos);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSexos";
            this.Text = "Sexos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSexos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarPorId;
        private System.Windows.Forms.TextBox txtBuscarPorId;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuscarPorDescripcion;
        private System.Windows.Forms.TextBox txtBuscarPorDescripcion;
        private System.Windows.Forms.Button btnBuscarTodos;
        private System.Windows.Forms.DataGridView dgvSexos;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
    }
}