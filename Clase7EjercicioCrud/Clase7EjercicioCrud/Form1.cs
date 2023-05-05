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
                MessageBox.Show("Error en la coneccion.\n" + ex.Message);
            }
            finally { conn.Close(); }
        }
        public void Desconectar()
        {
            conn.Close();
        }
        public void LimpiarCampos()
        {
            
            txtNombre.Text= string.Empty;
            txtApellido.Text= string.Empty;
            txtDomicilio.Text= string.Empty;    
            txtTelefono.Text= string.Empty;
            txtEmail.Text= string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

         

        }

        private void btnVaciar_Click(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = "";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                Conectar();
                string query = $"INSERT INTO Clientes(nombre, apellido, domicilio, telefono, email)" +
                    $"VALUES('{txtNombre.Text}','{txtApellido.Text}','{txtDomicilio.Text}','{txtTelefono.Text}','{txtEmail.Text}')";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                LimpiarCampos();

            }catch(Exception ex)
            {
                MessageBox.Show("Error al cargar el nuevo cliente "+ ex.Message);
            }
            finally { Desconectar(); }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvMostrar.DataSource = null;

            try
            {
                Conectar();
                string query = "SELECT * FROM Clientes";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvMostrar.DataSource = dt;

            }catch(Exception ex)
            {
                MessageBox.Show("error al mostrar datos "+ ex.Message);
            }
            finally { Desconectar(); }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            try
            {
                Conectar();
                LimpiarCampos();

                string query = $"SELECT * FROM Clientes WHERE id = {Convert.ToInt32(txtId.Text)}";

                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    txtNombre.Text = dt.Rows[0].Field<string>("nombre");
                    txtApellido.Text = dt.Rows[0].Field<string>("apellido");
                    txtDomicilio.Text = dt.Rows[0].Field<string>("domicilio");
                    txtTelefono.Text = dt.Rows[0].Field<string>("telefono");
                    txtEmail.Text = dt.Rows[0].Field<string>("email");
                }
                else
                {
                    MessageBox.Show("no se encontro el ID: " + txtId.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pueden recuperar datos" + ex.Message);
            }
            finally { Desconectar(); }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Conectar();

                string query = $"DELETE FROM Clientes WHERE id = {Convert.ToInt32(txtId.Text)}";

                SqlDataAdapter da = new SqlDataAdapter(query, conn); 
                DataTable dt = new DataTable() ;
                da.Fill(dt);

                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"No se pudo borrar el id: {txtId.Text}" + ex.Message);
            }
            finally { Desconectar(); }
        }
    }
}
