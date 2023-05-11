using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase7ConCLaseCliente
{
    internal class Clientes
    {
        private string  ConnecionString = "Data Source=DESKTOP-NE83MDA;Initial Catalog=dbClientes;Integrated Security=True";
        private SqlConnection connecion = new SqlConnection();
        public Clientes()
        {
            try
            {
                connecion.ConnectionString= ConnecionString;
                connecion.Open();
            }catch(Exception ex)
            {
                Alerta("No se pudo hacer la coneccion" + ex.Message);
            }
        }

        public void Agregar (string pNombre,string pApellido)
        {
            try
            {
                string query = $"INSERT INTO Clientes (nombre , apellido) VALUES('{pNombre}', '{pApellido}') ";
                SqlDataAdapter da = new SqlDataAdapter(query, connecion);
                DataTable dt = new DataTable();
                da.Fill(dt);
            }
            catch(Exception ex)
            {
                Alerta("No se pudo agregar cliente"+ ex.Message);    
            }

        }

        ~Clientes()
        {
            this.connecion.Close();
        }

        public void Alerta(string message)
        {
            MessageBox.Show(message);
        }
    }
}
