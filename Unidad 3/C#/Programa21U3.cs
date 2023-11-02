// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa21U3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de números a procesar: ");
            int cantidadNumeros = Convert.ToInt32(Console.ReadLine());

            int contador = 1, cubo;
            while (contador <= cantidadNumeros)
            {
                Console.WriteLine("Ingrese un número natural positivo: ");
                int numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    cubo = numero * numero * numero;
                    Console.WriteLine("El cubo de " + numero + " es " + cubo);
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número natural positivo.");
                }

                contador++;
            }
        }
    }
}