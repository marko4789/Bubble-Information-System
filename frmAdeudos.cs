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
        int Empleado;
        DataTable dtVentas;
        MySqlConnection conexionBD = new MySqlConnection("server=localhost; database=dblavanderia; uid=root; pdw=; Convert Zero Datetime=True; Allow Zero Datetime=True");
        public frmAdeudos(String Folio, int empleado)
        {
            this.Empleado = empleado;
            this.Folio = Folio;
            this.status = "1";
            this.dtVentas = new DataTable();
            InitializeComponent();
        }

        public frmAdeudos(int empleado)
        {
            this.Empleado = empleado;
            this.Folio = "";
            this.status = "1";
            this.dtVentas = new DataTable();
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
                dtVentas = new DataTable();
                adapter.Fill(dtVentas);
                dgvVentas.DataSource = dtVentas;
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
            if (!txtImporte.Text.Equals(""))
            {
                double importe = Convert.ToDouble(txtImporte.Text);
                double recibido = Convert.ToDouble(txtRecibido.Text);
                double cambio = 0.0;
                if (recibido >= importe)
                {
                    cambio = recibido - importe;
                    txtCambio.Text = cambio.ToString("#,#.00");
                    btnPagar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("La cantidad recibida es menor que el importe de la venta", "Bubble Information System");
                }
            }
            else
            {
                MessageBox.Show("Debe de introducir una cantidad recibida", "Bubble Information System");
            }
        }

        private void dgvVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNumVentaA.Text = dgvVentas.CurrentRow.Cells[0].Value.ToString();
            txtImporte.Text = Convert.ToDouble(dgvVentas.CurrentRow.Cells[2].Value).ToString("#,#.00");
            btnCambio.Enabled = true;
            txtImporte.Enabled = true;
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
            dgvVentas.Enabled = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            this.status = "0";
            llenarTabla(this.Folio);
            dgvVentas.Enabled = false;
        }

        private void txtImporte_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtRecibido_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {
                string consulta = "Update ventaservicio set status = 0 where numVentaservicio = " + txtNumVentaA.Text;
                MySqlCommand comando1 = new MySqlCommand(consulta, conexionBD);
                conexionBD.Open();
                comando1.ExecuteNonQuery();
                MessageBox.Show("La venta se ha pagado con exito", "Bubble Information System");
            }
            catch (MySqlException sqlE)
            {
                MessageBox.Show(sqlE.ToString());
            }
            finally
            {
                conexionBD.Close();
                txtNumVentaA.Text = "";
                txtRecibido.Text = "";
                txtImporte.Text = "";
                txtCambio.Text = "";
                txtNumVentaB.Text = "";
                this.Folio = "";
                btnCambio.Enabled = false;
                btnPagar.Enabled = false;
                llenarTabla(this.Folio);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            using (frmVentas ventanaVentas = new frmVentas(this.Empleado))
                ventanaVentas.ShowDialog();
        }
    }
}
