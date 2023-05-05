using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiempo
{
    public partial class Form1 : Form
    {
        Tiempo miTiempo;
        public Form1()
        {
            InitializeComponent();
        }

        private void btbCompleto_Click(object sender, EventArgs e)
        {
            int hora;
            int minutos;
            int segundos;
            if (txtHora.Text.Trim() == "") 
            {
                txtHora.Text = "0";
            }
            if (txtMinutos.Text.Trim() == "")
            {
                txtMinutos.Text = "0";
            }
            if (txtSegundos.Text.Trim() == "")
            {
                txtSegundos.Text = "0";
            }
            hora =Convert.ToInt32(txtHora.Text);
            minutos = Convert.ToInt32(txtMinutos.Text);
            segundos = Convert.ToInt32(txtSegundos.Text);

            miTiempo = new Tiempo(hora , minutos, segundos);
        }


    }
}
