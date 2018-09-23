using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones17  /* Escribe una función “Factorial” que nos calcule el factorial de un número entero. */
{
    class Program
    {
        /// <summary>
        /// Función que calcula el factorial de un número que el usuario escribe en consola.
        /// </summary>
        /// <param name="numero">Variable que determina el único parámetro de la función</param>
        /// <returns>Devuelve cálculo del factorial del nº escrito por el usuario</returns>
        static int Factorial(int numero)
        {
            int factorial, i;
            factorial = 1;
                      
            for(i = 1; i <= numero; i++)
            {
                factorial = factorial * i;
            }
            return factorial;
        }

        static void Main(string[] args)
        {
            int numero;
            Console.Write("Escriba un número para calcular su factorial: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("El factorial de " + numero + " es " + Factorial(numero));
            Console.ReadKey();
        }
    }
}
