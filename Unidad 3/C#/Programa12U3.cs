// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa12U3
    {
        static void Main(string[] args)
        {
            int c, total, num;
            Console.WriteLine("Escribe el total de numeros a procesar: ");
            total = Convert.ToInt32(Console.ReadLine());

            for (c = 1; c <= total; c++)
            {
                Console.WriteLine("Escribe el numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num % 2 == 0)
                {
                    Console.WriteLine("PAR");
                }
                else
                {
                    Console.WriteLine("IMPAR");
                }

            }
        }
    }
}