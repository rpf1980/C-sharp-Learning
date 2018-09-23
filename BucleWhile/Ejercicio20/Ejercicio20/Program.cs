using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Program
    {
        static void Main(string[] args)
        {
            // Calcular valor máximo de 10 diez números introducidos

            // Varibles---> Contador 

            int i, n, max;

            Console.Write("Introduce un número: ");
            n = int.Parse(Console.ReadLine());

            max = n; // Acumulador

            i = 0; // Contador de vueltas de bucle

            while (i < 9)
            {
                Console.Write("Introuce un número: ");
                n = int.Parse(Console.ReadLine());

                if (n > max)
                {
                    max = n;
                }
                i = i + 1; // Cuenta vueltas del bucle hasta 9

            }

            Console.WriteLine("El número mayor de todos es: " + max);
            Console.ReadKey();

        }
    }
}
