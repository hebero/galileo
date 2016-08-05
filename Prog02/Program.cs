using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog02
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Laboratorio No. 1*/
            //Declaración de variables
            int val1, val2, val3, val4;
            decimal prom=0;
            string sval1, sval2, sval3, sval4;

            Console.WriteLine("Laboratorio No. 01 \nIngrese primer valor: ");
            sval1 = Console.ReadLine();
            Console.WriteLine("Ingrese segundo valor: ");
            sval2 = Console.ReadLine();
            Console.WriteLine("Ingrese tercer valor: ");
            sval3 = Console.ReadLine();
            Console.WriteLine("Ingrese cuarto valor: ");
            sval4 = Console.ReadLine();
            try {
                val1 = Convert.ToInt32(sval1);
                val2 = Convert.ToInt32(sval2);
                val3 = Convert.ToInt32(sval3);
                val4 = Convert.ToInt32(sval4);
                prom = (decimal)(val1 + val2 + val3 + val4) / 4;
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error de formato. {0}", ex.Message);
            }
            finally {
                Console.WriteLine("El promedio es:" + prom);
                Console.ReadLine();
            }
        }
    }
}
