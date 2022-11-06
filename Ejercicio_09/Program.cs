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
            //9. Hacer un programa que permita introducir un numero por teclado. Que nos diga si es positivo o negativo

            int numero = 0;

            Console.WriteLine("Introduce un numero: ");
            numero = Convert.ToInt16(Console.ReadLine());

            if (numero>=0)
            {
                Console.WriteLine("Es positivo");
            }
            else
            {
                Console.WriteLine("Es negativo");
            }

            Console.Read();

        }
    }
}