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
            //26. Introducir una frase por teclado. Imprimirla en el centro de la pantalla.
            string cadena;
            int veces = 1;


            Console.Write("Frase: ");
            cadena = Console.ReadLine();

            for (int i = 0; i < veces; i++)
            {
                Console.Write(cadena.PadLeft(50));
                Console.Write("");
            }


            Console.Read();

        }
    }
}