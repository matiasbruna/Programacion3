using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiempo
{
    class Tiempo
    {

        private int hora;
        private int minutos;
        private int segundos;

        public  int Hora {
            set { hora = ValidarHora(value); }
            get { return hora; }   
        } 
        public int Minutos {
            set { minutos = ValidarMinutos(value); }
            get { return minutos; }    
        }  
        public int Segundos {
            set { segundos= ValidarSegundos(value); }
            get { return segundos; }
        }   

        public Tiempo(int pHora , int pMinutos, int pSegundos)
        {
            Hora= pHora;
            Minutos= pMinutos;
            Segundos= pSegundos;
        }

        public override string ToString()
        {
            return Hora + ":"+ Minutos+ ":"+ Segundos;  
        }

        private int ValidarSegundos(int pSegundos)
        {
            if (pSegundos >= 0 && pSegundos < 60)
            {
                return pSegundos;
            }

            else 
            {
                return 0;
            }  
        }
        private int ValidarMinutos(int pMinutos)
        {
            if (pMinutos >= 0 && pMinutos < 60)
            {
                return pMinutos;
            }
            else
            {
                return 0;
            }
        }
        private int ValidarHora(int pHora)
        {
            if (pHora >= 0 && pHora < 23)
            {
                return pHora;
            }
            else
            {
               return 0;
            }
        }


    }
}
