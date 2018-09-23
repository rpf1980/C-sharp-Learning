using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc_1_sentenciasCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int a, b;

            // Preguntamos y damos valores las variables
            Console.WriteLine("Cuánto vale A??");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuánto vale B??");
            b = int.Parse(Console.ReadLine());



            // Condiciones
            if ( a > b)
            {
                Console.WriteLine("El resultado es " + (a - b));

            }
            else
            {
                Console.WriteLine("Resultado: " + (b - a));
            }
            Console.ReadKey();

        }
    }
}
