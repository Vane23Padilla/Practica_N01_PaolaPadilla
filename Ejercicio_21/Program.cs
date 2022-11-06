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
            //21. Hacer un programa que calcule independientemente la suma de los pares y los impares de los números
            //entre 1 y 1000, utilizando un switch

            
            int opcion;
            Console.WriteLine("--- Calculadora Suma Pares E Impares ---");
            Console.WriteLine("Opcion 1.- Pares");
            Console.WriteLine("Opcion 2.- Impares");
            Console.WriteLine("Introduce una opcion: ");
            opcion = int.Parse(Console.ReadLine());


            int numero = 1;
            int sumaPar = 0;
            int sumaImpar = 0;

            while (numero < 1001)
            {
                if ((numero % 2) == 0)
                {
                    sumaPar = sumaPar + numero;
                }
                else
                {
                    sumaImpar = sumaImpar + numero;
                }
                numero++;
            }

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("La suma de pares es: " + sumaPar);
                    break;

                case 2:
                    Console.WriteLine("La suma de los impares es: " + sumaImpar);
                    break;


                default:
                    Console.WriteLine("Digito fuera de rango, intentalo de nuevo.");
                    break;
            }

            Console.Read();
        }
    }
}