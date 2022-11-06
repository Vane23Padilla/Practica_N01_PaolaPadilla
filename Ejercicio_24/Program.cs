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
            //24. Comprobar si un número ingresado por teclado es primo.

            int numero, limiteInferior, limiteSuperior, residuo;
           
            limiteInferior = 2;
            limiteSuperior = 0;

            Console.Write("Ingrese el numero:");
            numero = Convert.ToInt32(Console.ReadLine());

            while (limiteInferior < numero && limiteSuperior == 0)
            {
                residuo = numero % limiteInferior;
                if (residuo == 0)
                {
                    limiteSuperior = 1;
                }
                else
                {
                    limiteInferior = limiteInferior + 1;
                }
            }
            if (limiteSuperior == 0)
            {
                Console.WriteLine();
                Console.WriteLine("El numero es PRIMO");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("El numero no es PRIMO");
            }
            Console.ReadKey();
        }
    }
}
