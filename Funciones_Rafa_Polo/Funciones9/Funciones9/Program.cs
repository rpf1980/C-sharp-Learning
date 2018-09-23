using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones9  // Escribe una función que nos calcule el “mcm” de dos números.
{
    class Program
    {

        /// <summary>
        /// Función que calcula el mcm de dos nº al azar que el usuario escribe por consola.
        /// </summary>
        /// <param name="a">Variable que declara el primer nº introducido</param>
        /// <param name="b">Variable para el segundo nº</param>
        /// <returns>Devuelve nº correspondiente al mcm entre a y b</returns>
        static int Mcm(int a, int b)
        {
            
            int i, mcm;
            i = a; 
            while(!(i %a == 0 && i %b == 0))
            {
                i++;                
            }
            mcm = i;
            return mcm;

        }

        static void Main(string[] args)
        {

            int a, b;
            Console.WriteLine("Escribe un valor entero para el primer nº: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe un valor para el segundo nº: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("El m.c.m. de " + a + " y " + b + " es: " + Mcm(a, b));

            Console.ReadKey();
        }
    }
}
