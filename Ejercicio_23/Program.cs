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
            //23. Crear una aplicación que, ingresando una frase, luego imprima la misma frase pero en sentido contrario (al revés)
            string cadena = "";

            Console.Write("Ingrese una frase: ");
            cadena = Console.ReadLine();
            Console.Write("La frase invertida: "+ConvertirFraseInvertida(cadena));
            Console.Read();
        }

 

        public static string ConvertirFraseInvertida(string cadena)
        {
            char[] cadenaComoCaracteres = cadena.ToCharArray();
            Array.Reverse(cadenaComoCaracteres);
            return new string(cadenaComoCaracteres);
        }
    
 

        }
    }

