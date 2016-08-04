using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 125, suma = 0, suma2 =0 ; 
            Console.WriteLine("Muestra de la suma de pares e impares de 10 a 125.");
            for (int i = 10; i <= 125; i += 2)
            {
                Console.Write("{0} +", i);
                suma = suma + i;
            }
                
            
            Console.WriteLine("Suma de los pares es: "+ suma + "\n");
            for (int i = 11; i <= 125; i = i + 2)
            {
                Console.Write("{0} + ", i);
                suma2 = suma2 + i;

            }
            Console.WriteLine("Suma de los pares es: " + suma2);
            Console.Read();
        }
    }
}
