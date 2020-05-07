using System;
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
    public partial class MenuAd : Form
    {

        
        public MenuAd()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Empleados ventanaEmpleados = new Empleados())
                ventanaEmpleados.ShowDialog();

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
