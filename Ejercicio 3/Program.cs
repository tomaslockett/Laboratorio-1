using System;

namespace Ejercicio_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Cadena;
            int a, b, c;
            Console.Write("Ingrese el valor de la hora:");
            Cadena = Console.ReadLine();
            a = Convert.ToInt32(Cadena);
            Console.Write("Ingrese el tiempo trabajado:");
            Cadena = Console.ReadLine();
            b = Convert.ToInt32(Cadena);
            c = a * b;
            Console.WriteLine("El sueldo es de {0}", c);
            Console.ReadLine();

        }
    }
}
