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
            //6. Hacer un programa que imprima todos los números naturales que hay desde la unidad hasta un número que introducimos por teclado.

            int numero = 0;
            int limite = 0;

            Console.Write("Introduce el limite del rango :", limite);
            limite = Convert.ToInt16(Console.ReadLine());
            do
            {
                numero = numero + 1;
                Console.WriteLine("Valor: " + numero);
            } while (numero<limite);
            
            Console.Read();

        }
    }
}
