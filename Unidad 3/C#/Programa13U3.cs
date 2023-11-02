// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa13U3
    {
        static void Main(string[] args)
        {
            int c, num, contadorp = 1, contadorn = 1;

            for (c = 1; c <= 100; c++)
            {
                Console.WriteLine("Escribe el numero: ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num > 0)
                {
                    Console.WriteLine("Son: " + contadorp + " numeros positivos");
                    contadorp = contadorp + 1;
                }
                else
                {
                    Console.WriteLine("Son: " + contadorn + " numeros negativos");
                    contadorn = contadorn + 1;
                }
            }
        }
    }
}