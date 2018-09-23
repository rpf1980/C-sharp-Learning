using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones8  // Escribe una función que nos calcule el “MCD” de dos números. 
{
    class Program
    {
        /// <summary>
        /// Calcula el MCD de dos nº que el usuario escribe por consola.    
        /// </summary>
        /// <param name="a">Variable para el primer nº</param>
        /// <param name="b">Variable para el segundo nº</param>
        /// <returns>Devuelve el nº que corresponde al mínimo divisor entre los nº's de los valores escritos por el usuario</returns>
        static int Mcd(int a, int b)
        {
                       
            int i, mcd;
            i = a;
            while(!(a % i == 0 && b % i == 0))
            {
                i--;
            }
            mcd = i;
            return mcd;
                       
        }

        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Escriba el primer nº: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba el segundo nº: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("El MCD de " + a + " y " + b + " es: " + Mcd(a, b));
            Console.ReadKey();
        }
    }
}
