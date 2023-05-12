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
    public partial class frmNuevoProducto : Form
    {
        public frmNuevoProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void frmNuevoProducto_Load(object sender, EventArgs e)
        {
            cbMarca.ValueMember = "id";
            cbMarca.DisplayMember = "descripcion";
            cbMarca.DataSource = Marca.BuscarTodo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool correcto = true;

            int precioCompra, precioVenta;

            if(txtDescripcion.Text.Trim() == "")
            {
                MessageBox.Show("La descripcion no es Valida");
                correcto = false;
            }

            if(!int.TryParse(txtPrecioCompra.Text.Trim(), out precioCompra))
            {
                MessageBox.Show("el Precio de compra no es valido");
                correcto= false;
            }

            if(!int.TryParse(txtPrecioVenta.Text.Trim(),out precioVenta))
            {
                MessageBox.Show("Precio de Venta no es valido");
                correcto = false;
            }
            if (correcto)
            {
                int id = Convert.ToInt32(cbMarca.SelectedValue);
                Producto miProducto= new Producto(id, txtDescripcion.Text.Trim(),precioCompra, precioVenta);
                if (miProducto.Nuevo())
                {
                    MessageBox.Show("El produccto se guardo Correctamente !!!");
                    Close();
                }
                else
                {
                    MessageBox.Show("Producto no se guardo");
                }

            }

        }
    }
}
