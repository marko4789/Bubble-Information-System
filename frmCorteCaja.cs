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
using CrystalDecisions;

namespace Bubble_Information_System
{
    public partial class frmCorteCaja : Form
    {
        bool status;
        DataSet dtVentas;
        DataSet dtEnDeuda;
        DataSet dtSinDeuda;
        DataTable Status;
        DataTable Etc;
        Reporte_CorteCaja reporte;
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
            String Completo = "SELECT empleados.nombre, empleados.apellidoPaterno, numVentaServicio, fecha, importe, ventaservicio.status FROM (ventaservicio INNER JOIN (usuario INNER JOIN empleados ON usuario.numEmpleado = empleados.numEmpleado) ON usuario.numUsuario = ventaservicio.numUsuario) WHERE fecha BETWEEN '" + dtpFechaInicial.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaFinal.Value.ToString("yyyy-MM-dd") + "';";

            llenarEnDeuda = "SELECT empleados.nombre, empleados.apellidoPaterno, numVentaServicio, fecha, importe, ventaservicio.status FROM (ventaservicio INNER JOIN (usuario INNER JOIN empleados ON usuario.numEmpleado = empleados.numEmpleado) ON usuario.numUsuario = ventaservicio.numUsuario) WHERE ventaservicio.status = 1 AND fecha BETWEEN '" + dtpFechaInicial.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaFinal.Value.ToString("yyyy-MM-dd") + "';";
            
            llenarSinDeuda = "SELECT empleados.nombre, empleados.apellidoPaterno, numVentaServicio, fecha, importe, ventaservicio.status FROM (ventaservicio INNER JOIN (usuario INNER JOIN empleados ON usuario.numEmpleado = empleados.numEmpleado) ON usuario.numUsuario = ventaservicio.numUsuario) WHERE ventaservicio.status = 0 AND fecha BETWEEN '" + dtpFechaInicial.Value.ToString("yyyy-MM-dd") + "' AND '" + dtpFechaFinal.Value.ToString("yyyy-MM-dd") + "';";
            
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

                llenarStatus(dtVentas.Tables[0]);

                this.Etc = new DataTable();
                this.Etc.Columns.Add("fechaInicial", typeof(DateTime));
                this.Etc.Columns.Add("fechaFinal", typeof(DateTime));
                this.Etc.Columns.Add("ventasPagadas", typeof(int));
                this.Etc.Columns.Add("ventasSinPagar", typeof(int));
                this.Etc.Columns.Add("ventasTotales", typeof(int));
                this.Etc.Columns.Add("total", typeof(double));

                this.Etc.Rows.Add(dtpFechaInicial.Value, dtpFechaFinal.Value, this.dtSinDeuda.Tables[0].Rows.Count, this.dtEnDeuda.Tables[0].Rows.Count, this.dtVentas.Tables[0].Rows.Count, suma(dtVentas.Tables[0]));

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
                resultado = resultado + Convert.ToDouble(tabla.Rows[i][4]);
            }

            return resultado;
        }

        void llenarStatus(DataTable tabla)
        {

            this.Status = new DataTable();
            this.Status.Columns.Add("status", typeof(string));
            this.Status.Columns.Add("numVentaServicio", typeof(int));
            this.Status.Columns.Add("fecha", typeof(string));

            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                if(Convert.ToInt32(tabla.Rows[i][5]) == 0)
                {
                    this.Status.Rows.Add("Pagado", Convert.ToInt32(tabla.Rows[i][2]), Convert.ToDateTime(tabla.Rows[i][3]).ToString("yyyy-MM-dd"));
                }
                else
                {
                    this.Status.Rows.Add("Sin pagar", Convert.ToInt32(tabla.Rows[i][2]), Convert.ToDateTime(tabla.Rows[i][3]).ToString("yyyy-MM-dd"));
                }
            }

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

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            this.reporte = new Reporte_CorteCaja();

            this.reporte.Database.Tables["ventaservicio"].SetDataSource(this.dtVentas.Tables[0]);
            this.reporte.Database.Tables["Status"].SetDataSource(this.Status);
            this.reporte.Database.Tables["Etc"].SetDataSource(this.Etc);

            this.reporte.PrintToPrinter(1, false, 0, 0);
        }

        
    }
}
