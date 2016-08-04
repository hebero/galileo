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
            //for (int i = 10; i< 125; i++)
            //{

            //}
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
        static bool EsPar(string Numero, out int NumeroEntero)
        {
            int num = 0; bool Flag = false;
            try
            {
                num = int.Parse(Numero);
                Flag = ((num % 2) == 0);

            }

            catch (FormatException ex)
            {
                Console.WriteLine("Solo puede ingresar números. {0}", ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: ", ex.Message);
            }
            finally
            {
                NumeroEntero = num;
            }
            return Flag;

        }
        static void Main(string[] args)
        {
            string sNum = ""; int Num = 0;
            Console.WriteLine("Ingrese numero:");
            sNum = Console.ReadLine();

            if (EsPar(sNum, out Num))
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
