namespace Alumnos
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
            this.btnAlumno = new System.Windows.Forms.Button();
            this.btnAlumno1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAlumno
            // 
            this.btnAlumno.Location = new System.Drawing.Point(199, 26);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(112, 23);
            this.btnAlumno.TabIndex = 0;
            this.btnAlumno.Text = "CreaAlumno";
            this.btnAlumno.UseVisualStyleBackColor = true;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // btnAlumno1
            // 
            this.btnAlumno1.Location = new System.Drawing.Point(199, 67);
            this.btnAlumno1.Name = "btnAlumno1";
            this.btnAlumno1.Size = new System.Drawing.Size(112, 23);
            this.btnAlumno1.TabIndex = 1;
            this.btnAlumno1.Text = "CreaAlumnos2";
            this.btnAlumno1.UseVisualStyleBackColor = true;
            this.btnAlumno1.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 389);
            this.Controls.Add(this.btnAlumno1);
            this.Controls.Add(this.btnAlumno);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlumno;
        private System.Windows.Forms.Button btnAlumno1;
    }
}

