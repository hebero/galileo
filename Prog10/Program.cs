using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog10
{
    class Program
    {
        static void Main(string[] args)
        {
            int Cantidad; string sCantidad; bool confirm = false;
            Console.WriteLine("Ingrese la cantidad de elementos deseados: ");
            sCantidad = Console.ReadLine();
            confirm = int.TryParse(sCantidad, out Cantidad);
            while (confirm == false)
            {
                Console.WriteLine("Ingrese la cantidad de elementos deseados: ");
                sCantidad = Console.ReadLine();
                confirm = int.TryParse(sCantidad, out Cantidad);
            }
            for (int contador = 1, i = 1; contador <= Cantidad; contador = contador + 1, i = i + 2)
            {
                if ((contador == Cantidad) || (contador == Cantidad - 1))
                {
                    Console.Write("{0}){1}  ", contador, i);
                }
                else {
                    Console.Write("{0}){1}  ", contador, i);
                }

            }
            Console.Read();
        }
    }
}
