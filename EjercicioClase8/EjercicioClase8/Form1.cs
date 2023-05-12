using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
