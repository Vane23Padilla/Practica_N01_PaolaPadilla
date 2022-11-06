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
            //14. Hacer un programa que imprima el mayor y el menor de una serie de cinco números que vamos introduciendo por teclado.

            int contador = 0;
            int numero;
            int maximo = 0;
            int minimo = 99999;

            while (contador<=5)
            {
                Console.WriteLine("Cantidad: ");
                numero = Convert.ToInt16(Console.ReadLine());

                if (numero>maximo)
                {
                    maximo = numero;
                }
                else if (numero<=minimo)
                {
                    minimo = numero;
                }
                contador++;
            }

            Console.WriteLine("El mayor de los numeros es: "+ maximo);
            Console.WriteLine("El minimo de los numeros es: " + minimo);

            Console.Read();

        }
    }
}