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
            int a, b, suma;
            string sNum1, sNum2;
            //Pedir valores
            Console.WriteLine("Ingrese un número entero:");
            sNum1 = Console.ReadLine();
            Console.WriteLine("Ingrese otro número entero:");
            sNum2 = Console.ReadLine();
            //Operaciones 
            a = Convert.ToInt32(sNum1);
            b = int.Parse(sNum2);
            suma = a + b;
            //Muestra de valores
            Console.WriteLine("La suma de {0} y {1} es: {2}", a,b,suma);
            Console.ReadLine();
        }
    }
}
