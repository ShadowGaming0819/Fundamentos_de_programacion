// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de numeros (N): ");
            int n = Convert.ToInt32(Console.ReadLine());
            int igualCero = 0, menorCero = 0, mayorCero = 0;

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ingrese el numero " + (i + 1) + ": ");
                double numero = Convert.ToDouble(Console.ReadLine());

                if (numero == 0)
                {
                    igualCero++;
                }
                else if (numero > 0)
                {
                    mayorCero++;
                }
                else
                {
                    menorCero++;
                }
            }

            Console.WriteLine("Numeros iguales a cero: " + igualCero);
            Console.WriteLine("Numeros mayores a cero: " + mayorCero);
            Console.WriteLine("Numeros menores a cero: " + menorCero);
        }
    }
}