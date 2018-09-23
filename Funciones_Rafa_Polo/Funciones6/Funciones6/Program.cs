using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones6  /* Escribe una función “Max” que nos devuelva el mayor de los dos números que le 
                        pasemos por parámetro.*/
{
    class Program
    {
        /// <summary>
        /// Determina cuál es el mayor de dos nº's enteros escritos por consola.
        /// </summary>
        /// <param name="numero1">Variable para el primer nº</param>
        /// <param name="numero2">Variable para el segundo nº</param>
        /// <returns>Devuelve cuál es mayor</returns>
        static int Max(int numero1, int numero2)
        {
            if(numero1 > numero2)
            {
                return numero1;
            }
            else
            {
                return numero2;
            }
            
        }

        static void Main(string[] args)
        {
            int numero1, numero2;
            Console.WriteLine("Escriba un nº: ");
            numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba otro: ");
            numero2 = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("El mayor de los números escritos es "+ Max(numero1, numero2));
            Console.ReadKey();
        }
    }
}
