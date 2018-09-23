using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones19  /* Escribe una función “Inc” que nos incremente el valor de una variable. Para ello, le 
                    pasaremos la variable por referencia para que nos la pueda incrementar. Escribe 
                    también la función “Dec”. */
{
    class Program
    {
        /// <summary>
        /// Funcion que incrementa un nº escrito en consola.
        /// </summary>
        /// <param name="valor">Designa el parámetro de la función</param>
        static void Inc(ref int valor)
        {            
            valor = valor + 1;
        }

        static void Main(string[] args)
        {
            int a;
            Console.Write("Escribe un nº par incrementarlo, por favor: ");
            a = int.Parse(Console.ReadLine());
            Inc(ref a);

            Console.WriteLine(a);
            Console.ReadKey();
        }
    }
}
