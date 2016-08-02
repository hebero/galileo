using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog04
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaracion de variables
            int val1, val2, val3, prom;
            Console.WriteLine("Ingrese el primer valor positivos:");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo valor positivos:");
            val2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer valor positivos:");
            val3 = Convert.ToInt32(Console.ReadLine());
            prom = (val1 + val2 + val3) / 3;
            if (prom >= 60)
            {
                Console.WriteLine("Aprobado con un promedio de: " + prom);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Reprobado con un promedio de: " + prom);
                Console.ReadLine();
            }

        }
    }
}
