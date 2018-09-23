using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones7  /*Escribe una función “Min” que nos devuelva el menor de los dos números que le 
                        pasemos por parámetro. */
{
    class Program
    {
        /// <summary>
        /// Determina valor minimo para dos nº's escritos en consola.
        /// </summary>
        /// <param name="n1">Variable para primer nº</param>
        /// <param name="n2">Variable para el segundo</param>
        /// <returns>Retorna valor menor de los nº's</returns>
        static int Min(int n1, int n2)
        {
            if (n1 < n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }

        static void Main(string[] args)
        {
            int n1, n2;
            Console.Write("Escriba el primer nº, por favor: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Escriba el segundo nº: ");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("El menor de los dos nº's es el " + Min(n1, n2));
            Console.ReadKey();
        }
    }
}
