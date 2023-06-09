using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaParcial
{ 
    
    public partial class Form1 : Form 
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void txtAgregar_Click(object sender, EventArgs e)
        {
            int CP = Convert.ToInt32(txtCodigoPostal.Text.Trim());
            Ciudades miCiudad = new Ciudades(txtCiudad.Text.Trim(),CP );

            if (miCiudad.NuevaCiudad())
            {
                MessageBox.Show("Ciudad Agregada Correctamente");   
            }
            else
            {
                MessageBox.Show("Ciudad no agregada");

            }


        }

        private void btnCanselar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Ciudades.BuscarTodas();
            LlenarGrilla(dt);

        }
        private void LlenarGrilla(DataTable datos)
        {
            dgvMostrar.DataSource = null;
            dgvMostrar.DataSource = datos;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string dato = txtCiudad.Text.Trim();

            LlenarGrilla(Ciudades.Buscar(dato));
        }
    }
}
