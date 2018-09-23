using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones18  /*Escribe una función “Lee3” que te lea tres números del teclado. Para ello habrá que 
                        pasarle tres parámetros (a, b, c) por referencia. */
{
    class Program
    {
        /// <summary>
        /// Función que lee tres nº's del teclado.
        /// </summary>
        /// <param name="x">Designa el primer parámetro</param>
        /// <param name="y">Designa el segundo parámetro</param>
        /// <param name="z">Designa el tercer parámetro</param>
        static void Lee3(out int x, out int y, out int z)
        {
            Console.WriteLine("Escribe tres nº's por favor: ");
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());
            z = int.Parse(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            int a, b, c;
   
            Lee3(out a, out b, out c);
            Console.WriteLine("");
            Console.WriteLine("Los nº's escritos son: " + a + ", " + b + ", " + c);
            Console.ReadKey();
        }
    }
}
