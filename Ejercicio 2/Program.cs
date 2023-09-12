using System;

namespace Ejercicio_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            Console.WriteLine("Ingrese el valor de A:");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el valor de B:");
            b = int.Parse(Console.ReadLine());

            if (a == b)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }

            Console.ReadKey();

        }
    }
}

