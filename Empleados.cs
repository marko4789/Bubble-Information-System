using System;
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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        private void Empleados_Load(object sender, EventArgs e)
        {
            btnAgregar.Enabled = false; 
        }
        
        private void controlBotones()
        {
            if (textNombre.Text.Trim() != string.Empty && textNombre.Text.All(Char.IsLetter))
            { 
                btnAgregar.Enabled = true;
                errorProvider1.SetError(textNombre, "");
             }  
            else
            {
                if(!textNombre.Text.All(Char.IsLetter))
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
        private void nombre_textchanged(object sender, EventArgs e)
        {
            controlBotones();
        }
    }
}

