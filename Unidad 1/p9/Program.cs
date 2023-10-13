// See https://aka.ms/new-console-template for more information

using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum, res ,mul ,div;
            Console.WriteLine("Calculadora para realizar las operaciones basicas");
            Console.WriteLine("Introduce el primer numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo numero");
            num2 = Convert.ToInt32(Console.ReadLine());

            sum = num2 + num1;
            res = num2 - num1;
            mul = num2 * num1;
            div = num2 / num1;

            Console.WriteLine("Tus resultados fueron de la suma " + sum + " de la resta " + res + " de la multiplicacion "+  mul + " de la division "+div);

        }
    }
}
