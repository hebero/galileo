using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog13
{
    class Program
    {
        static void Main(string[] args)
            /*Laboratorio No.13*/
        { //Variables
            int Cantidad=0, pross =0; string sCantidad; bool confirm = false;
            Console.WriteLine("Ingrese la cantidad de elementos deseados: ");
            sCantidad = Console.ReadLine();
            confirm = int.TryParse(sCantidad, out Cantidad);
            //Validación
            while (confirm == false || Cantidad < 0)
            {
                Console.WriteLine("Ingrese la cantidad de elementos deseados: ");
                sCantidad = Console.ReadLine();
                confirm = int.TryParse(sCantidad, out Cantidad);
            }

            //proceso 
            for (int contador = 1, i = 1; contador <= Cantidad; contador = contador + 1, i = i + 2)
            {
                pross = contador % 2;
                if (pross != 0)
                {
                    Console.Write("+4/{0}  ", i);
                }
                else
                {
                    Console.Write("-4/{0}  ", i);
                }

            }
            Console.Read();
        }
    }
}
