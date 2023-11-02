// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa8U3
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Programa para saber cual numero es mayor");
            Console.WriteLine("Introdusca el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdusca el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("El numero " + num1 + " es mayor que " + num2);
            }
            else
            {
                Console.WriteLine("El numero " + num2 + " es menor que " + num1);
            }
        }
    }
}