using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones16  /* Escribe una función “Elevado” a la que le pasas dos números enteros (a y b) y te 
                    devuelve el valor de “a” elevado a “b” (sin usar la función Math.Pow) (o sea, 
                    multiplicando un número muchas veces). */
{
    class Program
    {
        /// <summary>
        /// Función que calcula el exponente de cualquier nº entero que escriba el usuario por consola.
        /// </summary>
        /// <param name="a">Asigna el primero valor del parámetro</param>
        /// <param name="b">Asigna el segundo valor del parámetro</param>
        /// <returns>Devuelve resultado del cálculo de exponenciación</returns>
        static int Elevado(int a, int b)
        {
            int resultado, contador;
            resultado = 1;

            for(contador = 1; contador <= b; contador++)
            {
                resultado = resultado * a;
            }
            return resultado;
        }

        static void Main(string[] args)
        {
            int numero, exponente;
            Console.Write("Escriba un nº: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Escriba el exponente: ");
            exponente = int.Parse(Console.ReadLine());
            Console.WriteLine("El resultado de elevar " + numero + " al " + exponente + " es: " + Elevado(numero, exponente));
            Console.ReadKey();

        }
    }
}
