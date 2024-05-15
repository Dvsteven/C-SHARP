using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LibMath
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int NUM1;
            string linea;
            long RESUL;
            Console.Write("Digite un Numero: ");
            linea = Console.ReadLine();
            NUM1 = int.Parse(linea);
            RESUL = Math.Abs(NUM1);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Valor Absoluto : " + RESUL);
            Console.WriteLine("POTENCIA : " + Math.Pow(NUM1, 3));
            Console.WriteLine("RAIZ CUADRADA : " + Math.Sqrt(NUM1));
            Console.WriteLine("SENO : " + Math.Sin(NUM1 * Math.PI / 180));
            Console.WriteLine("COSENO : " + Math.Cos(NUM1 * Math.PI / 180));
            Console.WriteLine("NÚMERO MÁXIMO : " + Math.Max(NUM1, 50));
            Console.WriteLine("NÚMERO MINIMO : " + Math.Min(NUM1, 50));
            Console.WriteLine("PARTE ENTERA : " + Math.Truncate(18.78));
            Console.WriteLine("REDONDEO : " + Math.Round(18.78));
            Console.WriteLine("-------------------------------");
            Console.WriteLine("-------------------------------");
            Console.Write("Pulse una tecla: "); Console.ReadLine(); 
        }
    }
}
