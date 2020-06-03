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
    public partial class Usuarios : Form
    {

        public Usuarios()
        {
            InitializeComponent();


        }

        MySqlConnection conexion = new MySqlConnection("server=localhost; database=dblavanderia; uid=root; pdw=;");
        MySqlCommand comando = new MySqlCommand();
        MySqlDataAdapter adaptador = new MySqlDataAdapter();
        int selectedRow;


        private void Usuarios_Load(object sender, EventArgs e)
        {
            llenarTabla();
            txtbNumUs.Text = obtenerFolio().ToString();

            txtbNomUs.Focus();

            conexion.Open();
            MySqlCommand comando = new MySqlCommand("SELECT numEmpleado, nombre FROM empleados WHERE status = 0", conexion);
            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
            DataTable dt = new DataTable();
            adaptador.Fill(dt);
            conexion.Close();

            DataRow fila = dt.NewRow();
            fila["nombre"] = "Empleado";
            dt.Rows.InsertAt(fila, 0);

            cmbEmple.ValueMember = "numEmpleado";
            cmbEmple.DisplayMember = "nombre";
            cmbEmple.DataSource = dt;

        }

        private void bttnAgregar_Click(object sender, EventArgs e)
        {
            Boolean existe = Existe();
            Boolean existeDes = ExisteDes();

            if (existe || existeDes)
            {
                MessageBox.Show("El número de usuario ya existe", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }//fin existe

            else
            {
                if (txtbNumUs.Text != "" && txtbNomUs.Text != "" && cmbTipoUs.Text != "" && cmbEmple.Text != "" && txtbContra.Text != "")
                {
                    String consulta = "INSERT INTO usuario (numUsuario, nombreUsuario, contraseña, tipoUsuario, status, numEmpleado) VALUES('" + this.txtbNumUs.Text + "','" + this.txtbNomUs.Text + "','" + this.txtbContra.Text + "','" + this.cmbTipoUs.Text + "','" + 0 + "','" + this.cmbEmple.SelectedValue + "'); ";
                    MySqlConnection conexion = new MySqlConnection("server=localhost; database=dblavanderia; uid=root; pdw=;");
                    MySqlCommand agregar = new MySqlCommand(consulta, conexion);
                    MySqlDataReader leer;
                    try
                    {
                        conexion.Open();
                        leer = agregar.ExecuteReader();
                        MessageBox.Show("Guardado");
                        while (leer.Read())
                        {

                        }
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }


                    llenarTabla();
                    this.Refresh();
                    MessageBox.Show("El registro ha sido agregado correctamente", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }//fin si campos están llenos
                else
                    MessageBox.Show("Faltan campos por llenar", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }//fin si no existe


        }//fin agregar Usuarios

        //Actualizar Datos Usuarios
        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            String Query = "UPDATE usuario SET numUsuario= '" + txtbNumUs.Text + "',nombreUsuario= '" + txtbNomUs.Text + "',contraseña= '" + txtbContra.Text + "',tipoUsuario= '" + cmbTipoUs.Text + "',status= '" + 0 + "',numEmpleado= '" + cmbEmple.SelectedValue + "' WHERE numUsuario= '" + txtbNumUs.Text + "';";
            MySqlCommand comando = new MySqlCommand(Query, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();

            MessageBox.Show("Los datos se han actualizado correctamente");
            llenarTabla();
            this.Refresh();
        }//Fin Actualizar Datos Usuarios

        private void bttnDeshab_Click(object sender, EventArgs e)//eliminar registro de usuario
        {
            Boolean existe = Existe();
            if (existe)
            {
                DialogResult resul;
                resul = MessageBox.Show("¿Está seguro que desea deshabilitar el registro " + txtbNumUs.Text + "?", "Bubble Informatio System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resul == DialogResult.Yes)
                {
                    string consulta = "update usuario set status=1 where numUsuario=?numUsuario and status=0";
                    comando.Parameters.Clear();
                    comando.Parameters.Add("?numUsuario", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = txtbNumUs.Text;
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





            }//fin If
            else
                MessageBox.Show("El registro que intenta deshabilitar no existe", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

        }//fin Deshabilitar Usuario

        private void bttnBuscar_Click(object sender, EventArgs e)
        {

            string buscar = "select * from usuario where status=0 and numEmpleado ='" + this.txtbusqueda.Text + "';";
            MySqlDataAdapter adapter = new MySqlDataAdapter(buscar, conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

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
                MessageBox.Show("Ingrese la clave de solamente números enteros", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("Solo se admiten letras", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        public static void SoloNumyLetr(KeyPressEventArgs v)
        {
            if (Char.IsLetter(v.KeyChar))
            {
                v.Handled = false;
            }
            else if (Char.IsDigit(v.KeyChar))
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
                MessageBox.Show("Solo se admiten letras y numeros, no se admite el espacio", "Bubble Information System", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }//solo letras y numeros sin espacios

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbNumUs_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoUs_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        

        private void cxbEstatus_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbEmple_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                txtbNumUs.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

                txtbNomUs.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                cmbTipoUs.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                cmbEmple.SelectedValue = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                txtbContra.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

                selectedRow = e.RowIndex;
            }
            catch { 
            }
        }

        private void txtbContra_TextChanged(object sender, EventArgs e)
        {

        }

        

        public void buscar(string abuscar)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtbNumUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }//Validacion Numero de usuario

        private void txtbNomUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumyLetr(e);
        }//Validacion Nombre de usuario

        private void cmbTipoUs_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetras(e);
        }//Validacion tipo de usuario

        private void cmbEmple_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtbContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumyLetr(e);
        }//Validacion contraseña de usuario

        public int obtenerFolio()
        {
            string consulta = "SELECT MAX(numUsuario) AS numUsuario FROM usuario";
            int folio;

            MySqlDataAdapter adapter = new MySqlDataAdapter(consulta, conexion);
            DataTable aux = new DataTable();
            adapter.Fill(aux);
            DataRow row = aux.Rows[0];
            folio = Convert.ToInt32(row["numUsuario"]);
            folio++;



            return folio;
        }//fin obtener folio

        public void llenarTabla()
        {
            String llenar = "Select numUsuario,nombreUsuario,contraseña,tipoUsuario,numEmpleado from usuario where status = 0";
            MySqlDataAdapter adapter = new MySqlDataAdapter(llenar, conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public void llenarTablaDes()    //llena el dataGridView con los campos que tienen estatus = 1
        {
            String llenar = "Select numUsuario,nombreUsuario,contraseña,tipoUsuario,numEmpleado from usuario where status = 1";
            MySqlDataAdapter adapter = new MySqlDataAdapter(llenar, conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;


        }//fin llenar tabla Des


        public Boolean ExisteDes()
        {

            Boolean existe = false;
            if (txtbNumUs.Text != "")
            {
                string sqlConsulta = "SELECT numUsuario FROM usuario WHERE numUsuario=?numUsuario and status = 1";
                comando.Parameters.Clear();
                comando.Parameters.Add("?numUsuario", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = txtbNumUs.Text;
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

        public Boolean Existe()
        {

            Boolean existe = false;
            if (txtbNumUs.Text != "")
            {
                string sqlConsulta = "SELECT numUsuario FROM usuario WHERE numUsuario=?numUsuario and status = 0";
                comando.Parameters.Clear();
                comando.Parameters.Add("?numUsuario", MySql.Data.MySqlClient.MySqlDbType.Int32).Value = txtbNumUs.Text;
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

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            string filtrar = "select * from usuario where status=0";
            MySqlDataAdapter adapter = new MySqlDataAdapter(filtrar, conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            txtbNumUs.Enabled = true;
            txtbNumUs.Enabled = true;
            cmbTipoUs.Enabled = true;
            cmbEmple.Enabled = true;
            txtbContra.Enabled = true;
            bttnAgregar.Enabled = true;
            bttnActualizar.Enabled = true;
            bttnDeshab.Enabled = true;

            limpiar();
            llenarTabla();
            this.Refresh();
        }

        private void txtbusqueda_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumeros(e);
        }//Validacion de busqueda

        private void rdbStatusDown_CheckedChanged(object sender, EventArgs e)
        {
            llenarTablaDes();

            txtbNumUs.Enabled = false;
            txtbNumUs.Enabled = false;
            cmbTipoUs.Enabled = false;
            cmbEmple.Enabled = false;
            txtbContra.Enabled = false;
            bttnAgregar.Enabled = false;
            bttnActualizar.Enabled = false;
            bttnDeshab.Enabled = false;
        }
        public void limpiar()
        {

            txtbNomUs.Text = "";
            cmbTipoUs.Text = "";
            cmbEmple.SelectedValue = 0;
            txtbContra.Text = "";
            txtbNomUs.Focus();
            txtbNumUs.Enabled = true;
            txtbNumUs.Text = obtenerFolio().ToString();
            

        }//fin limpiar

        private void Logo_Click(object sender, EventArgs e)
        {
            this.Refresh();
            limpiar();
            llenarTabla();
        }

        public void busqueda(string abuscar)
        {
            if (rdbStatusDown.Checked == false)
            {
                string buscar = "select * from usuario where status=0 and CONCAT(numUsuario, nombreUsuario)like '%" + abuscar + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(buscar, conexion);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else
            {
                string buscar = "select * from usuario where status=1 and CONCAT(numUsuario, nombreUsuario)like '%" + abuscar + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(buscar, conexion);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }//fin busquedaDin

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {
            busqueda(txtbusqueda.Text);
        }
    }
}
