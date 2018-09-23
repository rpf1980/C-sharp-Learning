using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio22
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, i, factorial;

            factorial = 1;
            i = 1;           

            Console.Write("Introduce un número para calcular su factorial: ");
            n = int.Parse(Console.ReadLine());

            while (i <= n)
            {
                factorial = factorial * i;
                i = i + 1;
            }
           

            Console.WriteLine("El factorial de " + n + " es " + factorial);
            Console.ReadKey();



        }
        
    }
}
