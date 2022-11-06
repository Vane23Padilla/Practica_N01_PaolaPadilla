using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Hacer un programa que imprima los números del 50 al 0, en orden decreciente.

            int limite = 50;

            for (int i = limite; i >= 0; i--)
            {
                Console.WriteLine("Numero: " + i);
            }
            Console.Read();
        }
    }
}