using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniLogIn
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Vectrores
            int numx = 0;
            int[] numeros = new int[5]; //Declaración de arreglo
            numeros[0] = 1;
            numeros[1] = 2;
            numeros[2] = 3;
            numeros[3] = 4;
            numeros[4] = 5;

            MessageBox.Show(numeros.Length.ToString());
            //Agregar un ciclo for
            for (int i = 0; i < numeros.Length; i++)
            {
                MessageBox.Show(numeros[i].ToString());
            }

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
        }
    }
}
