using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //8. Hacer un programa que solo nos permita introducir S o N (solo mayúsculas). FALTAAAAAAAAAAAAAA

            int indice = 1;
            char letra;

            while (indice!=0)
            {
                Console.Write("Ingrese una letra : ");
                letra = Convert.ToChar(Console.ReadLine());
                if (letra!='S' && letra!='N')
                {
                    Console.WriteLine("Solo se ingresa letra S o N (Mayuscula)");
                }
                else if (letra == 'S' && letra == 'N')
                {
                    indice = 0;
                }
            }
            Console.Read();
        }
    }
}