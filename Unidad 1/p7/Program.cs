// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double met, pie;
            Console.WriteLine("Programa para convertir de metros a pies");
            Console.WriteLine("Inserte los metros");
            met = Convert.ToInt32(Console.ReadLine());

            pie = met * 3.281;

            Console.WriteLine("El resultado es :" + pie + " pies");

        }
    }
}
