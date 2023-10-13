using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para calcular x=y+a+3");
            int x, y, a;
            Console.WriteLine("Introduce el valor de y");
            y = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el valor de a");
            a = Convert.ToInt32(Console.ReadLine());

            x = y + a + 3;

            Console.WriteLine("Tu resultado de x es " + x);
        }
    }
}