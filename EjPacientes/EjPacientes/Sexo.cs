using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjPacientes
{
    class Sexo
    {
        private int id;
        private string descripcion;

        public int Id
        {
            set
            {
                id = value;
            }
            get
            {
                return id;
            }
        }

        public string Descripcion
        {
            set
            {
                descripcion = value;
            }
            get
            {
                return descripcion;
            }
        }

        public Sexo()
        {

        }

        public Sexo(string pDescripcion)
        {
            Descripcion = pDescripcion;

        }

        public bool Nuevo()
        {
            bool Correcto;
            string Consulta = "INSERT INTO sexos (descripcion) VALUES ('" + Descripcion + "')";
            Correcto = BaseDatos.EjecutarConsulta(Consulta);
            return Correcto;
        }

        public bool Modificar()
        {
            bool Correcto;
            string Consulta = "UPDATE sexos SET descripcion = '" + Descripcion + "' WHERE id = " + Id;
            Correcto = BaseDatos.EjecutarConsulta(Consulta);
            return Correcto;
        }

        static public bool Eliminar(int id )
        {
            bool Correcto;
            string Consulta = "DELETE FROM sexos WHERE id = " + id;
            Correcto = BaseDatos.EjecutarConsulta(Consulta);
            return Correcto;
        }

        static public DataTable BuscarTodo()
        {
            DataTable dt = new DataTable();
            string Consulta = "SELECT * FROM sexos";
            dt = BaseDatos.Buscar(Consulta);
            return dt;
        }

        static public DataTable BuscarPorId(int idBuscado)
        {
            DataTable dt = new DataTable();
            string Consulta = "SELECT * FROM sexos WHERE id = " + idBuscado;
            dt = BaseDatos.Buscar(Consulta);
            return dt;
        }

        static public DataTable BuscarPorDescripcion(string DescripcionBuscada)
        {
            DataTable dt = new DataTable();
            string Consulta = "SELECT * FROM sexos WHERE descripcion LIKE '%" + DescripcionBuscada + "%'";
            dt = BaseDatos.Buscar(Consulta);
            return dt;
        }
    }
}
