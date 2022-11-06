using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //16. Imprimir diez veces la serie de números del 1 al 10

            int serie = 1;

            while (serie<=10)
            {
                int numero = 1;
                while (numero<=10)
                {
                    Console.WriteLine("Cantidad: "+numero);
                    numero = numero + 1;
                }
                serie=serie + 1;
                Console.WriteLine("\n");
            }

            Console.Read();
        }
    }
}
