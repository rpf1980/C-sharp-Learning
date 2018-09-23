using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc_7_sentenciasCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {

            // Variables
            double a, b, c, disc, x1, x2;

            // Leemos los tres valores
            Console.WriteLine("Dime los valores de a, b, c en ax^2+bx+c=0");
            a = double.Parse(Console.ReadLine());
            b = double.Parse(Console.ReadLine());
            c = double.Parse(Console.ReadLine());

            

            // Calculamos la ecuación
            // Fórmula de la ecuación  x = -b +- SQRT(b^2 -4ac) / 2a

            disc = (b * b) - (4 * a * c);

            if (disc > 0)
            {   // Dos soluciones
                x1 = (-b + Math.Sqrt(disc)) / (2 * a);
                x2 = (-b - Math.Sqrt(disc)) / (2 * a);
                Console.WriteLine("Las dos soluciones son " + x1 + " y " + x2);
                //Console.WriteLine("Las dos soluciones son {0} y {1}", x1, x2);
            }
            else
            {
                if (disc == 0)
                { // Una solución
                    x1 = (-b) / (2 * a);
                    Console.WriteLine("Tiene una única solución: " + x1);
                }
                else
                {
                    // No tiene solución
                    Console.WriteLine("No tiene soluciones reales");
                }
            }Console.ReadKey();
            
        }
        
    }
}
