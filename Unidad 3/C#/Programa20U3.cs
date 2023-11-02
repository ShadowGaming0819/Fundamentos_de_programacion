// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Programa20U3
    {
        static void Main(string[] args)
        {
                int dia = 1, ahorroDiario = 3, ahorroAnual = 0;

                while (dia <= 365)
                {
                    ahorroAnual += ahorroDiario;
                Console.WriteLine("Día " + dia + ": Ahorro diario= " + ahorroDiario);
                    ahorroDiario *= 3;

                    dia++;
                }

            Console.WriteLine("Ahorro anual: " + ahorroAnual + " pesos ");
      
        }
    }
}