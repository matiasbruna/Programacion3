using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Alumnos Alumno2= new Alumnos("Jorge", "Altamirano");
            MessageBox.Show(Alumno2.ToString());
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            Alumnos alumno1= new Alumnos();

            MessageBox.Show(alumno1.Legajo.ToString());
        }
    }
}
