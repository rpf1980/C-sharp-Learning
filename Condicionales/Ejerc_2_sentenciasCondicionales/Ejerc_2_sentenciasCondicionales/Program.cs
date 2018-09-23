using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc_2_sentenciasCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable
            int fecha;

            // Preguntamos
            Console.WriteLine("Qué año quieres saber si es bisiesto");
            fecha = int.Parse(Console.ReadLine());

            // Calculamos 
            if ( fecha % 4 == 0 ) // % 4 == 0 calcula el resto de dividir entre 4
            {
                Console.WriteLine("El año " + fecha + " es bisiesto");

            }
            else
            {
                Console.WriteLine("El año " + fecha + " no es bisiesto");

            }
            Console.ReadKey();
        }
    }
}
