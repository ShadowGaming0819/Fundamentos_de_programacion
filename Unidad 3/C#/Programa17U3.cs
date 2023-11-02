// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa17U3
    {
        static void Main(string[] args)
        {
            char opcion;
            do
            {
                Console.WriteLine("Bienvenido a una sola ejecucion");
                Console.WriteLine("Escribe n para salir");
                opcion = Convert.ToChar(Console.ReadLine());
            } while (opcion != 'n');
        }
    }
}