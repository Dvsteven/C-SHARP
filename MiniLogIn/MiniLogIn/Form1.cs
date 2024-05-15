using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniLogIn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string user = txtB_User.Text;
            string pass = txtB_Pass.Text;

            try
            {

            }
            catch (Exception x)
            {
                MessageBox.Show("Error :" + x);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

//---------------------------------------------------------------------------------------------------------------------------
/*
if anidado y mañitas 

                //Para convertir la contraseña a solo numeros: Convert.ToInt32(pass)
                //Operador or -> ||1
                if (user == "Perros" & pass == "666")
                {
                    MessageBox.Show("Inicio Correcto!");
                }
                else if (user != "Perros" & pass == "666")
                {
                    MessageBox.Show("El usuario ingresado es incorrecto");
                }
                else if (user == "Perros" & pass != "666")
                {
                    MessageBox.Show("La clave ingresada es incorrecta");
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas");
                }
 */

//---------------------------------------------------------------------------------------------------------------------------


//SWITCH CASE

/*
 //Permite una o mas opciones para un mismo valor
                switch (user)
                {
                    case "Perros":
                        MessageBox.Show("Ingreso Correcto");
                        break;
                    case "Perras":
                        MessageBox.Show("Ingreso Correcto");
                        break;
                    default:
                        MessageBox.Show("Asi no es prro");
                        break;
                }
 */

//---------------------------------------------------------------------------------------------------------------------------

//SWITCH CASE ANIDADO
/*
                 switch (user)
                {
                    case "Perros":
                        MessageBox.Show("Ingreso Correcto");
                        break;

                    case "Perras":
                        MessageBox.Show("Ingreso Correcto");
                        //Elimina el break;
                        switch (pass)
                        {
                            case "666":
                                MessageBox.Show("Ingreso Correcto");
                                break;

                            default:
                                MessageBox.Show("Asi no es prro1");
                                break;
                        }
                        break;
                    default:
                        MessageBox.Show("Asi no es prro2");
                        break;
                }
 */
//---------------------------------------------------------------------------------------------------------------------------

//CICLO FOR:
