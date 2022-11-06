using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {

        public static void Main(string[] args)
        {

            //7. Hacer un programa que permita introducir tantas frases como queramos y contar cuántos caracteres
            //posee cada una de las frases.

            string respuesta = "S";

            do
            {
                Console.Write("Deseas introducir mas frases (S): ");
                respuesta = Console.ReadLine();
                Console.WriteLine("Ingrese una frase");
                string frase = Console.ReadLine();
                //Console.WriteLine("La frase tiene {0} palabras", resultado[0]);
                contarCaracteres(frase);
            } while (respuesta=="S");
 
            
        }

        public static void contarCaracteres(String cadena)
        {
            int longitud= cadena.Length;
            Console.WriteLine("Cantidad de caracteres es: "+longitud);
 
        }
        
    }
}

