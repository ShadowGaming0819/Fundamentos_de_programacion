// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa18U3
    {
        static void Main(string[] args)
        {
            int año;
            double salarioInicial = 1500.0, incrementoAnual = 0.10, salarioActual = salarioInicial;

            Console.WriteLine("Programa para calcular el salario de un profesor");
            Console.WriteLine("Año 1: " + salarioActual);

            for (año = 2; año <= 6; año++)
            {
                salarioActual += salarioActual * incrementoAnual;
                Console.WriteLine("Año " + año + ": Salario = " + salarioActual);
            }

            Console.WriteLine("Salario al cabo de 6 años: " + salarioActual);
        }
    }
}