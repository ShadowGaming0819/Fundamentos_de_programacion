// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa6U3
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Programa para saber si un numero es par o impar");
            Console.WriteLine("Introdusca un numero");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("El numero es par");

            }
            else
            {
                Console.WriteLine("El numero es impar");
            }
        }
    }
}