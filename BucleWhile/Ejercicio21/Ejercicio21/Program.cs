using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int num, max, min, suma, promedio, i;

            Console.Write("Introduce un número: ");
            num = int.Parse(Console.ReadLine());

            i = 0; // Contador vueltas de bucle
            max = num; // Acumulador
            min = num;
            suma = 0;

            // Bucle

            while (i < 9)
            {
                Console.Write("Introduce otro número: ");
                num = int.Parse(Console.ReadLine());

                if (num > max)
                {
                    max = num;
                }

                if (num < min)
                {
                    min = num;
                }

                suma = suma + num;

                i = i + 1; // Cuenta las vueltas de bucle

            }
            promedio = suma / 10;
            Console.WriteLine("El promedio de los 10 números es: " + promedio);
            Console.WriteLine("El máximo es: " + max);
            Console.WriteLine("El mínimo es: " + min);
            Console.ReadKey();

        }
    }
}
