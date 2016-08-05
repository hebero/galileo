using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog08
{
    class Program
    {
        static void Main(string[] args)
        {
            /* daniel.santizo71@gmail.com*/
            /*Laboratorio 07*/
            int val1 =0, val2 = 0, val3 = 0, val4 = 0;
            try {
                Console.WriteLine("Laboratorio No.07\nIngrese el primer dígito");
                val1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo dígito");
                val2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el tercer dígito");
                val3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el cuarto dígito");
                val4 = Convert.ToInt32(Console.ReadLine());
            }
            catch(FormatException ex){
                Console.WriteLine("Error de formato. {0}", ex.Message);
            }
            if (val1 >= 0 && val2 >= 0 && val3 >= 0 && val4 >= 0)
            {
                if (val1 > val2 && val1 > val3 && val1 > val4)
                {
                    Console.WriteLine("El numero mayor es primer número: " + val1);
                    Console.ReadLine();
                }
                else if (val2 > val1 && val2 > val3 && val2 > val4)
                {
                    Console.WriteLine("El numero mayor es segundo número: " + val2);
                    Console.ReadLine();
                }
                else if (val3 > val1 && val3 > val2 && val3 > val4)
                {
                    Console.WriteLine("El numero mayor es tercer número: " + val3);
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("El numero mayor es cuarto número: " + val4);
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Solo número positivos.");
                Console.ReadLine();
            }
        }
    }
}
