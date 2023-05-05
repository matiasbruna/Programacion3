namespace Tiempo
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHora = new System.Windows.Forms.TextBox();
            this.txtMinutos = new System.Windows.Forms.TextBox();
            this.txtSegundos = new System.Windows.Forms.TextBox();
            this.btbCompleto = new System.Windows.Forms.Button();
            this.txtMostrar = new System.Windows.Forms.Button();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(115, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hora";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Minutos ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Segundos";
            // 
            // txtHora
            // 
            this.txtHora.Location = new System.Drawing.Point(201, 60);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(100, 20);
            this.txtHora.TabIndex = 3;
            // 
            // txtMinutos
            // 
            this.txtMinutos.Location = new System.Drawing.Point(201, 86);
            this.txtMinutos.Name = "txtMinutos";
            this.txtMinutos.Size = new System.Drawing.Size(100, 20);
            this.txtMinutos.TabIndex = 4;
            // 
            // txtSegundos
            // 
            this.txtSegundos.Location = new System.Drawing.Point(201, 117);
            this.txtSegundos.Name = "txtSegundos";
            this.txtSegundos.Size = new System.Drawing.Size(100, 20);
            this.txtSegundos.TabIndex = 5;
            // 
            // btbCompleto
            // 
            this.btbCompleto.Location = new System.Drawing.Point(366, 159);
            this.btbCompleto.Name = "btbCompleto";
            this.btbCompleto.Size = new System.Drawing.Size(75, 23);
            this.btbCompleto.TabIndex = 6;
            this.btbCompleto.Text = "Completo";
            this.btbCompleto.UseVisualStyleBackColor = true;
            this.btbCompleto.Click += new System.EventHandler(this.btbCompleto_Click);
            // 
            // txtMostrar
            // 
            this.txtMostrar.Location = new System.Drawing.Point(188, 195);
            this.txtMostrar.Name = "txtMostrar";
            this.txtMostrar.Size = new System.Drawing.Size(75, 23);
            this.txtMostrar.TabIndex = 7;
            this.txtMostrar.Text = "Mostrar";
            this.txtMostrar.UseVisualStyleBackColor = true;
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(188, 271);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(35, 13);
            this.lblTiempo.TabIndex = 8;
            this.lblTiempo.Text = "label4";
           
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 450);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.txtMostrar);
            this.Controls.Add(this.btbCompleto);
            this.Controls.Add(this.txtSegundos);
            this.Controls.Add(this.txtMinutos);
            this.Controls.Add(this.txtHora);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHora;
        private System.Windows.Forms.TextBox txtMinutos;
        private System.Windows.Forms.TextBox txtSegundos;
        private System.Windows.Forms.Button btbCompleto;
        private System.Windows.Forms.Button txtMostrar;
        private System.Windows.Forms.Label lblTiempo;
    }
}

