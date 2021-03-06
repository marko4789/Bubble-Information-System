﻿using System;
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
    public partial class MenuAd : Form
    {
        int numEmpleado;
        MySqlConnection conexionBD = new MySqlConnection("server=localhost; database=dblavanderia; uid=root; pdw=;");

        public MenuAd(int numEmpleado)
        {
            this.numEmpleado = numEmpleado;
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Empleados ventanaEmpleados = new Empleados())
                ventanaEmpleados.ShowDialog();

        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmVentas ventanaVentas = new frmVentas(this.numEmpleado))
                ventanaVentas.ShowDialog();
        }

        private void btn_Venta_Click(object sender, EventArgs e)
        {
            using (frmVentas ventanaVentas = new frmVentas(this.numEmpleado))
                ventanaVentas.ShowDialog();
        }

        private void MenuAd_Load(object sender, EventArgs e)
        {
            String nombre;
            try
            {
                conexionBD.Open();
                MySqlCommand consulta = new MySqlCommand ("SELECT nombre AS nombre FROM empleados where numEmpleado =?numEmpleado", conexionBD);
                consulta.Parameters.AddWithValue("numEmpleado", this.numEmpleado);
                MySqlDataAdapter adapter = new MySqlDataAdapter(consulta);
                
                DataTable aux = new DataTable();
                adapter.Fill(aux);
                DataRow row = aux.Rows[0];
                try
                {
                    nombre = Convert.ToString(row["nombre"]);
                }
                catch
                {
                    nombre = null;
                }

                labelBienvenida.Text = labelBienvenida.Text + nombre;

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

        private void serviciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmServicios ventanaServicios = new frmServicios())
                ventanaServicios.ShowDialog();
        }

        private void btn_Cliente_Click(object sender, EventArgs e)
        {
            using (frmClientes ventanaClientes = new frmClientes())
                ventanaClientes.ShowDialog();
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmClientes ventanaClientes = new frmClientes())
                ventanaClientes.ShowDialog();
        }

        private void adeudosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmAdeudos ventanaAdeudos = new frmAdeudos(this.numEmpleado))
                ventanaAdeudos.ShowDialog();
        }

        private void btn_Adeudos_Click(object sender, EventArgs e)
        {
            using (frmAdeudos ventanaAdeudos = new frmAdeudos(this.numEmpleado))
                ventanaAdeudos.ShowDialog();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (Usuarios ventanaUsuarios = new Usuarios())
                ventanaUsuarios.ShowDialog();
        }

        private void corteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (frmCorteCaja ventanaCorteCaja = new frmCorteCaja())
                ventanaCorteCaja.ShowDialog();
        }

        private void btn_Corte_Click(object sender, EventArgs e)
        {
            using (frmCorteCaja ventanaCorteCaja = new frmCorteCaja())
                ventanaCorteCaja.ShowDialog();
        }
    }
}
