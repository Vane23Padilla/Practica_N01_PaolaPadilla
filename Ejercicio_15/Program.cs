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
            //15. Introducir dos números por teclado. Imprimir los números naturales que hay entre ambos números
            //empezando por el más pequeño, contar cuantos hay y cuántos de ellos son pares.Calcular la suma de los
            //impares.

            int numero1 ;
            int numero2 ;
            int contador = 0;
            int impares = 0;
            int naturales = 0;

            Console.WriteLine("Cantidad 1: ");
            numero1 = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Cantidad 2: ");
            numero2 = Convert.ToInt16(Console.ReadLine());

            for (int i = numero1; i <= numero2; i++)
            {
                Console.WriteLine("Valores: "+i);

                naturales=naturales + 1;

                if (i%2 == 0)
                {
                    contador = contador + 1;
                }
                else
                {
                    impares=impares + i;
                }
            }

            Console.WriteLine("Cantidad entre el rango:  " + naturales);
            Console.WriteLine("Cuantos son pares del rango:  " + contador);
            Console.WriteLine("Suma de los impares:  " + impares);

            Console.Read();
        }
    }
}
