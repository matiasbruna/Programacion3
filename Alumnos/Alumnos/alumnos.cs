using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    public class Alumnos
    {
        private bool activo;
        private int legajo;
        private int anioingreso;
        private string apellido;
        private string nombre;
        private string ciudad;
        private string domicilio;
        private string provincia;
        private string telefono;
        private string email;
        private static int sumalegajo;

        public bool Activo
        {
            set { activo = value; }
            get { return activo; }
        }
        public int Legajo
        {
            set { legajo = value; }
            get { return legajo; }
        }
        public int AnioIngreso
        {
            set { anioingreso = value; }
            get { return anioingreso; }
        }
        public string Apellido
        {
            set { apellido = value; }
            get { return apellido; }
        }
        public string Nombre 
        {
            set { nombre = value; }
            get { return nombre; }
        }
        public string Ciudad
        {
            set { ciudad = value; }
            get { return ciudad; }
        }
        public string Domicilio
        {
            set { domicilio = value; }
            get { return domicilio; }
        }
        public string Provincia
        {
            set { provincia = value; }
            get { return provincia; }
        }
        public string Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }
        public string Email
        {
            set { email = value; }
            get { return email; }
        }


        public Alumnos()
        {
            sumalegajo += 1;
            Legajo = sumalegajo;
            AnioIngreso = DateTime.Now.Year;
        }
        public Alumnos(string pNombre, string pApellido): this()
        {
            Nombre = pNombre;
            Apellido = pApellido;
            Ciudad = "San Francisco";
            Provincia = "Cordoba";
            Activo = true;
        }
        public override string ToString()
        {
            string mensaje = "";

            mensaje += "Legajo: " + Legajo + "\n";
            mensaje += "A;o de Ingreso: " + AnioIngreso + "\n";
            mensaje += "Nombre: " + Nombre + "\n";
            mensaje += "Ciudad:  " + Ciudad + "\n";
            mensaje += "Provincia" + Provincia + "\n";
            mensaje += "Telefono: " + Telefono + "\n";
            mensaje += "Email: " + Email + "\n";
            mensaje += "Activo: " + Activo + "\n";

            return mensaje;
        }

        public Alumnos(
            string pApellido,
            string pNombre,
            string pCiudad,
            string pDomicilio,
            string pProvincia,
            string pTelefono,
            string pEmail,
            bool pActivo)
        {
            Apellido = pApellido;
            Nombre = pNombre;
            Ciudad = pCiudad;
            Domicilio = pDomicilio;
            Provincia = pProvincia;
            Telefono = pTelefono;
            Email = pEmail;
            Activo = pActivo;
        }   
    }

 

   
}
