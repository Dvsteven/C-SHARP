using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsSalida
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double BASE, ALTURA, RESUL;
            string linea;
            Console.Write("Digite la base :"); linea = Console.ReadLine();
            BASE = double.Parse(linea);
            Console.Write("Digite la altura: "); linea = Console.ReadLine();
            ALTURA = double.Parse(linea);
            RESUL = (BASE * ALTURA) / 2;
            Console.WriteLine("AREA TRIANGULO :" + string.Format("{0:####.00}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + string.Format("{0:c}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + string.Format("{0:f}", RESUL));
            Console.WriteLine("AREA TRIANGULO :" + string.Format("{0:g}", RESUL));
            Console.WriteLine();
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:f}", DateTime.Now));
            Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:dddd}{0:dd/MM/yy}", DateTime.Now));
            Console.WriteLine("Pulse una tecla: "); Console.ReadLine();
        }
    }
}
