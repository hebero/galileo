using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog10__09_
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Laboratorio No. 09*/
            int Cantidad = 0; string sCantidad = ""; bool confirm = false;
            try {
                Console.WriteLine("Laboratorio No. 09\nIngrese la cantidad de elementos deseados: ");
                sCantidad = Console.ReadLine();
                confirm = int.TryParse(sCantidad, out Cantidad);
                while (confirm == false)
                {
                    Console.WriteLine("Ingrese la cantidad de elementos deseados: ");
                    sCantidad = Console.ReadLine();
                    confirm = int.TryParse(sCantidad, out Cantidad);
                }
                for (int contador = 1, i = 0; contador <= Cantidad; contador = contador + 1, i = i + 2)
                {
                    if ((contador == Cantidad) || (contador == Cantidad - 1))
                    {
                        Console.Write("{0}){1}  ", contador, i);
                    }
                    else { Console.Write("{0}){1}  ", contador, i);
                    }

                }
                Console.Read();
            }
            catch(Exception ex){
                Console.WriteLine("Error de formato. {0}", ex.Message);
                Console.ReadLine();
            }
        }
    }
}
