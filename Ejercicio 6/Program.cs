using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            int leg, sdo, cont = 0;
            float tot = 0, prom;

            Console.Write("Ingrese el legajo (0 para finalizar): ");
            cadena = Console.ReadLine();
            leg = Convert.ToInt32(cadena);

            while (leg != 0)
            {
                Console.Write("Ingrese el sueldo: ");
                cadena = Console.ReadLine();
                sdo = Convert.ToInt32(cadena);
                tot = tot + sdo;
                cont = cont + 1;

                Console.Write("Ingrese el legajo (0 para finalizar): ");
                cadena = Console.ReadLine();
                leg = Convert.ToInt32(cadena);
            }

            if (cont > 0)
            {
                prom = tot / cont;
                Console.WriteLine("El total pagado es: {0}", tot);
                Console.WriteLine("El sueldo promedio es: {0:F5}", prom);
            }
            else
            {
                Console.WriteLine("No se ingresaron sueldos.");
            }

            Console.ReadKey();


        }
    }
}
