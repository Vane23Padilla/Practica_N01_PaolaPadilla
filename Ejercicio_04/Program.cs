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
            //4. Hacer un programa que imprima la suma de los 200 primeros números.

            int numero = 0;
            int suma = 0;

                    while (numero <= 200)
                    {

                    suma += numero;
                    numero += 1;

                    }
            Console.WriteLine("La suma de los numeros del 1 al 200 es: "+suma);

            Console.Read();
                   
        }
    }
}