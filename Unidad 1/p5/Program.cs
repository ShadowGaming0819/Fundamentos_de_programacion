using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alt, bas, res, per, a, b, c ;

            Console.WriteLine("Programa para calcular el area y perimetro de un triangulo");

            Console.WriteLine("Para calcular el area: ");

            Console.WriteLine("Escriba la base del triangulo");
            bas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escriba la altura del triangulo");
            alt = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Para calcular el perimetro: ");

            Console.WriteLine("Escriba el valor de lado 1  del triangulo");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el valor de lado 2  del triangulo");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Escriba el valor de lado 3  del triangulo");
            c = Convert.ToInt32(Console.ReadLine());


            res = (bas * alt) / 2;

            per = a + b + c;

            Console.WriteLine("El area del triangulo es " + res + "El perimetro es" + per);




        }
    }
}
