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
            //29. Simular cien tiradas de dos dados y contar las veces que entre los dos suman 10, con sus respectivas combinaciones.

            int numero1, numero2, contador, indice;
            contador = 0;

            Random random = new Random();
            for (indice = 1; indice <= 100; indice++)
            {
                numero1=random.Next(1,7);
                numero2=random.Next(1,7);

                if ((numero1+numero2)==10)
                {
                    Console.WriteLine("Dado 1: {0} Dado 2: {1}",numero1,numero2);
                    contador++;
                }
            }
            Console.WriteLine("Las veces que suman los dados 10 es: "+contador);
            Console.Read();

        }
    }
}