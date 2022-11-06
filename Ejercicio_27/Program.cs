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
            //27. Realizar la tabla de multiplicar de un numero entre 0 y 10.
            int contador, numero;

            Console.WriteLine("Ingrese una cantidad: ");
            numero = Convert.ToInt16(Console.ReadLine());

            for (contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine(numero + " x " + contador + " = " + (numero * contador));
            }

            Console.Read();

        }
    }
}