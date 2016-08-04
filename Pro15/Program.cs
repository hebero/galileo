using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pro15
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, oper; bool conf = false; string snum;
            Console.WriteLine("Programa: Números decrecientes. \nIngrese un número positivo:");
            snum = Console.ReadLine();
            conf = int.TryParse(snum, out num);
            while (conf == false)// && num >=0)
            {
                Console.WriteLine("Programa de la tabla de multiplicar. \n Ingrese un número positivo:");
                snum = Console.ReadLine();
                conf = int.TryParse(snum, out num);
            }
            
            for (int i = num; i > 0; i--)
            {
                //num = num - i;
                Console.Write(" {0} ", i);            

            }
            Console.ReadLine();
        }
    }
}
