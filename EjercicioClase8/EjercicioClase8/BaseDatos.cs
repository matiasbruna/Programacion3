using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClase8
{
    internal class BaseDatos
    {
        static SqlConnection connection = new SqlConnection();
        static public bool Conectar()
        {
            try
            {
                connection.ConnectionString = "Data Source=DESKTOP-NE83MDA;Initial Catalog=Sistemas;Integrated Security=True";
                    connection.Open();
                return true;
            }catch
            {
                return false;   
            }
        }
        static public void Desconectar()
        {
            connection.Close();
        }
        static public DataTable Buscar(string query)
        {
            DataTable dt = new DataTable();
            try
            {
                Conectar();
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                da.Fill(dt);
            }
            catch
            {
                return null;
            }
            finally
            {
                Desconectar();
            }
            return dt;
        }
        static public bool EjecutarConsulta(string query)
        {
            bool Correcto;
            try
            {
                Conectar();
                SqlDataAdapter da = new SqlDataAdapter(query, connection);
                DataTable dt = new DataTable();
                da.Fill(dt);
                Correcto = true;
            }
            catch
            {
                return false;
            }
            finally
            {
                Desconectar();
            }
            return Correcto;
        }
      
    }
}
