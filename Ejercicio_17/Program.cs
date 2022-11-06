using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //17. Imprimir, contar y sumar los múltiplos de 2 que hay entre una serie de números cuyos rangos sean ingresados por teclado. 

            int limiteInferior=1, limiteSuperior=-999, contador=0,suma=0;


            Console.WriteLine("Ingrese limite inferior: ");
            limiteInferior = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Ingrese limite superior: ");
            while (limiteInferior >= limiteSuperior)
            {
                limiteSuperior = Convert.ToInt16(Console.ReadLine());
            }

            limiteInferior++;

            while (limiteInferior<=limiteSuperior-1)
            {
                if (limiteInferior%2==0)
                {
                    Console.WriteLine(limiteInferior);
                    contador++;
                    suma = suma + limiteInferior;
                }
                limiteInferior++;
            }

            Console.WriteLine("Numeros multiplos de 2: "+contador);
            Console.WriteLine("Su suma es: "+suma);

            Console.Read();
        }
    }
}