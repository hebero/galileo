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
            /*Laboratorio No.5*/
            int anio = 0, convert1 = 0, convert2 = 0, convert3 = 0;
            try
            {
                
                Console.WriteLine("Laboratorio No.05\nIngrese su año de nacimiento: ");
                anio = Convert.ToInt32(Console.ReadLine());
                convert3 = anio % 400;
                convert1 = anio % 4;
                convert2 = convert1 % 100;
            }
            catch(FormatException ex) {
                Console.WriteLine("Error de formato. {0}", ex.Message);
            }

            if (anio >= 0)
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
