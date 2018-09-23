using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones1  /* Escribe una función que te diga si un número es par o no. La función se llamará “Par” y 
                        nos devolverá un valor booleano que será “verdadero” si el número es par y “falso” si 
                        es impar.*/
{
    class Program
    {
        /// <summary>
        /// Imprime en consola la palabra PAR si el entero que introduce el usuario es par, y viceversa.
        /// </summary>
        /// <param name="numero">Variable usada para el parámetro que permite introducir opción del nº entero</param>
        /// <returns>Respuesta en forma de string que devuelve la función</returns>
        static bool Par(int numero)
        {
            bool pares;
            int i = 2;

            if(numero %i == 0)
            {
                pares = true;
            }
            else
            {
                pares = false;
            }
            return pares;

        }

        static void Main(string[] args)
        {
            int numero;
           
            Console.Write("Escribe un número y te diré si es par o no: ");
            numero = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (Par(numero))
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
            Console.ReadKey();

        }
    }
}
