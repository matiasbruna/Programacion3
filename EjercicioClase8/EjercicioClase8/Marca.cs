﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioClase8
{
    internal class Marca
    {
        private int id;
        private string descripcion;

        public int Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

        public Marca(string pDescripcion)
        {
            Descripcion = pDescripcion;
        }

        public bool Nuevo()
        {
            bool correcto;
            string query = $"INSERT INTO Marcas(descripcion) VALUES ('{Descripcion}')";

            correcto = BaseDatos.EjecutarConsulta(query);

            return correcto;
        }


    }
}
