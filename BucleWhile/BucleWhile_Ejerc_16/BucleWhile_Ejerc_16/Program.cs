using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleWhile_Ejerc_16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int a, b;

            // Preguntamos por consola
            Console.Write("Introduzca un número: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Introduzca un segundo número: ");
            b = int.Parse(Console.ReadLine());

            // Comprobamos cuál es mayor y menor
            if (a != b)
            {
                while (a > b)
                {
                    if (b % 2 == 1)
                    {
                        Console.WriteLine(b);
                    }
                    b = b + 1;
                }
                while (a < b)
                {
                    if (a % 2 == 1)
                    {
                        Console.WriteLine(a);
                    }
                    a = a + 1;
                }
            }
            else
            {
                Console.WriteLine("Los números son iguales.");
            }
            Console.ReadKey();


        }
    }
}
