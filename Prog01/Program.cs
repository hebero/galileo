using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inicio de variables
            int valor1, valor2, suma;
            string sNum1, sNum2;
            Console.WriteLine("Ingrese el primer valor:");
            sNum1 = Console.ReadLine();
            Console.WriteLine("Ingrese el segundo valor:");
            sNum2 = Console.ReadLine();
            valor1 = Convert.ToInt32(sNum1);
            valor2 = Convert.ToInt32(sNum2);
            suma = valor1 + valor2;
            Console.WriteLine("La suma es:" + suma.ToString());
            Console.ReadLine();
        }
    }
}
