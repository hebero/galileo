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
            //Variables
            int Cantidad, suma = 0; string sCantidad; bool confirm = false;
            Console.WriteLine("Ingrese la cantidad de elementos deseados: ");
            sCantidad = Console.ReadLine();
            confirm = int.TryParse(sCantidad, out Cantidad);
            //Validación
            while (confirm == false)
            {
                Console.WriteLine("Ingrese la cantidad de elementos deseados: ");
                sCantidad = Console.ReadLine();
                confirm = int.TryParse(sCantidad, out Cantidad);
            }

            //proceso 
            int pross;
            for (int contador = 1, i = 1; contador <= Cantidad; contador = contador + 1, i = i + 2)
            {
                pross = contador % 2;
                if (pross != 0)
                {
                    Console.WriteLine("+4/{0}", i);
                }
                else
                {
                    Console.WriteLine("-4/{0}", i);
                }

            }
            Console.Read();
        }
            //    if (contador == Cantidad)
            //    {
            //        Console.Write("{0}. ", contador);
            //    }
            //    else
            //    {
            //        Console.Write("{0} + ", contador);
            //    }
            //    suma = suma + contador;

            //}
            //Console.WriteLine("La sumatoria es: " + suma);
            //Console.Read();
        //}
    }
}
