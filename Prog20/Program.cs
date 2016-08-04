using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Prog20
{
    class Program
    {
        static void Main(string[] args)
        {
            double sumatoria = 0;
            Console.WriteLine("Programa de la suma de los cuadrados de los primeros 100 números.");
            //Console.Write("");
            for (double i =1; i <=100; i ++)
            {
                sumatoria = sumatoria + Math.Pow(i, 2);
            }
            Console.WriteLine("La sumatoria es: {0}", sumatoria);
            Console.ReadLine();
        }
    }
}
