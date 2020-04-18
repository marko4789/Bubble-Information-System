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
        
        private void controlNombre()
        {
            if (textNombre.Text.Trim() != string.Empty && textNombre.Text.All(Char.IsLetter) && textApeP.Text.Trim() != string.Empty && textApeP.Text.All(Char.IsLetter) && textApeM.Text.Trim() != string.Empty && textApeM.Text.All(Char.IsLetter) && textNumE.Text.Trim() != string.Empty && textNumE.Text.All(Char.IsNumber) && textTelefono.Text.Trim() != string.Empty && textTelefono.Text.All(Char.IsNumber) && textDir.Text.Trim() != string.Empty)
            { 
                btnAgregar.Enabled = true;
                
             }  

            if (textNombre.Text.Trim() != string.Empty && textNombre.Text.All(Char.IsLetter))
            {
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

        private void controlNumE()
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
        }

        private void controlApeP()
        {
            if (textNombre.Text.Trim() != string.Empty && textNombre.Text.All(Char.IsLetter) && textApeP.Text.Trim() != string.Empty && textApeP.Text.All(Char.IsLetter) && textApeM.Text.Trim() != string.Empty && textApeM.Text.All(Char.IsLetter) && textNumE.Text.Trim() != string.Empty && textNumE.Text.All(Char.IsNumber) && textTelefono.Text.Trim() != string.Empty && textTelefono.Text.All(Char.IsNumber) && textDir.Text.Trim() != string.Empty)
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
            if (textNombre.Text.Trim() != string.Empty && textNombre.Text.All(Char.IsLetter) && textApeP.Text.Trim() != string.Empty && textApeP.Text.All(Char.IsLetter) && textApeM.Text.Trim() != string.Empty && textApeM.Text.All(Char.IsLetter) && textNumE.Text.Trim() != string.Empty && textNumE.Text.All(Char.IsNumber) && textTelefono.Text.Trim() != string.Empty && textTelefono.Text.All(Char.IsNumber) && textDir.Text.Trim() != string.Empty)
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
            if (textNombre.Text.Trim() != string.Empty && textNombre.Text.All(Char.IsLetter) && textApeP.Text.Trim() != string.Empty && textApeP.Text.All(Char.IsLetter) && textApeM.Text.Trim() != string.Empty && textApeM.Text.All(Char.IsLetter) && textNumE.Text.Trim() != string.Empty && textNumE.Text.All(Char.IsNumber) && textTelefono.Text.Trim() != string.Empty && textTelefono.Text.All(Char.IsNumber) && textDir.Text.Trim() != string.Empty)
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
            if (textNombre.Text.Trim() != string.Empty && textNombre.Text.All(Char.IsLetter) && textApeP.Text.Trim() != string.Empty && textApeP.Text.All(Char.IsLetter) && textApeM.Text.Trim() != string.Empty && textApeM.Text.All(Char.IsLetter) && textNumE.Text.Trim() != string.Empty && textNumE.Text.All(Char.IsNumber) && textTelefono.Text.Trim() != string.Empty && textTelefono.Text.All(Char.IsNumber) && textDir.Text.Trim() != string.Empty)
            {
                btnAgregar.Enabled = true;

            }

            if (textDir.Text.Trim() != string.Empty )
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
            controlNumE();
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
    }
}

