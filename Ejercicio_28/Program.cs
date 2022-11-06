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
            //28. Simular el lanzamiento de una moneda al aire e imprimir si ha salido cara o cruz.

         
            Random random = new Random();
            int numero = random.Next(1,3);   
            if (numero==1)
            {
                Console.WriteLine("Cara");
            }
            else
            {
                Console.WriteLine("Cruz");
            }

            Console.Read();

        }
    }
}