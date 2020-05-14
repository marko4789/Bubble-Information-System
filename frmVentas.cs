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
    public partial class frmVentas : Form
    {
        int numEmpleado;
        MySqlConnection conexionBD = new MySqlConnection("server=localhost; database=dblavanderia; uid=root; pdw=;");
        public frmVentas(int numEmpleado)
        {
            this.numEmpleado = numEmpleado;
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {
            if (!txtCliente.Text.Equals(" Buscar") && !txtCliente.Text.Equals(""))
            {
                String consulta = "";

                try
                {
                    if (txtCliente.Text.All(char.IsDigit))
                        {
                            consulta = "Select numCliente, nombre, apellidoPaterno, apellidoMaterno, telefono from clientes where numCliente=" + txtCliente.Text + " and status=0";
                        }
                    else{
                        consulta = "Select numCliente, nombre, apellidoPaterno, apellidoMaterno, telefono from clientes where nombre like '%" + txtCliente.Text + "%' or apellidoMaterno like '%" + txtCliente.Text + "%' or apellidoPaterno like '%" + txtCliente.Text + "%' and status=0";
                    }
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexionBD);
                    conexionBD.Open();
                    DataSet datos = new DataSet();
                    adaptador.Fill(datos, "clientes");
                    dgvClientes.DataSource = datos;
                    dgvClientes.DataMember = "clientes";
                }
                catch (MySqlException SqlE)
                {
                    MessageBox.Show(SqlE.ToString());
                }
                finally
                {
                    conexionBD.Close();
                }
            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            int folio;
            DateTime fecha = DateTime.Today;
            txtFecha.Text = fecha.ToString("dd/M/yyyy");

            
            txtCliente.Text = " Buscar";
            txtCliente.ForeColor = Color.Gray;

            try
            {
                conexionBD.Open();
                string consulta = "SELECT MAX(numVentaServicio) AS numVentaServicio FROM ventaservicio";
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexionBD);
                DataTable aux = new DataTable();
                adapter.Fill(aux);
                DataRow row = aux.Rows[0];
                try
                {
                    folio = Convert.ToInt32(row["numVentaServicio"]);
                }
                catch
                {
                    folio = 0;
                }

                folio++;
                txtFolio.Text = Convert.ToString(folio);

                aux = new DataTable();
                MySqlCommand comando = new MySqlCommand("SELECT nombre, apellidoPaterno, apellidoMaterno FROM empleados where numEmpleado =?numEmpleado", conexionBD);
                comando.Parameters.AddWithValue("numEmpleado", numEmpleado);
                adapter = new MySqlDataAdapter(comando);

                adapter.Fill(aux);

                txtEmpleado.Text = Convert.ToString(aux.Rows[0][0]) + " " + Convert.ToString(aux.Rows[0][1]) + " " + Convert.ToString(aux.Rows[0][2]);


            }
            catch(MySqlException SqlE)
            {
                MessageBox.Show(SqlE.ToString());
            }
            finally
            {
                conexionBD.Close();
            }

        }

        public void llenarTabla()
        {
            String consulta = "Select numCliente, nombre, apellidoPaterno, apellidoMaterno, telefono from clientes where status = 1";
            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexionBD);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dgvClientes.DataSource = table;
            
        }

        private void txtCliente_Enter(object sender, EventArgs e)
        {
            if(txtCliente.Text.Equals(" Buscar"))
            {
                txtCliente.Text = "";
                txtCliente.ForeColor = Color.Black;
            }
            
        }

        private void txtCliente_Leave(object sender, EventArgs e)
        {
            if(txtCliente.Text.Equals(" Buscar"))
            {
                txtCliente.Text = " Buscar";
                txtCliente.ForeColor = Color.Gray;
            }
            else
            {
                if (txtCliente.Text.Equals(""))
                {
                    txtCliente.Text = " Buscar";
                    txtCliente.ForeColor = Color.Gray;
                }
                else
                {
                    txtCliente.ForeColor = Color.Black;
                }
            }
        }
    }
}
