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
            //13. Imprimir y contar los números que son múltiplos de 2 o de 3 que hay entre 1 y 100


            int numero = 1;
            int contador2=0; 
            int contador3=0;

            while (numero < 101)
            {
                if ((numero % 2) == 0)
                {
                    Console.WriteLine("Valor multiplo de 2: " + numero);
                    contador2 = contador2 + 1;
                }
                else if ((numero % 3) == 0)
                {
                    Console.WriteLine("Valor multiplo de 3: " + numero);
                    contador3 = contador3 + 1;
                }
               
                
                numero++;
            }
            Console.WriteLine("La cantidad de valores multiplo de 2 son: "+contador2);
            Console.WriteLine("La cantidad de valores multiplo de 3 son: " + contador3);


            Console.Read();
        }
    }
}
