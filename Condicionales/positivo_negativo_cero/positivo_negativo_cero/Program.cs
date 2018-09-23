using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace positivo_negativo_cero
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variable
            short numero;

            // Preguntamos
            Console.WriteLine("Dime un número");
            numero = short.Parse(Console.ReadLine());

            // Preguntamos
            if (numero > 0)
            {
                Console.WriteLine("Positivo");
            }
            else
            {
                if( numero == 0)
                {
                    Console.WriteLine("Cero");
                }
                else
                {
                    Console.WriteLine("Negativo");

                }
            }
            Console.ReadKey();
        }
    }
}
