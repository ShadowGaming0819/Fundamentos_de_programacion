// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa10U3
    {
        static void Main(string[] args)
        {
            int horas, pago, total;
            Console.WriteLine("Programa para determinar el sueldo semanal de un trabajador");
            Console.WriteLine("Introdusca las horas trabajadas");
            horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introdusca el pago por horas");
            pago = Convert.ToInt32(Console.ReadLine());

            if (horas > 40)
            {
                total = (horas * pago) * 2;
                Console.WriteLine("Su salario total es de " + total);

            }
            else
            {
                total = horas * pago;
                Console.WriteLine("Su salario total es de " + total);
            }
        }
    }
}