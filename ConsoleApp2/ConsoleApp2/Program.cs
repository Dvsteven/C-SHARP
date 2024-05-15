using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int NUM1, NUM2, RESUL;
            string linea;
            Console.Write("Primer número: ");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            Console.Write("Segundo número: ");
            linea = Console.ReadLine();
            NUM2 = int.Parse(linea);
            Console.WriteLine();
            RESUL = NUM1 + NUM2;
            Console.WriteLine("lA SUMA ES {0}: ", RESUL);
            RESUL = NUM1 - NUM2;
            Console.WriteLine("LA RESTA ES: {0} - {1} = {2} ", NUM1, NUM2, RESUL);
            RESUL = NUM1 * NUM2;
            Console.WriteLine("LA MULTIPLICACIÓN ES: " + RESUL);
            RESUL = NUM1 / NUM2;
            Console.WriteLine("LA DIVISION ES: " + RESUL);
            RESUL = NUM1 % NUM2;
            Console.WriteLine("EL RESIDUO ES :" + RESUL);
        }
    }
}
