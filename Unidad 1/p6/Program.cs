// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cen, far;
            Console.WriteLine("Programa para covertir de centigrados a farenheit");
            Console.WriteLine("Inserte los grados centigrados");
            cen = Convert.ToInt32(Console.ReadLine());
            far = (cen * 9 / 5) + 32;
            
            Console.WriteLine("Los grados farenheit son:" + far);

        }
    }
}
