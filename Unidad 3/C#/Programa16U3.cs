// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa16U3
    {
        static void Main(string[] args)
        {
            int c = 1, horas, pago, sueldo;
            Console.WriteLine("Determinar el sueldo semanal de horas trabajadas");
            while (c <= 20)
            {
                Console.WriteLine("Introduce las horas trabajadas ");
                horas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Introduce el sueldo por hora ");
                pago = Convert.ToInt32(Console.ReadLine());
                sueldo = horas * pago;
                Console.WriteLine("El sueldo del trabajador es " + sueldo);
                c++;
            }
        }
    }
}