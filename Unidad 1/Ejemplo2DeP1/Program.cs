using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class EjemploDeP1
    {
        static void Main(string[] args)
        {
            string nombre = "Abraham", apellidos = "Gonzalez Macias", completo;
            completo = nombre + apellidos;
            int a = 5, b = 23, suma;
            suma = a + b;
            Console.WriteLine(" * * Bienvenido * * " + completo + " * * " );
            Console.Write("La operacion de suma A= " + a + " B= " + b);
            Console.Write($" Tu resultado es {suma}");
            Console.WriteLine(" -- Gracias :) ");
        }
    }
}