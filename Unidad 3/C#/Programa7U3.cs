// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa7U3
    {
        static void Main(string[] args)
        {
            int temp;
            Console.WriteLine("Programa para saber la temperatura actual");
            Console.WriteLine("Introdusca la temperatura");
            temp = Convert.ToInt32(Console.ReadLine());

            if (temp > 27)
            {
                Console.WriteLine("Hace calor");
            }
            else if (temp > 20 && temp < 27)
            {
                Console.WriteLine("Clima agradable");
            }
            else if (temp < 20)
            {
                Console.WriteLine("Clima fresco");
            }
        }
    }
}