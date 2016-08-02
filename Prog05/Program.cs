using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog05
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.WriteLine("Ingrese el número entero:");
            valor = Convert.ToInt32(Console.ReadLine());
            if (valor > 0)
            {
                Console.WriteLine("El número es positivo.");
                Console.ReadLine();
            }
            else if(valor==0){
                Console.WriteLine("El número es el cero.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("El número es negativo");
                Console.ReadLine();
            }
        }
    }
}
