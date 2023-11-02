// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa14U3
    {
        static void Main(string[] args)
        {
            int contador1 = 1, contador2 = 2;
            Console.WriteLine("Programa para imprimir 100 numeros pares");
            while (contador1 <= 100)
            {
                contador1 = contador1 + 1;
                Console.WriteLine(contador2);
                contador2 = contador2 + 2;
            }
        }
    }
}