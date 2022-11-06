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
            //11. Imprimir y contar los múltiplos de 3 desde la unidad hasta un numero que introducimos por teclado.


            int limite=0;
            int numero = 1;
            int contador = 0;

            Console.WriteLine("Ingrese un numero: ");
            limite = Convert.ToInt16(Console.ReadLine());

            while (numero<=limite)
            {
                if (numero%3 ==0)
                {
                    Console.WriteLine("Valor: "+numero);
                    contador++;
                }
                numero++;
            }
            Console.WriteLine("Cantidad de valores dentro del rango: " +contador);
            Console.Read();

        }
    }
}