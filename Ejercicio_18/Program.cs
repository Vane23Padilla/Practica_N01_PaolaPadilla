using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using Microsoft.Azure.Amqp.Framing;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //18. Hacer un programa que cuente las veces que aparece una determinada letra en una frase que introduciremos por teclado.


            string cadena = "";
            Console.WriteLine("Introduce una cadena: ");
            cadena = Console.ReadLine();

            
            Console.WriteLine("Introduce un carácter: ");
            char caracter = Convert.ToChar(Console.ReadLine());

            int count = cadena.Split(caracter).Length - 1;

            Console.WriteLine("En la cadena "+cadena+ " aparecen "+count+ " veces el carácter "+caracter+ ".");


            
           
        
        Console.Read();
        }
    }
}