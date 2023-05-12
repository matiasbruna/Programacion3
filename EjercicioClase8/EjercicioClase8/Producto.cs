using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase8
{
    internal class Producto
    {
        private int id;
        private int idMarca;
        private string descripcion;
        private int precioCompra;
        private int precioVenta;

        public int Id
        {
            set { id = value; }
            get { return id; }

        }
        public int IdMarca
        {
            set { idMarca = value; }
            get { return idMarca; }
        }
        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }
        public int PrecioCompra
        {
            set { precioCompra = value; }
            get { return precioCompra; }

        }
        public int PrecioVenta
        {
            set { precioVenta = value; }
            get { return precioVenta; }
        }
        public Producto() { }
        public Producto(int pIdMarca, string pDescripcion, int pPrecioCompra, int pPrecioVenta)

        {
            IdMarca= pIdMarca;
            Descripcion= pDescripcion;
            PrecioCompra= pPrecioCompra;
            PrecioVenta= pPrecioVenta;
    
        }

        public bool Nuevo()
        {
            bool correcto;

            string query = $"INSERT INTO Productos(idMarcas, descripcion, precioCompra, precioVenta) VALUES({IdMarca},'{Descripcion}',{PrecioCompra},{PrecioVenta})";

            correcto = BaseDatos.EjecutarConsulta(query);

            return correcto;
        }

        static public DataTable BuscarTodo()
        {
            DataTable dt = new DataTable();

            string query = "SELECT * FROM Productos";

            dt = BaseDatos.Buscar(query);  //le paso la consulta y guardo en la variable DataTable

            return dt; //retorno la lo que hay en el DataTable al form.
        }

        static public DataTable BuscarPorId (int idBuscado)
        {
            DataTable dt = new DataTable();

            string query = $"SELECT * FROM Productos WHERE ID = {idBuscado}";

            dt = BaseDatos.Buscar(query);  //le paso la consulta y guardo en la variable DataTable

            return dt; //retorno la lo que hay en el DataTable al form.
        }

    }
    
}
