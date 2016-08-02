using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog07
{
    class Program
    {
        static void Main(string[] args)
        {
            int val1, val2, val3;
            Console.WriteLine("Ingrese el pimer lado del triangulo: ");
            val1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el pimer lado del triangulo: ");
            val2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el pimer lado del triangulo: ");
            val3 = Convert.ToInt32(Console.ReadLine());
            if(val1 == val2 && val3 == val1)
            {
                Console.WriteLine("Es un triangulo equilátero.");
                Console.ReadLine();
            }
            else if (val1 == val2 || val2 == val3 || val1 == val3)
            {
                Console.WriteLine("Es un triangulo isosceles.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Es un triangulo escaleno.");
                Console.ReadLine();
            }
        }
    }
}
