// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double p1, p2, p3, iva, precio, total;
            Console.WriteLine("Programa para calcular el iva de una compra");
            Console.WriteLine("Introduce el presio del producto 1");
            p1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el presio del producto 2");
            p2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el presio del producto 3");
            p3 = Convert.ToInt32(Console.ReadLine());

            precio = p1 + p2 + p3;

            iva = precio * 0.16;

            total = precio + iva;

            Console.WriteLine("El subtotal de los productos fue" + precio + " y el total con iva fue "+total);
        }
    }
}
