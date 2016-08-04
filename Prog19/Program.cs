using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog19
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador =0;
            Console.Write("Los números impares de 1 al 100 son:");
            for (int i =1; i <=100; i= i + 2)
            {
                Console.Write(" {0} ", i);
                contador++;
            }
            Console.WriteLine("\nEl numero de impares entre 1 a 100 son: {0}", contador);
            Console.Read();

        }
    }
}
