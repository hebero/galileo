using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog16
{
    class Program
    {
        static void Main(string[] args)
        {
            double suma =0;
            Console.WriteLine("Progrma de la suma de 1/2 ...");
            for(double i = 2; i <=20; i++)
            {
                Console.Write("1/{0} + ", i);

                suma = suma + (1 / i);
            }
            Console.WriteLine("La suma es: " + suma);
            Console.Read();
        }
    }
}
