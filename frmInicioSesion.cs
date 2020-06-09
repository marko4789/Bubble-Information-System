using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bubble_Information_System
{
    public partial class FrmInicioSesion : Form
    {

        private MySqlConnection     conexionDB;
        private MySqlCommand        sqlComando;
        private MySqlDataAdapter    adaptador;
        public FrmInicioSesion()
        {
            InitializeComponent();

            MySqlConnectionStringBuilder strConstructor = new MySqlConnectionStringBuilder();

            strConstructor.Server = "localhost";
            strConstructor.UserID = "root";
            strConstructor.Password = "";
            strConstructor.Database = "dbLavanderia";

            try
            {
                this.conexionDB = new MySqlConnection(strConstructor.ToString());
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.ToString());
            }

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            String usuario = this.txtUsuario.Text;
            String password = this.txtContrasena.Text;

            if ( ( usuario != "" ) && ( password != "" ))
            {
                logear(usuario, password);
            }
            else
            {
                MessageBox.Show("Porfavor rellene ambos campos", "Bubble Information System");
            }

        }


        public void logear(string nombreUsuario, string contraseña)
        {
            try
            {
                conexionDB.Open();
                sqlComando = new MySqlCommand("select nombreUsuario, tipoUsuario, numEmpleado from usuario where nombreUsuario =?nombreUsuario and contraseña =?contraseña and status = 0 ", conexionDB);
                sqlComando.Parameters.AddWithValue("nombreUsuario", nombreUsuario);
                sqlComando.Parameters.AddWithValue("contraseña", contraseña);
                
                adaptador = new MySqlDataAdapter(sqlComando);
                DataTable dt = new DataTable();
                adaptador.Fill(dt);
                if (dt.Rows.Count == 1)
                {
                    this.Hide();

                    

                    if (dt.Rows[0][1].ToString() == "Administrador")
                    {
                        MenuAd meA = new MenuAd(Convert.ToInt32(dt.Rows[0][2]));
                        meA.ShowDialog();
                        this.Close();
                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        MenuUs meU = new MenuUs(Convert.ToInt32(dt.Rows[0][2]));
                        meU.ShowDialog();
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("El usuario y/o contraseña es incorrecto", "Bubble Information System");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                conexionDB.Close();
            }
        }

        private void controlUsuario()
        {
            if (txtUsuario.Text.Trim() != string.Empty && txtContrasena.Text.Trim() != string.Empty)
            {
                btnIniciarSesion.Enabled = true;

            }

            if (txtUsuario.Text.Trim() != string.Empty)
            {
                errorProvider1.SetError(txtUsuario, "");
            }
            else
            {
                errorProvider1.SetError(txtUsuario, "Debe introducir el usuario");
                btnIniciarSesion.Enabled = false;
                txtUsuario.Focus();
            }
        }

        private void controlContrasena()
        {
            if (txtUsuario.Text.Trim() != string.Empty && txtContrasena.Text.Trim() != string.Empty)
            {
                btnIniciarSesion.Enabled = true;

            }

            if (txtContrasena.Text.Trim() != string.Empty)
            {
                errorProvider1.SetError(txtContrasena, "");
            }
            else
            {
                errorProvider1.SetError(txtContrasena, "Debe introducir el usuario");
                btnIniciarSesion.Enabled = false;
                txtUsuario.Focus();
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            controlUsuario();
        }

        private void txtContrasena_TextChanged(object sender, EventArgs e)
        {
            controlContrasena();
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                btnIniciarSesion_Click(null, null);
            }
        }

        private void FrmInicioSesion_Load(object sender, EventArgs e)
        {

        }
    }
}
