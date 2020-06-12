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
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.InteropServices;


namespace Bubble_Information_System
{
    public partial class frmVentas : Form
    {
        bool FINALIZADO;
        int idServicio;
        int numEmpleado;
        MySqlConnection conexionBD = new MySqlConnection("server=localhost; database=dblavanderia; uid=root; pdw=; Convert Zero Datetime=True; Allow Zero Datetime=True");
        StringBuilder linea = new StringBuilder();
        int maxCar = 40, cortar;
        String Cliente;
        DateTime fecha;
        MySqlDateTime fechaSQL;
        public frmVentas(int numEmpleado)
        {
            this.numEmpleado = numEmpleado;
            this.FINALIZADO = false;
            this.fecha = DateTime.Today;

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
            if (!txtCliente.Text.Equals(" Buscar") && !txtCliente.Text.Equals("") && !txtCliente.Text.Equals(this.Cliente))
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
            
            txtFecha.Text = this.fecha.ToString("yyyy-MM-dd");

            
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
                MySqlCommand comando = new MySqlCommand("SELECT nombre, apellidoPaterno FROM empleados where numEmpleado =?numEmpleado", conexionBD);
                comando.Parameters.AddWithValue("numEmpleado", numEmpleado);
                adapter = new MySqlDataAdapter(comando);

                adapter.Fill(aux);

                txtEmpleado.Text = Convert.ToString(aux.Rows[0][0]) + " " + Convert.ToString(aux.Rows[0][1]);

                aux = new DataTable();
                comando = new MySqlCommand("SELECT nombre FROM servicios where status = 0", conexionBD);
                adapter = new MySqlDataAdapter(comando);

                adapter.Fill(aux);

                
                cmbServicio.DataSource = aux;
                cmbServicio.DisplayMember = "nombre";

                aux = new DataTable();
                comando = new MySqlCommand("SELECT numUsuario FROM Usuario where numEmpleado=?numEmpleado", conexionBD);
                comando.Parameters.AddWithValue("numEmpleado", this.numEmpleado);
                adapter = new MySqlDataAdapter(comando);

                adapter.Fill(aux);

                int numUsuario = Convert.ToInt32(aux.Rows[0][0]);
               
                consulta = "insert into ventaservicio (numVentaServicio, fecha, importe, status, numUsuario, numCliente) values ('" + txtFolio.Text + "','" + fecha.ToString("yyyy-MM-dd") + "','" + "0" + "','" + "1" + "','" + numUsuario.ToString() + "','" + "1" + "');  ";
                MySqlCommand agregar = new MySqlCommand(consulta, conexionBD);
                //agregar.Parameters.AddWithValue("fecha", fecha.ToString("yyyy-MM-dd"));
                
                agregar.Parameters.AddWithValue("numUsuario", numUsuario.ToString());

                MySqlDataReader leer;
                leer = agregar.ExecuteReader();

                //MessageBox.Show("Guardado con éxito", "Bubble Information Syste", MessageBoxButtons.OK, MessageBoxIcon.Information);
                while (leer.Read())
                {

                }

                conexionBD.Close();

                consulta = "Select numCliente, nombre, apellidoPaterno, apellidoMaterno, telefono from clientes where status=0";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexionBD);
                DataSet datos = new DataSet();
                conexionBD.Open();
                adaptador.Fill(datos, "clientes");
                dgvClientes.DataSource = datos;
                dgvClientes.DataMember = "clientes";


            }
            catch(MySqlException SqlE)
            {
                MessageBox.Show(SqlE.ToString());
            }
            finally
            {
                conexionBD.Close();
            }

