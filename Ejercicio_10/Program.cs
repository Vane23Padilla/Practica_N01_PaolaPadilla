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
            //10. Hacer un programa que permita introducir un numero por teclado. Que nos diga si es par o impar.

            int numero = 0;

            Console.WriteLine("Introduce un numero: ");
            numero = Convert.ToInt16(Console.ReadLine());

            if ((numero%2)==0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }

            Console.Read();

        }
    }
}
