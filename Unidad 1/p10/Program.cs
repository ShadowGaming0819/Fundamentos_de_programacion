// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int area, apot, peri;
            Console.WriteLine("Programa para calcular el area de un hexagono");
            Console.WriteLine("Introduce el valor de uno de sus lados");
            peri = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Introduce el valor del apotema");
            apot = Convert.ToInt32(Console.ReadLine());

            peri = peri * 6;

            area = (peri * apot) / 2;

            Console.WriteLine("Tu area del hexagono es "+  area);   
        }
    }
}
