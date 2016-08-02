using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog08SwitchExample
{
    class Program
    {
        static void TestSwitch()
        {
            int Edad;
            Edad = 17;
            switch (Edad)
            {
                case 1 - 12:
                    Console.WriteLine("Escolar");
                    Console.ReadLine();
                    break;
                case 13:
                case 14:
                case 15:
                    Console.WriteLine("Adolescente");
                    Console.ReadLine();
                    break;
                case 16 - 18:
                    Console.WriteLine("Joven adulto");
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Adulto");
                    Console.ReadLine();
                    break;
            }
        }
        static void TestFor()
        {
            int n;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadLine();
        }
        static void TestFor2()
        {
            int n = 0;
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i += 2)
            {
                Console.Write("{0}, ",i);
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            //TestSwitch();
            TestFor2();
        }
    }
}
