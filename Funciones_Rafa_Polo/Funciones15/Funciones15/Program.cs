using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones15  /*Escribe una función “LeeNúmero” a la que le pasas dos parámetros (a y b) y nos lee del 
                    teclado un número comprendido entre a y b (ambos incluidos). Si el número no es 
                    correcto, te vuelve a pedir que lo introduzcas.*/
{
    class Program
    {
        /// <summary>
        /// Función que determina si un nº escrito por consola está en cierto rango de otro dos nº's también escritos por el usuario.
        /// </summary>
        /// <param name="min">Parámetro de la función que designa el valor mínimo requerido para el rango del ejercicio</param>
        /// <param name="max">Parámetro de la función que designa el valor máximo requerido para el rango del ejercicio</param>
        /// <returns></returns>
        static int LeeNumero(int min, int max)
        {
            int n;
            Console.WriteLine("Escriba un número que se encuentre en el rango del ejercicio");
            n = int.Parse(Console.ReadLine());

            // while (n < min || n > max)
            while(!(n >= min && n <= max))
            {
                Console.WriteLine("El nº escrito no se encuentra en el rango requerido, escriba otro por favor");
                n = int.Parse(Console.ReadLine());

            }
            return n;
                 
        }

        static void Main(string[] args)
        {
            int a, b, n;

            Console.WriteLine("Escriba un nº: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba otro nº: ");
            b = int.Parse(Console.ReadLine());

            n = LeeNumero(a, b);
            Console.WriteLine("El número leído es " + n);
            Console.ReadKey();
        }
    }
}
