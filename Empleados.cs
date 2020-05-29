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
using System.Text.RegularExpressions;

namespace Bubble_Information_System
{
    public partial class Empleados : Form
    {
        MySqlConnection conexion = new MySqlConnection("server=localhost; database=dblavanderia; uid=root; pdw=;");
        int selectedRow;
        String nombreespacio;
        
        

        public Empleados()
        {
            InitializeComponent();
        }





        private void Empleados_Load(object sender, EventArgs e)
        {
            string filtrar = "select * from empleados where status=0";
            MySqlDataAdapter adapter = new MySqlDataAdapter(filtrar, conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            btnAgregar.Enabled = false;
            textNumE.Enabled = false;
        }
        
        private void controlNombre()
        {


            if (textNombre.Text.Trim() != string.Empty && Regex.IsMatch(textNombre.Text, "^[A-Z a-z]*$") && textApeP.Text.Trim() != string.Empty && textApeP.Text.All(Char.IsLetter) && textApeM.Text.Trim() != string.Empty && textApeM.Text.All(Char.IsLetter) && textTelefono.Text.Trim() != string.Empty && textTelefono.Text.All(Char.IsNumber) && textDir.Text.Trim() != string.Empty)
            {
                btnAgregar.Enabled = true;

            }

            if (textNombre.Text.Trim() != string.Empty && Regex.IsMatch(textNombre.Text, "^[A-Z a-z]*$"))
            {
                errorProvider1.SetError(textNombre, "");
            }
            else
            {
                if (!Regex.IsMatch(textNombre.Text, "^[A-Z a-z]*$"))
                {
                    errorProvider1.SetError(textNombre, "El nombre solo debe contener letras");
                }
                else
                {
                    errorProvider1.SetError(textNombre, "Debe introducir su nombre");
                }
                btnAgregar.Enabled = false;
                textNombre.Focus();
            }
        }

        /*private void controlNumE()
        {
            if (textNombre.Text.Trim() != string.Empty && textNombre.Text.All(Char.IsLetter) && textApeP.Text.Trim() != string.Empty && textApeP.Text.All(Char.IsLetter) && textApeM.Text.Trim() != string.Empty && textApeM.Text.All(Char.IsLetter) && textNumE.Text.Trim() != string.Empty && textNumE.Text.All(Char.IsNumber) && textTelefono.Text.Trim() != string.Empty && textTelefono.Text.All(Char.IsNumber) && textDir.Text.Trim() != string.Empty)
            {
                btnAgregar.Enabled = true;

            }

            if (textNumE.Text.Trim() != string.Empty && textNumE.Text.All(Char.IsNumber))
            {
                errorProvider1.SetError(textNumE, "");
            }
            else
            {
                if (!textNumE.Text.All(Char.IsNumber))
                {
                    errorProvider1.SetError(textNumE, "El numero de empleado solo debe  contener digitos");
                }
                else
                {
                    errorProvider1.SetError(textNumE, "Debe introducir el numero de empleado");
                }
                btnAgregar.Enabled = false;
                textNumE.Focus();
            }
        }*/

        private void controlApeP()
        {

            if (textNombre.Text.Trim() != string.Empty && Regex.IsMatch(textNombre.Text, "^[A-Z a-z]*$") && textApeP.Text.Trim() != string.Empty && textApeP.Text.All(Char.IsLetter) && textApeM.Text.Trim() != string.Empty && textApeM.Text.All(Char.IsLetter) && textTelefono.Text.Trim() != string.Empty && textTelefono.Text.All(Char.IsNumber) && textDir.Text.Trim() != string.Empty)
            {
                btnAgregar.Enabled = true;

            }

            if (textApeP.Text.Trim() != string.Empty && textApeP.Text.All(Char.IsLetter))
            {
                errorProvider1.SetError(textApeP, "");
            }
            else
            {
                if (!textApeP.Text.All(Char.IsLetter))
                {
                    errorProvider1.SetError(textApeP, "Los apellidos solo deben contener letras");
                }
                else
                {
                    errorProvider1.SetError(textApeP, "Debe introducir su apellido paterno");
                }
                btnAgregar.Enabled = false;
                textApeP.Focus();
            }
        }

        private void controlApeM()
        {

            if (textNombre.Text.Trim() != string.Empty && Regex.IsMatch(textNombre.Text, "^[A-Z a-z]*$") && textApeP.Text.Trim() != string.Empty && textApeP.Text.All(Char.IsLetter) && textApeM.Text.Trim() != string.Empty && textApeM.Text.All(Char.IsLetter) && textTelefono.Text.Trim() != string.Empty && textTelefono.Text.All(Char.IsNumber) && textDir.Text.Trim() != string.Empty)
            {
                btnAgregar.Enabled = true;

            }

            if (textApeM.Text.Trim() != string.Empty && textApeM.Text.All(Char.IsLetter))
            {
                errorProvider1.SetError(textApeM, "");
            }
            else
            {
                if (!textApeM.Text.All(Char.IsLetter))
                {
                    errorProvider1.SetError(textApeM, "Los apellidos solo deben contener letras");
                }
                else
                {
                    errorProvider1.SetError(textApeM, "Debe introducir su apellido materno");
                }
                btnAgregar.Enabled = false;
                textApeM.Focus();
            }
        }

        private void controlTelefono()
        {
            if (textNombre.Text.Trim() != string.Empty && Regex.IsMatch(textNombre.Text, "^[A-Z a-z]*$") && textApeP.Text.Trim() != string.Empty && textApeP.Text.All(Char.IsLetter) && textApeM.Text.Trim() != string.Empty && textApeM.Text.All(Char.IsLetter) && textTelefono.Text.Trim() != string.Empty && textTelefono.Text.All(Char.IsNumber) && textDir.Text.Trim() != string.Empty)
            {
                btnAgregar.Enabled = true;

            }

            if (textTelefono.Text.Trim() != string.Empty && textTelefono.Text.All(Char.IsNumber))
            {
                errorProvider1.SetError(textTelefono, "");
            }
            else
            {
                if (!textTelefono.Text.All(Char.IsNumber))
                {
                    errorProvider1.SetError(textTelefono, "El numero de telefono solo debe  contener digitos");
                }
                else
                {
                    errorProvider1.SetError(textTelefono, "Debe introducir el numero de telefono");
                }
                btnAgregar.Enabled = false;
                textTelefono.Focus();
            }
        }

        private void controlDir()
        {

            if (textNombre.Text.Trim() != string.Empty && Regex.IsMatch(textNombre.Text, "^[A-Z a-z]*$") && textApeP.Text.Trim() != string.Empty && textApeP.Text.All(Char.IsLetter) && textApeM.Text.Trim() != string.Empty && textApeM.Text.All(Char.IsLetter) && textTelefono.Text.Trim() != string.Empty && textTelefono.Text.All(Char.IsNumber) && textDir.Text.Trim() != string.Empty)
            {
                btnAgregar.Enabled = true;

            }

            if (textDir.Text.Trim() != string.Empty)
            {
                errorProvider1.SetError(textDir, "");
            }
            else
            {
                errorProvider1.SetError(textDir, "Debe introducir la dirección");
                btnAgregar.Enabled = false;
                textDir.Focus();
            }
        }

        private void textNumE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            
            controlNombre();
        }

