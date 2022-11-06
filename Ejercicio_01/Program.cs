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
            //1. Hacer un programa que imprima los números del 1 al 50.

            int limite = 50;

            for (int i = 1; i <= limite; i++)
            {
                Console.WriteLine("Numero: "+i);
            }
            Console.Read();
        }
    }
}