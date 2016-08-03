using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog09
{
    class Program
    {
        static void Main(string[] args)
        {
            int horasT; string puesto;
            double sueldo;
            Console.WriteLine("Ingrese la horas trabajadas: ");
            horasT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el puesto del trabajador: \nD: \tDirector \nG: \tGerente \nS: \tSecretaria \nEV: \tEjecutivo \nSEC: \tSecretaria");
            puesto = Console.ReadLine();
            
            switch (puesto.ToUpper())
            {
                case "D":
                    sueldo = horasT * 600;
                    if (sueldo >= 8000)
                    { sueldo = (sueldo - ((sueldo * 0.20))); Console.WriteLine("Su sueldo menos el 20% de ISR es: " + sueldo); Console.Read(); }
                    else { Console.WriteLine("Su sueldo (sin descuento) es: " + sueldo); Console.Read(); }
                break;
                case "G":
                    sueldo = horasT * 450;
                    if (sueldo >= 8000)
                    { sueldo = (sueldo - ((sueldo * 0.20))); Console.WriteLine("Su sueldo menos el 20% de ISR es: " + sueldo); Console.Read(); }
                    else { Console.WriteLine("Su sueldo (sin descuento) es: " + sueldo); Console.Read(); }
                    break;
                case "S":
                    sueldo = horasT * 300;
                    if (sueldo >= 8000)
                    { sueldo = (sueldo - ((sueldo * 0.20))); Console.WriteLine("Su sueldo menos el 20% de ISR es: " + sueldo); Console.Read(); }
                    else { Console.WriteLine("Su sueldo (sin descuento) es: " + sueldo); Console.Read(); }
                    break;
                case "EV":
                    sueldo = horasT * 150;
                    if (sueldo >= 8000)
                    { sueldo = (sueldo - ((sueldo * 0.20))); Console.WriteLine("Su sueldo menos el 20% de ISR es: " + sueldo); Console.Read(); }
                    else { Console.WriteLine("Su sueldo (sin descuento) es: " + sueldo); Console.Read(); }
                    break;

                case "SEC":
                    sueldo = horasT * 80;
                    if (sueldo >= 8000)
                    { sueldo = (sueldo - ((sueldo * 0.20))); Console.WriteLine("Su sueldo menos el 20% de ISR es: " + sueldo); Console.Read(); }
                    else { Console.WriteLine("Su sueldo es: " + sueldo); Console.Read(); }
                    break;
            }

        }
    }
}
