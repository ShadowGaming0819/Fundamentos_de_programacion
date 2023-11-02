// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa9U3
    {
        static void Main(string[] args)
        {
            int horas, total;
            Console.WriteLine("Programa para cobrar el uso de estacionamiento");
            Console.WriteLine("Introdusca las horas de uso");
            horas = Convert.ToInt32(Console.ReadLine());

            if (horas <= 2)
            {
                total = horas * 5;
                Console.WriteLine("Tu total a pagar es" + total);
            }
            else if (horas > 2 && horas <= 5)
            {
                total = 2 * 5 + (horas - 3) * 4;
                Console.WriteLine("Tu total a pagar es" + total);
            }
            else if (horas > 5 && horas <= 10)
            {
                total = 2 * 5 + 3 * 4 + (horas - 5) * 3;
                Console.WriteLine("Tu total a pagar es" + total);
            }
            else if (horas > 10)
            {
                total = 2 * 5 + 3 * 4 + 3 * 5 + (horas - 10) * 2;
                Console.WriteLine("Tu total a pagar es" + total);
            }
        }
    }
}