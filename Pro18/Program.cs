using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro18
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;  string snum1, snum2;
            Console.WriteLine("Ingrese el primer dígito:");
            snum1 = Console.ReadLine();
            Console.WriteLine("Ingrese el primer dígito:");
            snum2 = Console.ReadLine();

            a = Convert.ToInt32(snum1);
            b = Convert.ToInt32(snum2);
            if (a > b)
            {
                Console.WriteLine("El primer número es menor que el primero.");
                Console.ReadLine();
            }
            else if  (a==b || a +1 == b)
            {
                Console.WriteLine("No tienen rango de inicio a fin .");
                Console.ReadLine();
            }
            else
            {
                Console.Write("Los numeros desde {0} a {1} son: ", a, b);
                for(int i=a; i< b; i++)
                {
                    Console.Write("{0}, ", i);
                }
                Console.ReadLine();
            }

        }
        //function void bool a(int aa)
        //{
        //    return;
        //}

    }

}
