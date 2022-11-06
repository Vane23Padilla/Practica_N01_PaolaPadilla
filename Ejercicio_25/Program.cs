using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //25. Introducir un número menor de 5000 y pasarlo a número romano

            string[] unidad = {"","I","II","III","IV","V","VI","VII","VIII","IX"};
            string[] decena = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] centena = { "", "C", "CC","CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] mil = { "", "M", "MM", "MMM","IV"};

            Console.WriteLine("Ingrese un valor entre el 1 y 4999: ");
            int numero = Convert.ToInt16(Console.ReadLine());

            int u = numero % 10;
            int d = (numero / 10) % 10;
            int c = numero / 100;
            int m = numero / 1000;

            if (numero >= 1000)
            {
                Console.WriteLine(mil[m] + centena[c] + decena[d] + unidad[u]);
                Console.ReadLine();
            }
            else if (numero >= 100)
            {
                Console.WriteLine(centena[c] + decena[d] + unidad[u]);
                Console.ReadLine();
            }
            if (numero>=10)
            {
                Console.WriteLine(decena[d] + unidad[u]);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine(unidad[u]);
            }
            Console.Read();

        }
    }
}