using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase8
{
    public partial class frmProductos : Form
    {
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmNuevoProducto formNuevo = new frmNuevoProducto();
            formNuevo.Show();
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
           //le paso por parametros el metodo buscarTodo()  de la clase producto.
            LlenarGrilla(Producto.BuscarTodo()); 
            
        }


        private void LlenarGrilla (DataTable datos)
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = datos;
        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {
            int idBuscado;

            //Valido que el id ingresado sea correcto.
            if(!int.TryParse(txtBuscarPorId.Text.Trim(), out idBuscado))
            {
                MessageBox.Show("Id no valido");
            }
            else
            {
                LlenarGrilla(Producto.BuscarPorId(idBuscado));
            }
        }

        private void btnBuscarPorMarca_Click(object sender, EventArgs e)
        {
            string marca;
           
            if(txtBuscarPorMarca.Text != "")
            {
                marca = txtBuscarPorMarca.Text.Trim();
                
                string  idMarca = "";
              
                DataTable dt = new DataTable();
                dt = Marca.BuscarTodo(); //lleno el dt con todas las marcas.
              
                for(int i = 0; i < dt.Rows.Count; i++)
                {
                   
                    if (marca == dt.Rows[i][1].ToString().Trim()) //valido si la marca encontrada en el dt es igual al del txt..
                    {
                        
                        idMarca = dt.Rows[i][0].ToString();
                        break; // Salimos del bucle si encontramos una coincidencia
                    }
                }
                if (idMarca != "")
                {
                    LlenarGrilla(Producto.BuscarPorMarca(int.Parse(idMarca)));
                }
                else
                {
                    MessageBox.Show("No Se encuentra la marca solicitada.");
                    dgvProductos.DataSource = null;
                }

                
            }
            else
            {
                MessageBox.Show("el campo Marca no debe estar vacio.");
            }

        }

        private void btnBuscarPorDescripcion_Click(object sender, EventArgs e)
        {
            if(txtBuscarPorDescripcion.Text != "")
            {
                string descripcion = txtBuscarPorDescripcion.Text.Trim();

                LlenarGrilla(Producto.BuscarPorDescripcion(descripcion));

            }
            else
            {
                MessageBox.Show("el campo Descripcioon no debe estar vacio.");
            }


        }
         
        
    }
}
