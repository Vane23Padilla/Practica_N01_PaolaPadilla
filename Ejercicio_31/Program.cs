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
            //31. -Hacer un programa que nos permita introducir un numero por teclado y sobre él se realicen las siguientes
            //operaciones: comprobar si es primo, hallar su factorial o imprimir su tabla de multiplicar

            int cantidad;

            Console.Write("Ingrese el numero: ");
            cantidad = Convert.ToInt32(Console.ReadLine());
            ComprobarNumeroPrimo(cantidad);
            verificar(cantidad);
            factorial(cantidad);
            Console.WriteLine();
            CalcularTablasMultiplicar(cantidad);
            Console.Read();


            static void ComprobarNumeroPrimo(int numero)
            {
                int limiteInferior, limiteSuperior, residuo;

                limiteInferior = 2;
                limiteSuperior = 0;
                while (limiteInferior < numero && limiteSuperior == 0)
                {
                    residuo = numero % limiteInferior;
                    if (residuo == 0)
                    {
                        limiteSuperior = 1;
                    }
                    else
                    {
                        limiteInferior++;
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
            }


            static void verificar(int numero)
            {
                if (numero < 0)
                {
                    Console.Write("\nError: No existe el factorial de un número negativo...\n");
                }
            }
            static void factorial(int numero)
            {
                int factorial = 1;
                for (int i = 1; i <= numero; i++)
                {
                    factorial *= i;
                }
                Console.WriteLine("\nEl Factorial de " + numero + " es: " + factorial);
            }



            static void CalcularTablasMultiplicar(int numero)
            {
                int contador;
                for (contador = 0; contador <= 10; contador++)
                {
                    Console.WriteLine(numero + " x " + contador + " = " + (numero * contador));
                }
            }


        }
    }
}

