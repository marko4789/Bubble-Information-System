using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;

namespace Bubble_Information_System
{
    public partial class frmAdeudos : Form
    {
        String Folio;
        String status;
        DataSet dtVentas;
        MySqlConnection conexionBD = new MySqlConnection("server=localhost; database=dblavanderia; uid=root; pdw=; Convert Zero Datetime=True; Allow Zero Datetime=True");
        public frmAdeudos(String Folio)
        {
            this.Folio = Folio;
            this.status = "1";
            this.dtVentas = new DataSet();
            InitializeComponent();
        }

        public frmAdeudos()
        {
            this.Folio = "";
            this.status = "1";
            this.dtVentas = new DataSet();
            InitializeComponent();
        }

        private void frmAdeudos_Load(object sender, EventArgs e)
        {
            txtNumVentaB.Text = this.Folio;
            try {
                llenarTabla(this.Folio);
            }
            catch(Exception eu)
            {

            }

        }

        public void llenarTabla(String Folio)
        {
            String llenar = "";
            if (Folio.Equals(""))
            {
                llenar = "Select * from ventaservicio where status = " + this.status;
            }
            else
            {
                llenar = "Select * from ventaservicio where numVentaServicio = " + Folio + " and status = " + this.status;
            }
            try
            {
                conexionBD.Open();
                MySqlDataAdapter adapter = new MySqlDataAdapter(llenar, conexionBD);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dgvVentas.DataSource = table;
                //dgvVentas.DataMember = "ventaservicio";

                //this.dtVentas = table;

            }
            catch(Exception eu)
            {
                MessageBox.Show(eu.ToString());
                throw eu;
            }
            finally
            {
                conexionBD.Close();
            }
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                llenarTabla(txtNumVentaB.Text);
            }
            catch(Exception eu)
            {
                //MessageBox.Show("Número de venta no encontrádo", "Bubble Information System");
                MessageBox.Show(eu.ToString());
            }
            
        }

        private void btnCambio_Click(object sender, EventArgs e)
        {

        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNumVentaB_TextChanged(object sender, EventArgs e)
        {
            try
            {
                llenarTabla(txtNumVentaB.Text);
            }
            catch (Exception eu)
            {

            }
        }

        public static void SoloNumeros(KeyPressEventArgs v)
        {
            if (Char.IsDigit(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsSeparator(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsControl(v.KeyChar))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Sólo números enteros", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }//fin soloNumeros

        private void txtNumVentaB_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            this.status = "1";
            llenarTabla(this.Folio);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.status = "0";
            llenarTabla(this.Folio);
        }
    }
}
