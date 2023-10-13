using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class promedio
    {
        static void Main(string[] args)
        {

            int cal1, cal2, cal3, cal4 , cal5 , cal6;
            float res;
            string nombre;

            Console.WriteLine("Escribe tu nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Tu nombre es: " + nombre);

            Console.WriteLine("Escribe calificacion 1: ");
            cal1 = Convert.ToInt32(Console.ReadLine() );

            Console.WriteLine("Escribe calificacion 2: ");
            cal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe calificacion 3: ");
            cal3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe calificacion 4: ");
            cal4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escribe calificacion 5: ");
            cal5 = Convert.ToInt32(Console.ReadLine()); ;

            Console.WriteLine("Escribe calificacion 6: ");
            cal6 = Convert.ToInt32(Console.ReadLine());

            res = (cal1 + cal2 + cal3 + cal4 + cal5 + cal6) / 6;

            Console.WriteLine("Tu calificacion es: " + res);
        }
    }
}
