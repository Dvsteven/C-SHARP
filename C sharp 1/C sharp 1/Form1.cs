using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            try 
            {

            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
        }

        private void lbl_wlcom_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

//---------------------------------------------------------------------------------------------------------------------------

/*
//Operador Ternario para reemplazar estructura if >
*int edad = 23;
*var comprobacion = edad > 18 ? "Es mayor de edad" : "Es menor de edad";
*MessageBox.Show("El usuario: " + comprobacion);
*/

//---------------------------------------------------------------------------------------------------------------------------
//Concatenacion Video: #14
/*
 *             try 
            {
                string saludo = " Welcome to the jungle prro";
                string texto = "Hola " + txtb_name.Text + saludo; //Concatenación para texto dinamico
                lbl_wlcom.Text = texto;
            }
            catch (Exception x)
            {
                MessageBox.Show("Error: " + x);
            }
 */


//---------------------------------------------------------------------------------------------------------------------------


//Boton "OK"
/*
 *             try //Manejar los errores
            {
                byte texto_txtBox = Convert.ToByte(txtb_name.Text); //Convertir la variable a byte con la propiedad "Convert"

                lbl_wlcom.Text = texto_txtBox.ToString(); //Reemplazar lo del label con lo intrucido en el textbox
            }
            catch (OverflowException x)
            {
                //Pueden haber varios "catch" para manejar los distintos errores que puden surgri dentro del codigo
                MessageBox.Show("Error en el tamaño del numero: " + x); //La letra es el indicador del error que se esta presentando
            }
            catch (FormatException z)
            {

                MessageBox.Show("Error en el formato de entrada: " + z);
            }
 */