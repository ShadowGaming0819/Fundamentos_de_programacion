// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa1U3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para saber si eres mayor o menor de edad");
            int edad;

            Console.WriteLine("Introduce tu edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad");

            }
            else
            {
                Console.WriteLine("Eres menor de edad");
            }

        }
    }
}