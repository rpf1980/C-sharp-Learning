using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcion20  /* Escribe una función “ResolucionCamara” a la que le pasas el número de MegaPixels 
                que tiene una cámara digital (puede ser un double) y nos dice cuál es la resolución 
                máxima de las fotos que hace la cámara. Los valores los devolverá en dos variables que 
                le pasamos por referencia (x, y). */
{
    class Program
    {
        /// <summary>
        /// Función que muestra la resolución de una cámara. El usuario escribe los megapíxeles en consola.
        /// </summary>
        /// <param name="megapixel">Determina el primer parámetro de la función</param>
        /// <param name="x">Determina el segundo parámetro de la función (valor de incógnita x)</param>
        /// <param name="y">Determina el tercer parámetro de la función (valor de incógnita y)</param>
        static void ResolucionCamara(double megapixel, out double x, out double y)
        {
            y = Math.Sqrt((megapixel * 1000000 * 9) / 16);
            x = (y * 16) / 9;

        }

        static void Main(string[] args)
        {
            double x, y, i;
            Console.Write("Escriba los megapixeles de su cámara para decirle la resulión que tiene: ");
            i = double.Parse(Console.ReadLine());
            ResolucionCamara(i, out x, out y);
            Console.WriteLine("La resolución es " + x + " x " + y);
            Console.ReadKey();
        }
    }
}
