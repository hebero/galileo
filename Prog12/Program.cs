using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog12
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Laboratorio No.12*/
            int Cantidad = 0, multi = 1; string sCantidad = ""; bool confirm = false;
            try {
                Console.WriteLine("Laboratorio No.12 \nIngrese la cantidad de elementos deseados: ");
                sCantidad = Console.ReadLine();
                confirm = int.TryParse(sCantidad, out Cantidad);
                while (confirm == false)
                {
                    Console.WriteLine("Ingrese la cantidad de elementos deseados: ");
                    sCantidad = Console.ReadLine();
                    confirm = int.TryParse(sCantidad, out Cantidad);
                }

                //proceso 

                for (int contador = 1; contador <= Cantidad; contador = contador + 1)
                {
                    if (contador == Cantidad)
                    {
                        Console.Write("{0}. ", contador);
                    }
                    else
                    {
                        Console.Write("{0} * ", contador);
                    }
                    multi = multi * contador;

                }
                Console.WriteLine("La multiplicación de {0} elementos  : {1}", Cantidad, multi);
                Console.Read();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error de formato. {0}", ex.Message);
                Console.ReadLine();
            }
            }
    }
}
