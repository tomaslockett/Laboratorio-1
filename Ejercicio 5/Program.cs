using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int a, tot, i, j;
            tot = 0;
            Console.Write("ingrese cuantos numeros quiere sumar:");
            cadena = Console.ReadLine();
            j = Convert.ToInt32(cadena);
            for (i = 0; i < j; i++)
            {
                Console.Write("Ingrese un valor:");
                cadena = Console.ReadLine();
                a = Convert.ToInt32(cadena);
                tot = tot + a;
            }
            Console.WriteLine("El total de la suma es de {0}", tot);
            Console.ReadKey();
            
        }
    }
}
