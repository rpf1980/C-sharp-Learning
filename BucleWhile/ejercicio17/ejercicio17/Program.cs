using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Programa que sume los números pares del 1 al 1000
            // Variables, i para contador, n para acumulador
            int i, n;

            i = 0;

            n = 0;

            // Bucle
            
            while (i <= 1000)
            {

                n = n + i;
                i = i + 2;
              
            }

            Console.WriteLine("La suma de los pares entre 1 y 1000 es: " + n);
            Console.ReadKey();
        }
    }
}
