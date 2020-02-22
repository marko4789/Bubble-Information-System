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
        private MySqlDataReader     registro;
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
                sqlComando = new MySqlCommand("select nombreUsuario, tipoUsuario from usuario where nombreUsuario =?nombreUsuario and contraseña =?contraseña and status = 0 ", conexionDB);
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
                        //frmMenu me = new frmMenu();
                        //me.Show();
                        MessageBox.Show("Inicio de sesión como un Administrador", "Bubble Information System");
                    }
                    else if (dt.Rows[0][1].ToString() == "Usuario")
                    {
                        // frmMenuUsu meu = new frmMenuUsu();
                        //meu.Show();
                        MessageBox.Show("Inicio de sesión como un Usuario", "Bubble Information System");
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





    }
}
