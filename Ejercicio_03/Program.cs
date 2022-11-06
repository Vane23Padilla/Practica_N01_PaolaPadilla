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
            //3. Hacer un programa que imprima los números pares entre 0 y 200.

            int limite = 200;

            for (int i = 0; i <= limite; i+=2)
            {
                Console.WriteLine("Numero: " + i);
            }
            Console.Read();
        }
    }
}