using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioRectangulo
{
     class rectangulo
    {
        //artributos 

        private int ancho;
        private int alto;
        private string color;

        //propiedades


        public int Ancho
        {
            set { ancho = value; }
            get { return ancho; }
        }
        public int Alto
        {
            set { alto = value; }
            get { return alto; }
        }
        public string Color
        {
            set { color = value; }
            get { return color; }
        }

        //constructores mas de uno como ejemplo de sobrecarga.

        public void Rectangulo()
        {
            Ancho = 1;
            Alto = 1;
        }
        public void Rectangulo(int pAncho, int pAlto)
        {
            Ancho = pAncho;
            Alto = pAlto;
        }



        //metodos 

        public void Area()
        {
            int area = 0;
            area = Ancho* Alto;
        }
        public int Area (int pAncho, int pAlto)
        {
            int area = 0;
            area = pAncho * pAlto;
            return area;
        }

        public void Perimetro()
        {
            int perimetro = 0;
            perimetro = (Ancho * 2) + (Alto * 2);
            MessageBox.Show($"El perimetro es: {perimetro}");
        }
        public void Perimetro(int pAlto)
        {
            int perimetro = 0;
            perimetro = (Ancho * 2) + (pAlto* 2);
            MessageBox.Show($"El perimetro es: {perimetro}");
        }
        public void Perimetro(int pAlto, int pAncho)
        {
            Alto = pAlto;
            Ancho = pAncho;
        }


    }
}
