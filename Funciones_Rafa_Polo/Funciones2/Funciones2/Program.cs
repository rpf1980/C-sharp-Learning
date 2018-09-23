using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones2  /*Escribe una función que nos diga si un año es bisiesto o no. La función se llamará 
                      “Bisiesto” y nos devolverá “verdadero” si es bisiesto y “falso” si no lo es.*/
{
    class Program
    {
        /// <summary>
        /// Función que determina si el año que introduce el usuario es bisiesto o no.
        /// </summary>
        /// <param name="anno">Valor que ingresa el usuario</param>
        /// <returns>Respuesta del cálculo realizado por la función</returns>
        static bool Bisiesto(int anno)
        {
            bool respuesta;
            int i = 4;
            if(anno %4 == 0) //Los años bisiestos son divisibles por 4
            {
                respuesta = true;
            }
            else
            {
                respuesta = false;
            }
            return respuesta;
        }

        static void Main(string[] args)
        {
            //Pedimos año
            int anno;

            Console.Write("Escribe un año y te diré si es bisiesto: ");
            anno = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (Bisiesto(anno))
            {
                Console.WriteLine("El año " + anno + " es bisiesto");
            }
            else
            {
                Console.WriteLine(anno + " no es bisiesto");
            }
            Console.ReadKey();
        }
    }
}
