﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prog04
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Laboratorio No.03*/
            //declaracion de variables
            int val1 =0, val2=0, val3=0, prom=0;
            try
            {
                Console.WriteLine("Laboratorio No.3 \nIngrese el primer valor positivos:");
                val1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el segundo valor positivos:");
                val2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese el tercer valor positivos:");
                val3 = Convert.ToInt32(Console.ReadLine());
                prom = (val1 + val2 + val3) / 3;
            }
            catch(FormatException ex) {
                Console.WriteLine("Error de formato. {0}", ex.Message);
            }
            finally{
                if (val1 > 0 && val2 > 0 && val3 > 0)
                {

                    if (prom >= 60)
                    {
                        Console.WriteLine("Aprobado con un promedio de: " + prom);
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Reprobado con un promedio de: " + prom);
                        Console.ReadLine();
                    }
                }
                else
                {
                    Console.WriteLine("Solo numeros positivos.");
                    Console.ReadLine();
                }
            }
        }
    }
}
