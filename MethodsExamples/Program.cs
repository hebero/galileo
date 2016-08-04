using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExamples
{
    class Program
    {
        static void SumatoriaPareseImpares()
        {
            int SumaPares = 0, SumaImpares=0;
            for (int i = 10; i< 125; i++)
            {

            }
        }
        static bool EsPar(int Numero)
        {
            bool Bandera = false;
            if ((Numero % 2) == 0)
            {
                Bandera = true;
            }
            else { Bandera = false; }
            return Bandera;
        }
        static void Main(string[] args)
        {

            if (EsPar(2))
            {
                Console.WriteLine("El numero es par.");
            }
            else
            {
                Console.WriteLine("El numero no es par.");
            }
            Console.Read();
        }
    }
}
