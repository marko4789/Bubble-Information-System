﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble_Information_System
{
    public partial class MenuUs : Form
    {
        public MenuUs()
        {
            InitializeComponent();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmVentas ventanaVentas = new frmVentas())
                ventanaVentas.ShowDialog();
        }

        private void btn_Venta_Click(object sender, EventArgs e)
        {
            using (frmVentas ventanaVentas = new frmVentas())
                ventanaVentas.ShowDialog();
        }
    }
}
