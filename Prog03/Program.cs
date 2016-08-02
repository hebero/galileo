using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog03
{
    class Program
    {
        static void Main(string[] args)
        {
            string Seg;
            int valSeg, horas, minutos, segundos, residuo;
            Console.WriteLine("Ingrese la cantidad de segundos a convertir: ");
            Seg = Console.ReadLine();
            valSeg = Convert.ToInt32(Seg);
            
            horas = valSeg/3600;
            minutos = ((valSeg - (horas * 3600)) /60);
            segundos = valSeg - ((horas*3600) + (minutos*60));
            Console.WriteLine("La conversion es : {0} horas : {1} minutos : {2} segundos",horas,minutos,segundos);
            Console.ReadLine();
        }
    }
}
