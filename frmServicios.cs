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
    public partial class frmServicios : Form
    {
       

        public void limpiar()
        {
            txtNumSer.Text = "";
            txtNombreSer.Text = "";
            cmbFormaCobro.SelectedIndex = 0;
            cmbFiltro.SelectedIndex = 0;
            txtPrecio.Text = "";
            txtNombreSer.Focus();
            txtDinamica.Text = "";
            txtNumSer.Text = obtenerFolio().ToString();
            txtNumSer.Enabled = true;
        }

        public void llenarTabla()
        {
            String llenar = "Select numServicio,nombre,formaCobro,precio from servicios where status = 0";
            MySqlDataAdapter adapter = new MySqlDataAdapter(llenar, conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewServicios.DataSource = table;
        }

        public void llenarTablaDes()    //llena el dataGridView con los campos que tienen estatus = 1
        {
            String llenar = "Select numServicio,nombre,formaCobro,precio from servicios where status = 1";
            MySqlDataAdapter adapter = new MySqlDataAdapter(llenar, conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewServicios.DataSource = table;


        }//fin llenar tabla Des


        MySqlConnection conexion = new MySqlConnection("server=localhost; database=dblavanderia; uid=root; pdw=;");
        MySqlCommand comando = new MySqlCommand();
        MySqlDataAdapter adaptador = new MySqlDataAdapter();

        public frmServicios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtNumSer_TextChanged(object sender, EventArgs e)
        {
            //NUMERO DEL SERVICIO 
            //this.numSer= int.Parse(txtNumSer.Text);
        }

        private void frmServicios_Load(object sender, EventArgs e)  //LOAD AQUI ESTOY NMMS A VER SI ME ENCUENTRAS
        {
            llenarTabla();

            //btnAgregar.Enabled = false;
            //limpiar();
           
            txtNumSer.Text = obtenerFolio().ToString();
            cmbFormaCobro.SelectedIndex = 0;
            cmbFiltro.SelectedIndex = 0;
            txtNombreSer.Focus();

        }

        private void cmbFormaCobro_SelectedIndexChanged(object sender, EventArgs e)
        {
            //this.formaCobro = cmbFormaCobro.Text;
        }

        private void txtNombreSer_TextChanged(object sender, EventArgs e)
        {
            //this.nombreSer = txtNombreSer.Text.ToString();
        }

        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            //this.precio = double.Parse(txtPrecio.Text);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Boolean existe = Existe();
            Boolean existeDes = ExisteDes();

            if (existe||existeDes)
            {
                MessageBox.Show("El número de servicio ya existe", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }//fin existe

            else
            {
                if (txtNumSer.Text != "" && txtNombreSer.Text != "" && txtPrecio.Text != "") {
                    String consulta = "insert into servicios (numServicio, nombre, formaCobro, precio, status) values ('" + txtNumSer.Text + "','" + txtNombreSer.Text + "','" + cmbFormaCobro.Text + "','" + txtPrecio.Text + "','" + 0 + "');  ";

                    MySqlConnection conexion = new MySqlConnection("server=localhost; database=dblavanderia; uid=root; pdw=;");
                    MySqlCommand agregar = new MySqlCommand(consulta, conexion);
                    MySqlDataReader leer;
                    try
                    {
                        conexion.Open();
                        leer = agregar.ExecuteReader();
                        MessageBox.Show("Guardado con éxito","Bubble Information Syste",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        while (leer.Read())
                        {

                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                    limpiar();
                    llenarTabla();
                    this.Refresh();
                    MessageBox.Show("El registro ha sido agregado correctamente", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }//fin si campos están llenos
                else
                    MessageBox.Show("Faltan campos por llenar", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }//fin si no existe
            

        }//fin btn agregar

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
                MessageBox.Show("Sólo números enteros","Bubble Information System",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }//fin soloNumeros



        public static void SoloLetras(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
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
                MessageBox.Show("Solo se admiten letras");
            }
        }//fin soloLetras



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
                MessageBox.Show("Sólo números o números con punto decimal","Bubble Information System", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }//fin soloNumerosDecimales




        private void txtNumSer_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumerosDecimales(e);
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Boolean existe = Existe();

            if (existe)
            {
                if (txtNumSer.Text != "" && txtNombreSer.Text != "" && txtPrecio.Text != "")
                {
                    string consulta = "Update servicios set numServicio=?numServicio, nombre=?nombre, formaCobro=?formaCobro, precio=?precio where status=0 and  numServicio=?numServicio";
                    comando.Parameters.Clear();
                    comando.Parameters.Add("?numServicio", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = txtNumSer.Text;
                    comando.Parameters.Add("?nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = txtNombreSer.Text;
                    comando.Parameters.Add("?formaCobro", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = cmbFormaCobro.Text;
                    comando.Parameters.Add("?precio", MySql.Data.MySqlClient.MySqlDbType.Float).Value = txtPrecio.Text;
                    conexion.Open();
                    comando.Connection = conexion;
                    comando.CommandText = consulta;
                    comando.ExecuteNonQuery();
                    conexion.Close();


                    MessageBox.Show("Registro modificado con éxito", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("No se puede actualizar con campos vacíos", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
            }//fin si existe

            else
            {

                MessageBox.Show("El registro no existe","Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//fin si no existe
            llenarTabla();
            limpiar();
            this.Refresh();

        }//fin actualizar


        public Boolean Existe()
        {
            Boolean existe = false;
            if (txtNumSer.Text != "")
            {
                string sqlConsulta = "SELECT numServicio FROM servicios WHERE numServicio=?numServicio and status = 0";
                comando.Parameters.Clear();
                comando.Parameters.Add("?numServicio", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = txtNumSer.Text;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = sqlConsulta;
                MySqlDataReader cursor;
                cursor = comando.ExecuteReader();
                if (cursor.Read()) existe = true;
                conexion.Close();
            }//fin si no está vacío
            return existe;

        }//fin existe

        public Boolean ExisteDes()
        {

            Boolean existe = false;
            if (txtNumSer.Text != "")
            {
                string sqlConsulta = "SELECT numServicio FROM servicios WHERE numServicio=?numServicio and status = 1";
                comando.Parameters.Clear();
                comando.Parameters.Add("?numServicio", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = txtNumSer.Text;
                conexion.Open();
                comando.Connection = conexion;
                comando.CommandText = sqlConsulta;
                MySqlDataReader cursor;
                cursor = comando.ExecuteReader();
                if (cursor.Read()) existe = true;
                conexion.Close();
            }//fin si no está vacío
            return existe;

        }//fin existe




        private void button1_Click(object sender, EventArgs e)
        {
            //BUSCAR    

            Boolean existe = Existe();

            if (existe)
            {
                DataTable datos = new DataTable();
                string consulta = "select numServicio,nombre,formaCobro,precio from servicios where numServicio=?numServicio and status=0";
                conexion.Open();
                comando.Parameters.Clear();
                comando.Parameters.Add("?numServicio", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = txtNumSer.Text;
                comando.Connection = conexion;
                comando.CommandText = consulta;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                conexion.Close();
                dataGridViewServicios.DataSource = datos;


                txtNumSer.Text = dataGridViewServicios.CurrentRow.Cells[0].Value.ToString();
                txtNumSer.Enabled = false;
                txtNombreSer.Text = dataGridViewServicios.CurrentRow.Cells[1].Value.ToString();
                cmbFormaCobro.Text = dataGridViewServicios.CurrentRow.Cells[2].Value.ToString();
                txtPrecio.Text = dataGridViewServicios.CurrentRow.Cells[3].Value.ToString();


            }//fin si Existe

            else
            {
                MessageBox.Show("No existe el registro o está deshabilitado","Bubble Information System",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                llenarTabla();
                limpiar();

            }//fin si no existe



        }//fin buscar

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtNumSer.Enabled = true;
            this.Refresh();
            limpiar();
            llenarTabla();

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


        public void consultaDinamica(String busqueda, DataGridView filtro)
        {

        
        }//fin ConsultaDinamica

        private void txtDinamica_TextChanged(object sender, EventArgs e)
        {
            if (rdbStatusDown.Checked == false)
            {

                MySqlConnection con = new MySqlConnection();
                String consulta = "select numServicio, nombre, formaCobro,precio from servicios where " + cmbFiltro.Text + " like '%" + txtDinamica.Text + "%' and status=0";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                conexion.Open();
                DataSet datos = new DataSet();
                adaptador.Fill(datos, "servicios");
                dataGridViewServicios.DataSource = datos;
                dataGridViewServicios.DataMember = "servicios";
                conexion.Close();

            }
            else
            {


                MySqlConnection con = new MySqlConnection();
                String consulta = "select numServicio, nombre, formaCobro,precio from servicios where " + cmbFiltro.Text + " like '%" + txtDinamica.Text + "%' and status=1";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                conexion.Open();
                DataSet datos = new DataSet();
                adaptador.Fill(datos, "servicios");
                dataGridViewServicios.DataSource = datos;
                dataGridViewServicios.DataMember = "servicios";
                conexion.Close();



            }//fin else


        }//fin txtDinamica

        private void dataGridViewServicios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
            txtNumSer.Text = dataGridViewServicios.CurrentRow.Cells[0].Value.ToString();
            txtNumSer.Enabled = false;
            txtNombreSer.Text = dataGridViewServicios.CurrentRow.Cells[1].Value.ToString();
            cmbFormaCobro.Text = dataGridViewServicios.CurrentRow.Cells[2].Value.ToString();
            txtPrecio.Text = dataGridViewServicios.CurrentRow.Cells[3].Value.ToString();
            
            

        }//fin evento cellContentClick

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            Boolean existe = Existe();
            if (existe)
            {
                DialogResult resul;
                resul = MessageBox.Show("¿Está seguro que desea deshabilitar el registro " + txtNumSer.Text, "Bubble Informatio System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    string consulta = "update servicios set status=1 where numServicio=?numServicio and status=0";
                    comando.Parameters.Clear();
                    comando.Parameters.Add("?numServicio", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = txtNumSer.Text;
                    conexion.Open();
                    comando.Connection = conexion;
                    comando.CommandText = consulta;
                    comando.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Deshabilitado con éxito","Bubble Information System",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    
                }//fin confirmacion borrar registro

                limpiar();
                this.Refresh();
                llenarTabla();
            }//fin existe desabilitado
            else
                MessageBox.Show("El registro que intenta deshabilitar no existe", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }//fin deshabilitar

        private void rdbStatusDown_CheckedChanged(object sender, EventArgs e)
        {

            llenarTablaDes();
            txtNombreSer.Enabled = false;
            txtNumSer.Enabled = false;
            txtPrecio.Enabled = false;
            cmbFormaCobro.Enabled = false;
            btnActualizar.Enabled = false;
            btnAgregar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnBuscar.Enabled = false;
            btnLogo.Enabled = false;

        }//fin rdb StatusDown

        private void rdbStatusUp_CheckedChanged(object sender, EventArgs e)
        {
            this.Refresh();
            llenarTabla();
            limpiar();

            txtNombreSer.Enabled = true;
            txtNumSer.Enabled = true;
            txtPrecio.Enabled = true;
            cmbFormaCobro.Enabled = true;
            btnActualizar.Enabled = true;
            btnAgregar.Enabled = true;
            btnDeshabilitar.Enabled = true;
            btnBuscar.Enabled = true;
            btnLogo.Enabled = true;

        }//fin rdb StatusUp



        public int obtenerFolio()
        {
            string consulta = "SELECT MAX(numServicio) AS numServicio FROM servicios";
            int folio;

            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion);
            DataTable aux = new DataTable();
            adapter.Fill(aux);
            DataRow row = aux.Rows[0];
            folio = Convert.ToInt32(row["numServicio"]);
            folio++;

            

            return folio;
        }//fin obtener folio

    }
}
