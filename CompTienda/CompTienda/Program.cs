using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompTienda
{
    internal class Program
    {
        static void Main(string[] args)
        {

            byte CANB, CANH, CANP;
            double APAGAR;
            string linea;
            const double PRECIOB = 2000;
            const double PRECIOH = 5000;
            const double PRECIOP = 3000;
            Console.Write("Cantidad de Hamburguesas :"); linea = Console.ReadLine();
            CANH = byte.Parse(linea);
            Console.Write("Cantidad de papas: "); linea = Console.ReadLine();
            CANP = byte.Parse(linea);
            Console.Write("Cantidad de bebidas: "); linea = Console.ReadLine();
            CANB = byte.Parse(linea);
            Console.WriteLine();
            APAGAR = (CANH * PRECIOH) + (CANP * PRECIOP) + (CANB * PRECIOB);
            Console.WriteLine("VALOR A PAGAR: " + APAGAR);

        }
    }
}
