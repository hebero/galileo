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
            /*Laboratorio No.08*/
            int horasT = 0; string puesto = "";
            double sueldo=0; bool confirm =false;
            try {
                Console.WriteLine("Laboratorio No.08 \nIngrese la horas trabajadas: ");
                //Utilizando Tryparse
                confirm = int.TryParse(Console.ReadLine(), out horasT);

            while (!confirm)
            {
                Console.WriteLine("Ingrese la horas trabajadas: ");
                confirm = int.TryParse(Console.ReadLine(), out horasT);
            }
            Console.WriteLine("Ingrese el puesto del trabajador: \nD: \tDirector \nG: \tGerente \nS: \tSecretaria \nEV: \tEjecutivo \nSEC: \tSecretaria");
            puesto = Console.ReadLine();
        }

            catch (Exception ex)
            {
                Console.WriteLine("Error de formato. {0}", ex.Message);
            }
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
                default:
                    Console.WriteLine("El puesto ingresado no existe.");
                    Console.Read();
                    break;
            }

        }
    }
}
