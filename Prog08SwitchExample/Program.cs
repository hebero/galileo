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
        static void TestFor3()
        {
            //Variables
            int n = 0; string sNum1 = "";
            Console.WriteLine("Ingrese un numero entero positivo:");
            sNum1 = Console.ReadLine();
            n = Convert.ToInt32(sNum1);
            for (int impar =1; impar <= n; impar += 2)
            {
                if ((impar ==n)||(impar == n - 1)){
                    Console.Write("{0} ", impar);
                }
                else
                {
                    Console.Write("{0}, ", impar);
                }
            }

        }
        static void TestFor4()
        {
            //Variables
            int n = 0; string sNum1 = "";
            Console.WriteLine("Ingrese un numero entero positivo:");
            sNum1 = Console.ReadLine();
            n = Convert.ToInt32(sNum1);
            for (int contador = 1 , impar = 1; contador <= n; contador = contador + 1, impar = impar + 2)
            {
                if ((impar == n)) //|| (impar == (n - 1)))
                {
                    Console.Write("{0}) {1} ", contador, impar);
                }
                else
                {
                    Console.Write("{0}) {1} ", contador , impar);
                }
            }
        }
        static void TestFor5()
        {
            int n = 0; string sNum1 = "";
            int sumatoria=0;
            Console.WriteLine("Ingrese un numero entero positivo:");
            sNum1 = Console.ReadLine();
            n = Convert.ToInt32(sNum1);
            for (int j =1; j<= n; j = j + 1)
            {
                if (j ==n )
                {
                    Console.Write("{0} ", j);
                }
                else
                {
                    Console.Write("{0} + ", j);
                }
                sumatoria = sumatoria + j; 
            }
            Console.WriteLine(" = {0}", sumatoria);
        }
        static void TestWhile1()
        {
            int n = 0; string sNum = "";
            bool EsNumero = false;
            Console.WriteLine("Ingrese un número entero:");
            sNum = Console.ReadLine();
            EsNumero = int.TryParse(sNum, out n);

            while (EsNumero == false) // o !EsNumero
            {
                Console.WriteLine("Ingrese un número entero:");
                sNum = Console.ReadLine();
                EsNumero = int.TryParse(sNum, out n);
            }
        }
        static void Main(string[] args)
        {
            //TestSwitch();
            TestWhile1();
            Console.ReadLine();
        }
    }
}
