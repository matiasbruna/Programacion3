using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PracticaParcial
{
    internal class Ciudades
    {
        private int id;
        private string nombre;
        private int codigoPostal;

        public int Id 
        { 
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int CodigoPostal
        {
            get { return codigoPostal; }
            set { codigoPostal = value;}
        }

        public Ciudades()
        {
            
        }

        public Ciudades(string pNombre, int pCodigoPostal)
        {
            Nombre = pNombre;
            CodigoPostal= pCodigoPostal;
        }

        public bool NuevaCiudad()
        {
            bool correcto;

            string query = $"INSERT INTO Ciudades(nombre, codigoPostal) Values( '{Nombre}', {CodigoPostal}) ";

            correcto = BaseDatos.EjecutarConsulta(query);

            return correcto;
        }

        static public DataTable BuscarTodas()
        {
            DataTable dt = new DataTable();
            string query = $"SELECT * FROM Ciudades";

            dt =  BaseDatos.Buscar(query); 

            return dt;
        }
        static public DataTable Buscar(string dato)
        {

            DataTable dt = new DataTable();
            string query = $"SELECT nombre, codigoPostal  FROM Ciudades WHERE nombre LIKE '{dato}'";

            dt= BaseDatos.Buscar(query);    


            return dt;

        }

    }
}
