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
            //20. Calcular el factorial de un numero.

            int valor;
            Console.WriteLine("Calculo del Factorial de un número entero positivo\n");
            do
            {
                Console.Write("Por favor Digite un número entero positivo: ");
                valor = int.Parse(Console.ReadLine());
                verificar(valor);
            } while (valor < 0);
            factorial(valor);
            Console.Read();
        }
        static void verificar(int n)
        {
            if (n < 0)
            {
                Console.Write("\nError: No existe el factorial de un número negativo...\n");
            }
        }
        static void factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine("\nEl Factorial de " + n + " es: " + fact);
        }
    }
}