        private void textApeP_TextChanged(object sender, EventArgs e)
        {
            controlApeP();
        }

        private void textApeM_TextChanged(object sender, EventArgs e)
        {
            controlApeM();
        }

        private void textTelefono_TextChanged(object sender, EventArgs e)
        {
            controlTelefono();
        }

        private void textDir_TextChanged(object sender, EventArgs e)
        {
            controlDir();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            String consulta = "INSERT INTO empleados (nombre, apellidoPaterno, apellidoMaterno,telefono, direccion, status) VALUES('" + this.textNombre.Text + "','" + this.textApeP.Text + "','" + this.textApeM.Text + "','" + this.textTelefono.Text + "','" + this.textDir.Text + "','" + 0 + "'); ";
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
                leer.Close();
                string filtrar = "select * from empleados where status=0";
                MySqlDataAdapter adapter = new MySqlDataAdapter(filtrar, conexion);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }

            catch (Exception ex)
            {
                MessageBox.Show("El numero de empleado ya esta en uso");
            }



        }



        public void buscar(string abuscar)
        {
            if (rdbStatusDown.Checked == false)
            {
                string buscar = "select * from empleados where status=0 and CONCAT(numEmpleado,nombre,apellidoPaterno,apellidoMaterno)like '%" + abuscar + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(buscar, conexion);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else
            {
                string buscar = "select * from empleados where status=1 and CONCAT(numEmpleado,nombre,apellidoPaterno,apellidoMaterno)like '%" + abuscar + "%'";
                MySqlDataAdapter adapter = new MySqlDataAdapter(buscar, conexion);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
        }

        private void textbusqueda_TextChanged(object sender, EventArgs e)
        {
            buscar(textbusqueda.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textNumE.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();

            textNombre.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textApeP.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textApeM.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textTelefono.Text= dataGridView1.CurrentRow.Cells[4].Value.ToString();
            textDir.Text= dataGridView1.CurrentRow.Cells[5].Value.ToString();
            selectedRow = e.RowIndex;
        }
        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            String consulta = "UPDATE empleados SET nombre='" + this.textNombre.Text + "',apellidoPaterno='" + this.textApeP.Text + "',apellidoMaterno='" + this.textApeM.Text + "',telefono='" + this.textTelefono.Text + "',direccion='" + this.textDir.Text + "' WHERE numEmpleado ='" + this.dataGridView1.Rows[selectedRow].Cells[0].Value.ToString() + "';";
            MySqlConnection conexion = new MySqlConnection("server=localhost; database=dblavanderia; uid=root; pdw=;");
            MySqlCommand actualizar = new MySqlCommand(consulta, conexion);
            MySqlDataReader leer;
            try
            {
                conexion.Open();
                leer = actualizar.ExecuteReader();
                MessageBox.Show("Guardado");




                while (leer.Read())
                {

                }
                leer.Close();
                string filtrar = "select * from empleados where status=0";
                MySqlDataAdapter adapter = new MySqlDataAdapter(filtrar, conexion);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btn_deshabilitar_Click(object sender, EventArgs e)
        {

            String consulta = "UPDATE empleados SET status=1 WHERE numEmpleado ='" + this.dataGridView1.Rows[selectedRow].Cells[0].Value.ToString() + "';";
            MySqlConnection conexion = new MySqlConnection("server=localhost; database=dblavanderia; uid=root; pdw=;");
            MySqlCommand actualizar = new MySqlCommand(consulta, conexion);
            MySqlDataReader leer;
            try
            {
                conexion.Open();
                leer = actualizar.ExecuteReader();
                MessageBox.Show("Guardado");




                while (leer.Read())
                {

                }
                leer.Close();
                string filtrar = "select * from empleados where status=0";
                MySqlDataAdapter adapter = new MySqlDataAdapter(filtrar, conexion);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void rdbStatusUp_CheckedChanged(object sender, EventArgs e)
        {
            string filtrar = "select * from empleados where status=0";
            MySqlDataAdapter adapter = new MySqlDataAdapter(filtrar, conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            
            textNombre.Enabled = true;
            textApeP.Enabled = true;
            textApeM.Enabled = true;
            textTelefono.Enabled = true;
            textDir.Enabled = true;
            btn_actualizar.Enabled = true;
            btn_deshabilitar.Enabled = true;


        }

        private void rdbStatusDown_CheckedChanged(object sender, EventArgs e)
        {
            string filtrar = "select * from empleados where status=1";
            MySqlDataAdapter adapter = new MySqlDataAdapter(filtrar, conexion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView1.DataSource = table;

            textNumE.Enabled = false;
            textNombre.Enabled = false;
            textApeP.Enabled = false;
            textApeM.Enabled = false;
            textTelefono.Enabled = false;
            textDir.Enabled = false;
            btnAgregar.Enabled = false;
            btn_actualizar.Enabled = false;
            btn_deshabilitar.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textbusqueda.Text.All(Char.IsDigit))
            {
                string buscar = "select * from empleados where status=0 and numEmpleado ='" + this.textbusqueda.Text + "';";
                MySqlDataAdapter adapter = new MySqlDataAdapter(buscar, conexion);
                DataTable table = new DataTable();
                adapter.Fill(table);
                dataGridView1.DataSource = table;
            }
            else
            {
                MessageBox.Show("Solo numeros");
            }
        }
    }
}
