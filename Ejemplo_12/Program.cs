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
            //12. Hacer un programa que imprima los números del 1 al 100. Que calcule la suma de todos los números
            //pares, por un lado, y por otro, la de todos los impares.


            int numero = 1;
            int sumaPar = 0;
            int sumaImpar = 0;

            while (numero<101)
            {
                if ((numero % 2) == 0)
                {
                    Console.WriteLine("Valor Par: " + numero);
                    sumaPar =sumaPar+numero;
                }
                else
                {
                    Console.WriteLine("Valor Impar: " + numero);
                    sumaImpar =sumaImpar+numero;
                }
                numero++;
            }
            Console.WriteLine("La suma de pares es: "+sumaPar);
            Console.WriteLine("La suma de los impares es: " + sumaImpar);

            Console.Read();

        }
    }
}
