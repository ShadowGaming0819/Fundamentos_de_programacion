// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa2U3
    {
        static void Main(string[] args)
        {
            int c1, c2, c3, c4, c5, c6, res;
            Console.WriteLine("Programa para saber si un alumno esta aprobado o reprobado");
            Console.WriteLine("Introduce calificacion 1: ");
            c1 = Convert.ToInt32(Console.ReadLine());       
            Console.WriteLine("Introduce calificacion 2: ");
            c2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce calificacion 3: ");
            c3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce calificacion 4: ");
            c4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce calificacion 5: ");
            c5 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce calificacion 6: ");
            c6 = Convert.ToInt32(Console.ReadLine());

            res = (c1 + c2 + c3 + c4 + c5 + c6) / 6;


            if (res >= 70)
            {
                Console.WriteLine("Usted esta aprobado su calificacion es: " + res);

            }
            else
            {
                Console.WriteLine("Usted esta reprobado su calificacion es: " + res);
            }
        }
    }
}
