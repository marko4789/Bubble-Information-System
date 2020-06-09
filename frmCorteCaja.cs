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
    public partial class frmCorteCaja : Form
    {
        bool status;
        DataSet dtVentas;
        DataSet dtEnDeuda;
        DataSet dtSinDeuda;
        MySqlConnection conexionBD = new MySqlConnection("server=localhost; database=dblavanderia; uid=root; pdw=; Convert Zero Datetime=True; Allow Zero Datetime=True");
        public frmCorteCaja()
        {
            this.status = true;
            InitializeComponent();
        }

        private void frmCorteCaja_Load(object sender, EventArgs e)
        {

        }

        private void dtpFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            
        }

        public void llenarTabla()
        {
            MySqlDataAdapter adapter;
            dtVentas = new DataSet();
            dtEnDeuda = new DataSet();
            dtSinDeuda = new DataSet();
            String llenarEnDeuda;
            String llenarSinDeuda;
            String Completo = "SELECT empleados.nombre, numVentaServicio, fecha, importe, ventaservicio.status FROM (ventaservicio INNER JOIN (usuario INNER JOIN empleados ON usuario.numEmpleado = empleados.numEmpleado) ON usuario.numUsuario = ventaservicio.numUsuario) WHERE fecha BETWEEN '" + dtpFechaInicial.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaFinal.Value.ToString("yyyy-MM-dd") + "';";

            llenarEnDeuda = "SELECT empleados.nombre, numVentaServicio, fecha, importe, ventaservicio.status FROM (ventaservicio INNER JOIN (usuario INNER JOIN empleados ON usuario.numEmpleado = empleados.numEmpleado) ON usuario.numUsuario = ventaservicio.numUsuario) WHERE ventaservicio.status = 1 AND fecha BETWEEN '" + dtpFechaInicial.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaFinal.Value.ToString("yyyy-MM-dd") + "';";
            
            llenarSinDeuda = "SELECT empleados.nombre, numVentaServicio, fecha, importe, ventaservicio.status FROM (ventaservicio INNER JOIN (usuario INNER JOIN empleados ON usuario.numEmpleado = empleados.numEmpleado) ON usuario.numUsuario = ventaservicio.numUsuario) WHERE ventaservicio.status = 0 AND fecha BETWEEN '" + dtpFechaInicial.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaFinal.Value.ToString("yyyy-MM-dd") + "';";
            
            txtTest.Text = dtpFechaFinal.Value.ToString("yyyy-MM-dd");

            try
            {
                adapter = new MySqlDataAdapter(llenarEnDeuda, conexionBD);
                adapter.Fill(dtEnDeuda, "ventaservicio");
                adapter = new MySqlDataAdapter(llenarSinDeuda, conexionBD);
                adapter.Fill(dtSinDeuda, "ventaservicio");
                adapter = new MySqlDataAdapter(Completo, conexionBD);
                adapter.Fill(dtVentas, "ventaservicio");

                if (this.status == true)
                {
                    dgvVentas.DataSource = dtEnDeuda;
                    dgvVentas.DataMember = "ventaservicio";
                }
                else
                {
                    dgvVentas.DataSource = dtSinDeuda;
                    dgvVentas.DataMember = "ventaservicio";
                }

            }
            catch(MySqlException eu)
            {
                MessageBox.Show(eu.Message, "Bubble Information System");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (DateTime.Compare(dtpFechaInicial.Value, dtpFechaFinal.Value) <= 0 ||
                dtpFechaInicial.Value.ToString("yyyy-MM-dd").Equals(dtpFechaFinal.Value.ToString("yyyy-MM-dd")))
            {
                llenarTabla();
                txtSeleccionadas.Text = this.dtVentas.Tables[0].Rows.Count.ToString();
                txtDeuda.Text = this.dtEnDeuda.Tables[0].Rows.Count.ToString();
                txtPagadas.Text = this.dtSinDeuda.Tables[0].Rows.Count.ToString();
                txtTotalPagadas.Text = suma(dtSinDeuda.Tables[0]).ToString("#,#.00");
                txtTotalDeuda.Text = suma(dtEnDeuda.Tables[0]).ToString("#,#.00");
                txtTotalNeto.Text = suma(dtVentas.Tables[0]).ToString("#,#.00");

                btnImprimir.Enabled = true;
            }
            else
            {
                MessageBox.Show("La fecha inicial debe ser anterior a la final", "Bubble Information System");
            }
        }

        double suma(DataTable tabla)
        {
            double resultado = 0.0;

            for(int i = 0; i < tabla.Rows.Count ; i++)
            {
                resultado = resultado + Convert.ToDouble(tabla.Rows[i][3]);
            }

            return resultado;
        }

        private void rbtEnDeuda_CheckedChanged(object sender, EventArgs e)
        {
            this.status = true;
            llenarTabla();
        }

        private void rbtSinDeuda_CheckedChanged(object sender, EventArgs e)
        {
            this.status = false;
            llenarTabla();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