            pictureBox3.BackColor = Color.FromArgb(204, 204, 204);
            pictureBox4.BackColor = Color.FromArgb(204, 204, 204);
            pictureBox5.BackColor = Color.FromArgb(204, 204, 204);

        }

        public void llenarTabla()
        {
            MySqlCommand comando = new MySqlCommand("SELECT numDetalleSer, cantidad, totalPagar, numServicio, numVentaServicio FROM detalleservicio WHERE numVentaServicio=?numVentaServicio", conexionBD);
            comando.Parameters.AddWithValue("numVentaServicio", txtFolio.Text);
            MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
            DataSet table = new DataSet();
            adapter.Fill(table, "detalleservicio");
            dgvVenta.DataSource = table;
            dgvVenta.DataMember = "detalleservicio";
            
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

        private void cmbServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
           // MessageBox.Show(cmbServicio.Text.ToString());
            if (!cmbServicio.Text.Equals("System.Data.DataRowView"))
            {
                DataTable DT = new DataTable();
                MySqlCommand comando = new MySqlCommand("SELECT formaCobro, precio, numServicio FROM servicios where nombre =?nombre", conexionBD);
                comando.Parameters.AddWithValue("nombre", cmbServicio.Text);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                try
                {
                    adapter.Fill(DT);

                }
                catch(Exception eu) { MessageBox.Show(eu.ToString()); }


                txtPrecio.Text = Convert.ToString(DT.Rows[0][1]);

                if (Convert.ToString(DT.Rows[0][0]).Equals("Pieza"))
                {
                    txtPrecioU.Text = "Pz";
                    txtCantidadU.Text = "Pz";
                }
                else
                {
                    txtPrecioU.Text = "Kg";
                    txtCantidadU.Text = "Kg";
                }

                this.idServicio = Convert.ToInt32(DT.Rows[0][2]);
            }
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String consulta = "insert into detalleservicio (numDetalleSer, cantidad, totalPagar, numServicio, numVentaServicio) values ('" + "default" + "','" + txtCantidad.Text + "','" + txtTotal.Text + "','" + this.idServicio + "','" + txtFolio.Text + "');  ";
            MySqlCommand agregar = new MySqlCommand(consulta, conexionBD);
            MySqlDataReader leer;
            try
            {
                conexionBD.Open();
                leer = agregar.ExecuteReader();
                while (leer.Read())
                {

                }

                MessageBox.Show("El servicio se ha agregado la venta con exito", "Bubble Information System");
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

            btnFinalizarVenta.Enabled = true;
            txtCantidad.Text = "";
            txtTotal.Text = "";
            llenarTabla();
        }

        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            double total = 0;

            if (txtCantidad.Text.Equals(""))
            {
                btnAgregar.Enabled = false;
                pictureBox3.BackColor = Color.FromArgb(204, 204, 204);
            }
            else {
                try
                {
                    total = Convert.ToInt32(txtCantidad.Text) * Convert.ToInt32(txtPrecio.Text);
                }
                catch
                {
                    total = Convert.ToDouble(txtCantidad.Text) * Convert.ToDouble(txtPrecio.Text);
                }

                txtTotal.Text = total.ToString();
                btnAgregar.Enabled = true;
                pictureBox3.BackColor = Color.FromArgb(225, 225, 225);

            }
            //int total = Convert.ToInt32(txtCantidad.Text) * Convert.ToInt32(txtPrecio.Text);
            //txtTotal.Text = total.ToString();
        }

        private void dgvClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            cmbServicio.Enabled = true;
            txtCantidad.Enabled = true;
            txtCliente.Enabled  = false;
            dgvClientes.Enabled = false;
            String numCliente = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            this.Cliente = dgvClientes.CurrentRow.Cells[1].Value.ToString()+ " " + dgvClientes.CurrentRow.Cells[2].Value.ToString() + " " + dgvClientes.CurrentRow.Cells[3].Value.ToString();

            try
            {
                string consulta = "Update ventaservicio set numCliente = " + numCliente + " where numVentaservicio = " + txtFolio.Text;
                conexionBD.Open();
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                comando.ExecuteNonQuery();
                txtCliente.Text = this.Cliente;
            }
            catch(MySqlException sqlE)
            {
                MessageBox.Show(sqlE.ToString());
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (txtCantidadU.Text.Equals("Pz"))
            {
                SoloNumeros(e);
            }
            else
            {
                NumerosDecimales(e);
            }
        }

        public static void NumerosDecimales(KeyPressEventArgs v)
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
            else if (v.KeyChar.ToString().Equals("."))
            {
                v.Handled = false;
            }
            else
            {
                v.Handled = true;
                MessageBox.Show("Sólo números o números con punto decimal", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }//fin soloNumerosDecimales

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

        private void btnFinalizarVenta_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable DT = new DataTable();
                MySqlCommand comando = new MySqlCommand("SELECT totalPagar FROM detalleservicio where numVentaServicio = " + txtFolio.Text, conexionBD);
             
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);
                try
                {
                    adapter.Fill(DT);

                }
                catch (Exception eu) { MessageBox.Show(eu.ToString()); }

                double importe = 0;

                for (int i = 0; i < DT.Rows.Count; i++)
                {
                    importe = importe + Convert.ToDouble(DT.Rows[i][0]);
                }

                txtImporte.Text = importe.ToString("#,#.00");

                try
                {
                    string consulta = "Update ventaservicio set importe = " + Convert.ToString(importe) + " where numVentaservicio = " + txtFolio.Text;
                    MySqlCommand comando1 = new MySqlCommand(consulta, conexionBD);
                    conexionBD.Open();
                    comando1.ExecuteNonQuery();
                    MessageBox.Show("La venta se ha finalizado con exito", "Bubble Information System");
                }
                catch (MySqlException sqlE)
                {
                    MessageBox.Show(sqlE.ToString());
                }
                finally
                {
                    conexionBD.Close();
                    this.FINALIZADO = true;
                    btnImprimir.Enabled = true;
                    btnAdeudos.Enabled = true;
                    btnCancelar.Enabled = false;
                    pictureBox4.BackColor = Color.FromArgb(225, 225, 225);
                }

            }
            catch (Exception eu) { MessageBox.Show(eu.ToString()); }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        }

        void cancelar()
        {
            try
            {
                string consulta = "DELETE FROM detalleservicio WHERE numVentaServicio = " + txtFolio.Text;
                MySqlCommand comando = new MySqlCommand(consulta, conexionBD);
                conexionBD.Open();
                comando.ExecuteNonQuery();
                consulta = "DELETE FROM ventaservicio WHERE numVentaServicio = " + txtFolio.Text;
                comando = new MySqlCommand(consulta, conexionBD);
                comando.ExecuteNonQuery();

                MessageBox.Show("La venta se ha sido cancelada", "Bubble Information System");
            }
            catch (MySqlException sqlE)
            {
                MessageBox.Show(sqlE.ToString());
            }
            finally
            {
                conexionBD.Close();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            linea.AppendLine("          LAS POMPAS DE JABON           ");
            linea.AppendLine("");
            linea.AppendLine("CALLE MONTANA 320 ESQUINA CON AV.PRADOS");
            linea.AppendLine("      DEL SOL.COL. PRADOS DEL SOL");
            linea.AppendLine("");
            linea.AppendLine("EXPEDIDO EN EL LOCAL PRINCIPAL");
            linea.AppendLine("");
            linea.AppendLine("CAJA #1                       FOLIO #" + txtFolio.Text);
            linea.AppendLine("");
            linea.AppendLine("****************************************");
            linea.AppendLine("");
            linea.AppendLine("ATENDIDO POR: " + txtEmpleado.Text);
            linea.AppendLine("CLIENTE: " + this.Cliente);
            linea.AppendLine("");
            linea.AppendLine("FECHA: " + this.fecha.ToString("dd/M/yyyy") + "   HORA: " + this.fecha.ToString("hh:mm"));
            linea.AppendLine("");
            linea.AppendLine("****************************************");
            linea.AppendLine("");
            linea.AppendLine("SERVICIO            | CANT |PRECIO|TOTAL");
            AddServicios();
            linea.AppendLine("");
            linea.AppendLine("========================================");
            linea.AppendLine("");
            linea.AppendLine("     IMPORTE A PAGAR: $ " + txtImporte.Text);
            linea.AppendLine("");
            linea.AppendLine("     ¡GRACIAS POR SU COMPRA!");
            RawPrinterHelper.SendStringToPrinter("Samsung M2070 Series", linea.ToString()); //Imprime texto.

        }

        public void AddServicios()
        {
            try
            {
                String servicio = "", cantidad = "",  unidad = "", precio = "", total = "";
                DataTable DTCantidad = new DataTable();
                DataTable DTServicio = new DataTable();

                MySqlCommand comando = new MySqlCommand("SELECT cantidad, totalPagar, numServicio FROM detalleservicio where numVentaServicio = " + txtFolio.Text, conexionBD);
                MySqlDataAdapter adapter = new MySqlDataAdapter(comando);

                adapter.Fill(DTCantidad);

                comando = new MySqlCommand("SELECT numServicio, formaCobro, precio, nombre FROM servicios where status = 0", conexionBD);
                adapter = new MySqlDataAdapter(comando);

                adapter.Fill(DTServicio);

                for (int i = 0; i < DTCantidad.Rows.Count; i++)
                {
                    for(int j = 0; j < DTServicio.Rows.Count; j++)
                    {
                        if (Convert.ToInt32(DTCantidad.Rows[i][2]) == Convert.ToInt32(DTServicio.Rows[j][0]))
                        {
                            servicio = DTServicio.Rows[j][3].ToString();
                            precio = Convert.ToDouble(DTServicio.Rows[j][2]).ToString("#,#.00");
                            if (DTServicio.Rows[j][1].ToString().Equals("Pieza"))
                            {
                                unidad = "Pz";
                            }
                            else
                            {
                                unidad = "Kg";
                            }
                        }
                    }
                    total = Convert.ToDouble(DTCantidad.Rows[i][1]).ToString("#,#.00");

                    cantidad = DTCantidad.Rows[i][0].ToString() + " " + unidad + "  " + precio + " " + total + " ";

                    TextoExtremos(servicio, cantidad);

                }


            }
            catch (Exception eu) { MessageBox.Show(eu.ToString()); }
        }

        public void TextoExtremos(string textoIzquierdo, string textoDerecho)
        {
            //variables que utilizaremos
            string textoIzq, textoDer, textoCompleto = "", espacios = "";

            //Si el texto que va a la izquierda es mayor a 18, cortamos el texto.
            if (textoIzquierdo.Length > 18)
            {
                cortar = textoIzquierdo.Length - 18;
                textoIzq = textoIzquierdo.Remove(18, cortar);
            }
            else
            { textoIzq = textoIzquierdo; }

            textoCompleto = textoIzq;//Agregamos el primer texto.

            if (textoDerecho.Length > 20)//Si es mayor a 20 lo cortamos
            {
                cortar = textoDerecho.Length - 20;
                textoDer = textoDerecho.Remove(20, cortar);
            }
            else
            { textoDer = textoDerecho; }

            //Obtenemos el numero de espacios restantes para poner textoDerecho al final
            int nroEspacios = maxCar - (textoIzq.Length + textoDer.Length);
            for (int i = 0; i < nroEspacios; i++)
            {
                espacios += " ";//agrega los espacios para poner textoDerecho al final
            }
            textoCompleto += espacios + textoDerecho;//Agregamos el segundo texto con los espacios para alinearlo a la derecha.
            linea.AppendLine(textoCompleto);//agregamos la linea al ticket, al objeto en si.
        }

        public String lineaAsteriscos()
        {
            String asteriscos = "";
            for (int i = 0; i < 40; i++)
            {
                asteriscos = asteriscos + "*";
            }

            return linea.AppendLine(asteriscos).ToString();
        }

        public String lineaIgual()
        {
            String iguales = "";
            for (int i = 0; i < 40; i++)
            {
                iguales = iguales + "=";
            }

            return linea.AppendLine(iguales).ToString();
        }

        private void btnAdeudos_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Hide();
            using (frmAdeudos ventanaAdeudos = new frmAdeudos(txtFolio.Text, this.numEmpleado))
                ventanaAdeudos.ShowDialog();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
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
                    else
                    {
                        consulta = "Select numCliente, nombre, apellidoPaterno, apellidoMaterno, telefono from clientes where nombre like '%" + txtCliente.Text + "%' or apellidoMaterno like '%" + txtCliente.Text + "%' or apellidoPaterno like '%" + txtCliente.Text + "%' and status=0";
                    }
                    MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexionBD);
                    conexionBD.Open();
                    DataSet datos = new DataSet();
                    adaptador.Fill(datos, "clientes");
                    dgvClientes.DataSource = datos;
                    dgvClientes.DataMember = "clientes";
                    if(dgvClientes.Rows.Count == 0)
                    {
                        MessageBox.Show("Cliente no encontrado", "Bubble Information System");
                    }
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

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmVentas_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!this.FINALIZADO)
            {
                cancelar();
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        public void encabezado()
        {
            linea.AppendLine("          LAS POMPAS DE JABON           ");
        }
    }



    public class RawPrinterHelper
    {
        // Structure and API declarions:
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
        public class DOCINFOA
        {
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDocName;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pOutputFile;
            [MarshalAs(UnmanagedType.LPStr)]
            public string pDataType;
        }
        [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

        [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool ClosePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

        [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndDocPrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool StartPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool EndPagePrinter(IntPtr hPrinter);

        [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
        public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

        // SendBytesToPrinter()
        // When the function is given a printer name and an unmanaged array
        // of bytes, the function sends those bytes to the print queue.
        // Returns true on success, false on failure.
        public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
        {
            Int32 dwError = 0, dwWritten = 0;
            IntPtr hPrinter = new IntPtr(0);
            DOCINFOA di = new DOCINFOA();
            bool bSuccess = false; // Assume failure unless you specifically succeed.

            di.pDocName = "Ticket de Venta";//Este es el nombre con el que guarda el archivo en caso de no imprimir a la impresora fisica.
            di.pDataType = "RAW";//de tipo texto plano

            // Open the printer.
            if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
            {
                // Start a document.
                if (StartDocPrinter(hPrinter, 1, di))
                {
                    // Start a page.
                    if (StartPagePrinter(hPrinter))
                    {
                        // Write your bytes.
                        bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                        EndPagePrinter(hPrinter);
                    }
                    EndDocPrinter(hPrinter);
                }
                ClosePrinter(hPrinter);
            }
            // If you did not succeed, GetLastError may give more information
            // about why not.
            if (bSuccess == false)
            {
                dwError = Marshal.GetLastWin32Error();
            }
            return bSuccess;
        }

        public static bool SendStringToPrinter(string szPrinterName, string szString)
        {
            IntPtr pBytes;
            Int32 dwCount;
            // How many characters are in the string?
            dwCount = szString.Length;
            // Assume that the printer is expecting ANSI text, and then convert
            // the string to ANSI text.
            pBytes = Marshal.StringToCoTaskMemAnsi(szString);
            // Send the converted ANSI string to the printer.
            SendBytesToPrinter(szPrinterName, pBytes, dwCount);
            Marshal.FreeCoTaskMem(pBytes);
            return true;
        }
    }



}
