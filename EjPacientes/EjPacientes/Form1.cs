﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjPacientes
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void sexosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSexos formSexos = new frmSexos();
            formSexos.MdiParent= this;
            formSexos.Show();
        }
    }
}
