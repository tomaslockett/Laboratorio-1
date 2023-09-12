using System;

namespace Ejercicio_4
{
    internal class Program
    {
        static void limpiarpantalla()
        {
            Console.Clear();
        }

        static void Main(string[] args)
        {
            string cadena;
            int a, b;

            Console.Write("Ingrese un valor:");
            cadena = Console.ReadLine();
            a = Convert.ToInt32(cadena);

            Console.Write("Ingrese otro valor:");
            cadena = Console.ReadLine();
            b = Convert.ToInt32(cadena);

            limpiarpantalla(); 

            if (a == b)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }

            if (a < b)
            {
                Console.WriteLine("El primero es menor que el segundo");
            }
            else
            {
                Console.WriteLine("El segundo es menor que el primero");
            }
            Console.ReadKey();
        }
    }
}


