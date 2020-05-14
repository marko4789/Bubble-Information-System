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
    public partial class frmClientes : Form
    {
        public frmClientes()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }


        MySqlConnection conexion = new MySqlConnection("server=localhost; database=dblavanderia; uid=root; pdw=;");
        MySqlCommand comando = new MySqlCommand();
        MySqlDataAdapter adaptador = new MySqlDataAdapter();

        private void frmClientes_Load(object sender, EventArgs e)  //ME PRESENTO SOY EL LOAD DE ESTA FORMA JAJA
        {
            llenarTabla();
            txtNumCliente.Text = obtenerFolio().ToString();
            cmbFiltro.SelectedIndex = 0;
            txtNombreCliente.Focus();


        }//fin Load

        public void limpiar()
        {

            txtNombreCliente.Text = "";
            txtApellidoPaterno.Text = "";
            txtApellidoMaterno.Text = "";
            txtTelefono.Text = "";
            cmbFiltro.SelectedIndex = 0;
            txtNombreCliente.Focus();
            txtNumCliente.Enabled = true;
            txtNumCliente.Text = obtenerFolio().ToString();
            txtDinamica.Text = "";

        }//fin limpiar

        public void llenarTabla()
        {
            String llenar = "Select numCliente,nombre,apellidoPaterno,apellidoMaterno,telefono from clientes where status = 0";
            MySqlDataAdapter adapter = new MySqlDataAdapter(llenar, conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewClientes.DataSource = table;
        }

        public void llenarTablaDes()    //llena el dataGridView con los campos que tienen estatus = 1
        {
            String llenar = "Select numCliente,nombre,apellidoPaterno,apellidoMaterno,telefono  from clientes where status = 1";
            MySqlDataAdapter adapter = new MySqlDataAdapter(llenar, conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridViewClientes.DataSource = table;


        }//fin llenar tabla Des


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
                MessageBox.Show("Solo se admiten letras","Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }//fin soloLetras


        public Boolean Existe()
        {
            Boolean existe = false;
            if (txtNumCliente.Text != "")
            {
                string sqlConsulta = "SELECT numCliente FROM clientes WHERE numCliente=?numCliente and status = 0";
                comando.Parameters.Clear();
                comando.Parameters.Add("?numCliente", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = txtNumCliente.Text;
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
            if (txtNumCliente.Text != "")
            {
                string sqlConsulta = "SELECT numCliente FROM clientes WHERE numCliente=?numCliente and status = 1";
                comando.Parameters.Clear();
                comando.Parameters.Add("?numCliente", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = txtNumCliente.Text;
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

        private void txtNumCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);

        }//fin evento keyPress en numCliente

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);

        }//fin evento KeyPress en nombreCliente

        private void txtApellidoPaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);

        }//fin evento KeyPress en apellidoPaterno del cliente

        private void txtApellidoMaterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);

        }//fin evento KeyPress en apellidoMaterno del cliente

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);

        }//fin evento KeyPress en telefono del cliente

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Boolean existe = Existe();
            Boolean existeDes = ExisteDes();

            if (existe || existeDes)
            {
                MessageBox.Show("El número de cliente ya existe", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }//fin existe

            else
            {
                if (txtNumCliente.Text != "" && txtNombreCliente.Text != "" && txtApellidoPaterno.Text != "" && txtTelefono.Text !="")
                {
                    String consulta = "insert into clientes (numCliente, nombre, apellidoPaterno, apellidoMaterno, telefono, status) values ('" + txtNumCliente.Text + "','" + txtNombreCliente.Text + "','" + txtApellidoPaterno.Text + "','" + txtApellidoMaterno.Text + "','" + txtTelefono.Text +"','"+ 0 + "');  ";

                    MySqlConnection conexion = new MySqlConnection("server=localhost; database=dblavanderia; uid=root; pdw=;");
                    MySqlCommand agregar = new MySqlCommand(consulta, conexion);
                    MySqlDataReader leer;
                    try
                    {
                        conexion.Open();
                        leer = agregar.ExecuteReader();
                        MessageBox.Show("Guardado con éxito", "Bubble Information Syste", MessageBoxButtons.OK, MessageBoxIcon.Information);
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


        }//fin agregar Cliente


        public int obtenerFolio()
        {
            string consulta = "SELECT MAX(numCliente) AS numCliente FROM clientes";
            int folio;

            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion);
            DataTable aux = new DataTable();
            adapter.Fill(aux);
            DataRow row = aux.Rows[0];
            folio = Convert.ToInt32(row["numCliente"]);
            folio++;



            return folio;
        }//fin obtener folio

        private void btnLogo_Click(object sender, EventArgs e)
        {

            this.Refresh();
            limpiar();
            llenarTabla();

        }//fin btnLogo

        private void dataGridViewClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            txtNumCliente.Text = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString();
            txtNumCliente.Enabled = false;
            txtNombreCliente.Text = dataGridViewClientes.CurrentRow.Cells[1].Value.ToString();
            txtApellidoPaterno.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString();
            txtApellidoMaterno.Text = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString();
            txtTelefono.Text = dataGridViewClientes.CurrentRow.Cells[4].Value.ToString();

        }//fin clic registro en DataGridView

        private void txtDinamica_TextChanged(object sender, EventArgs e)
        {

            if (rdbOff.Checked == false)
            {

               
                String consulta = "select numCliente, nombre, apellidoPaterno, apellidoMaterno,Telefono from clientes where " + cmbFiltro.Text + " like '%" + txtDinamica.Text + "%' and status=0";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                conexion.Open();
                DataSet datos = new DataSet();
                adaptador.Fill(datos, "clientes");
                dataGridViewClientes.DataSource = datos;
                dataGridViewClientes.DataMember = "clientes";
                conexion.Close();

            }
            else
            {

                
                String consulta = "select numCliente, nombre, apellidoPaterno, apellidoMaterno,Telefono from clientes where " + cmbFiltro.Text + " like '%" + txtDinamica.Text + "%' and status=1";
                MySqlDataAdapter adaptador = new MySqlDataAdapter(consulta, conexion);
                conexion.Open();
                DataSet datos = new DataSet();
                adaptador.Fill(datos, "clientes");
                dataGridViewClientes.DataSource = datos;
                dataGridViewClientes.DataMember = "clientes";
                conexion.Close();





            }//fin else


        }//fin busqueda dinamica

        private void btnBuscar_Click(object sender, EventArgs e)
        {

            Boolean existe = Existe();

            if (existe)
            {
                DataTable datos = new DataTable();
                string consulta = "select numCliente,nombre,apellidoPaterno,apellidoMaterno,telefono from clientes where numCliente=?numCliente and status=0";
                conexion.Open();
                comando.Parameters.Clear();
                comando.Parameters.Add("?numCliente", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = txtNumCliente.Text;
                comando.Connection = conexion;
                comando.CommandText = consulta;
                adaptador.SelectCommand = comando;
                adaptador.Fill(datos);
                conexion.Close();
                dataGridViewClientes.DataSource = datos;


                txtNumCliente.Text = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString();
                txtNumCliente.Enabled = false;
                txtNombreCliente.Text = dataGridViewClientes.CurrentRow.Cells[1].Value.ToString();
                txtApellidoPaterno.Text = dataGridViewClientes.CurrentRow.Cells[2].Value.ToString();
                txtApellidoMaterno.Text = dataGridViewClientes.CurrentRow.Cells[3].Value.ToString();
                txtTelefono.Text = dataGridViewClientes.CurrentRow.Cells[4].Value.ToString();

            }//fin si Existe

            else
            {
                MessageBox.Show("No existe el registro o está deshabilitado", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                llenarTabla();
                limpiar();

            }//fin si no existe

        }//fin buscar Cliente

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {

            Boolean existe = Existe();
            if (existe)
            {
                DialogResult resul;
                resul = MessageBox.Show("¿Está seguro que desea deshabilitar el registro " + txtNumCliente.Text+"?", "Bubble Informatio System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    string consulta = "update clientes set status=1 where numCliente=?numCliente and status=0";
                    comando.Parameters.Clear();
                    comando.Parameters.Add("?numCliente", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = txtNumCliente.Text;
                    conexion.Open();
                    comando.Connection = conexion;
                    comando.CommandText = consulta;
                    comando.ExecuteNonQuery();
                    conexion.Close();

                    MessageBox.Show("Deshabilitado con éxito", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }//fin confirmacion borrar registro

                limpiar();
                this.Refresh();
                llenarTabla();
            }//fin existe desabilitado
            else
                MessageBox.Show("El registro que intenta deshabilitar no existe", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);



        }//fin deshabilitar Cliente

        private void btnActualizar_Click(object sender, EventArgs e)
        {

            Boolean existe = Existe();

            if (existe)
            {
                if (txtNumCliente.Text != "" && txtNombreCliente.Text != "" && txtApellidoPaterno.Text != "" && txtTelefono.Text !="")
                {
                    string consulta = "Update clientes set numCliente=?numCliente, nombre=?nombre, apellidoPaterno=?apellidoPaterno, apellidoMaterno=?apellidoMaterno, telefono=?telefono where status=0 and  numCliente=?numCliente";
                    comando.Parameters.Clear();
                    comando.Parameters.Add("?numCliente", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = txtNumCliente.Text;
                    comando.Parameters.Add("?nombre", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = txtNombreCliente.Text;
                    comando.Parameters.Add("?apellidoPaterno", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = txtApellidoPaterno.Text;
                    comando.Parameters.Add("?apellidoMaterno", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = txtApellidoMaterno.Text;
                    comando.Parameters.Add("?telefono", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = txtTelefono.Text;

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

                MessageBox.Show("El registro no existe", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }//fin si no existe
            llenarTabla();
            limpiar();
            this.Refresh();


        }//fin botón actualizar

        private void rdbOff_CheckedChanged(object sender, EventArgs e)
        {
            llenarTablaDes();
            txtNumCliente.Enabled = false;
            txtNombreCliente.Enabled = false;
            txtApellidoPaterno.Enabled = false;
            txtApellidoMaterno.Enabled = false;
            txtTelefono.Enabled = false;
            btnAgregar.Enabled = false;
            btnActualizar.Enabled = false;
            btnDeshabilitar.Enabled = false;
            btnBuscar.Enabled = false;
            btnLogo.Enabled = false;

        }//fin radioButton apagado

        private void rdbOn_CheckedChanged(object sender, EventArgs e)
        {

            txtNumCliente.Enabled = true;
            txtNombreCliente.Enabled = true;
            txtApellidoPaterno.Enabled = true;
            txtApellidoMaterno.Enabled = true;
            txtTelefono.Enabled = true;
            btnAgregar.Enabled = true;
            btnActualizar.Enabled = true;
            btnDeshabilitar.Enabled = true;
            btnBuscar.Enabled = true;
            btnLogo.Enabled = true;

            limpiar();
            llenarTabla();
            this.Refresh();


        }//fin radioButton encendido
    }//fin frmClientes
}//fin del todo
