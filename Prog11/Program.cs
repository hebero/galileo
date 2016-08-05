using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog11
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Laboratorio No.11*/
            int Cantidad=0, suma =0; string sCantidad=""; bool confirm = false;
            try {
                Console.WriteLine("Laboratorio No.11\nIngrese la cantidad de elementos deseados: ");
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
                        Console.Write("{0} + ", contador);
                    }
                    suma = suma + contador;

                }
                Console.WriteLine("La sumatoria es: " + suma);
                Console.Read();
            }catch(Exception ex)
            {
                Console.WriteLine("Error de formato. {0}", ex.Message);
                Console.ReadLine();
            }
        }
    }
}
