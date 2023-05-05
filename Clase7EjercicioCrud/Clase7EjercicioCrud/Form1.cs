using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase7EjercicioCrud
{
    public partial class Clientes : Form
    {
        SqlConnection conn = new SqlConnection();

        public Clientes()
        {
            InitializeComponent();
        }


        public void Conectar()
        {
            conn.ConnectionString = "Data Source=DESKTOP-NE83MDA;Initial Catalog=Clase7;Integrated Security=True";
            try
            {
                conn.Open();
            }catch(Exception ex)
            {
                MessageBox.Show("Error en la coneccion.\n" + ex);
            }
            finally { conn.Close(); }
        }
        public void Desconectar()
        {
            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = "";
        }
    }
}
