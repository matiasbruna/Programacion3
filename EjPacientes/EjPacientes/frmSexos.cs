using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjPacientes
{
    public partial class frmSexos : Form
    {
        public frmSexos()
        {
            InitializeComponent();
        }

        private void btnBuscarTodos_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Sexo.BuscarTodo();
            dgvSexos.DataSource = dt;
        }

        private void btnBuscarPorId_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarPorDescripcion_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = Sexo.BuscarPorDescripcion(txtBuscarPorDescripcion.Text.Trim());
            dgvSexos.DataSource = dt;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(dgvSexos.SelectedRows.Count > 0) {
                int id;
                id = Convert.ToInt32(dgvSexos.CurrentRow.Cells[0].Value);
                DialogResult borra = MessageBox.Show("Estas seguro de eliminar", "Advertencia ", MessageBoxButtons.YesNo);
                if (borra == DialogResult.Yes)
                {
                    if (!Sexo.Eliminar(id))
                    {
                        MessageBox.Show("ha ocurrido un error al eliminar");
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un sexo");
            }

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvSexos.SelectedRows.Count >0) 
            { 
               int id;
                id = Convert.ToInt32(dgvSexos.CurrentRow.Cells[0].Value);

            }else
            {
                MessageBox.Show("Seleccione un sexo");
            }
        }
    }
}
