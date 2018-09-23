using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones11  /* Escribe una función “AreaTriangulo” que te calcule el área de un triángulo. Habrá que 
                        pasarle como parámetros la base y la altura. */
{
    class Program
    {
        /// <summary>
        /// Función que calcula el área de un triángulo. Recibe parámetros para base y altura de usuario.
        /// </summary>
        /// <param name="b">Determina valor a un parámetro de la función</param>
        /// <param name="a">Determina valor a segundo parámetro de la función</param>
        /// <returns>Devuelve resultado del cálculo</returns>
        static int AreaTriangulo(int b, int a)
        {
            int resultado = (b * a) / 2;
            return resultado;
        }
        

        static void Main(string[] args)
        {
            int ba, al;
            int resultado = 0;
            Console.Write("Escriba la base: ");
            ba = int.Parse(Console.ReadLine());
            Console.Write("Escrib la altura: ");
            al = int.Parse(Console.ReadLine());
            Console.WriteLine("El área del triángulo es: "+ AreaTriangulo(ba, al));
            Console.ReadKey();
        }
        
    }
}
