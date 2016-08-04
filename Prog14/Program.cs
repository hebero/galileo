using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog14
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, oper; bool conf = false; string snum;
            Console.WriteLine("Programa de la tabla de multiplicar. \nIngrese un número positivo:");
            snum = Console.ReadLine();
            conf = int.TryParse(snum, out num);
            while (conf == false)
            {
                Console.WriteLine("Programa de la tabla de multiplicar. /n Ingrese un número positivo:");
                snum = Console.ReadLine();
                conf = int.TryParse(snum, out num);
            }
            for(int i = 0; i <= 10; i++)
            {
                oper = num * i;
                Console.WriteLine("{0}   x   {1} = {2}\n",i ,num, oper );
            }
            Console.ReadLine();
        }
    }
}
