using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog06
{
    class Program
    {
        static void Main(string[] args)
        {
            int anio, convert1, convert2, convert3;
            Console.WriteLine("Ingrese su año de nacimiento: ");
            anio = Convert.ToInt32(Console.ReadLine());
            convert3 = anio % 400;
            convert1 = anio % 4;
            convert2 = convert1 % 100;
            if(anio >= 0)
            { 
                if (convert3 == 0)
                {
                    Console.WriteLine("El año " + anio + " fue biciesto");
                    Console.ReadLine();
                }
                else {

                    if (convert1 == 0 && convert2 == 0)
                    {
                        Console.WriteLine("El año " + anio + " fue biciesto");
                        Console.ReadLine();
                    }
                    else {
                        Console.WriteLine("El año " + anio + " no fue biciesto");
                        Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("Solo valores positivos.");
                Console.ReadLine();
            }
        }
    }
}
