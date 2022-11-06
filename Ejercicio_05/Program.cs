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
            //5. Hacer un programa que imprima los números impares hasta el 200 y que imprima cuantos número impares fueron encontrados

            int numero = 0;
            int contador = 0;

            while (numero <= 200)
            {
                if (numero % 2 == 1)
                {
                    
                    Console.WriteLine("Valor impar: " + numero);
                    contador++;
                }
                numero += 1;
            }


            Console.WriteLine("Cantidad de valores impares: " + contador);

            Console.Read();

        }
    }
}