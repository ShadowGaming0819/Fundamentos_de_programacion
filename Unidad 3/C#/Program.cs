// See https://aka.ms/new-console-template for more information
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingresa un valor de numeros: ");
            int maximo = Convert.ToInt32();

            if (maximo >= 2)
            {

                Console.WriteLine("Números primos hasta " + maximo + ":");

                for (int numero = 2; numero <= maximo; numero++)
                {
                    int divisores = 0;

                    for (int i = 1; i <= numero; i++)
                    {
                        if (numero % i == 0)
                        {
                            divisores++;
                        }
                    }

                    if (divisores == 2)
                    {
                        Console.WriteLine(numero + " ");
                    }
                }

            }
            else
            {
                Console.WriteLine("Por favor, ingrese un valor válido mayor o igual a 2");
            }

        }
    }
}