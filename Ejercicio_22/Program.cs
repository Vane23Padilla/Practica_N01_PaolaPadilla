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
            //22. Introducir una frase por teclado. Imprimirla cinco veces en filas consecutivas, pero cada impresión
            //desplazarla dos tabulaciones hacia la derecha.

            string cadena;
            int veces = 5;


            Console.Write("Frase: ");
            cadena = Console.ReadLine();

            for (int i = 0; i < veces; i++)
            {
                Console.Write(cadena.PadRight(5));
                Console.Write("");
            }


            Console.Read();

        }
    }
}
