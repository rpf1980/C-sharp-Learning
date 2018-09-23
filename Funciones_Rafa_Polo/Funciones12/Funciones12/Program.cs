using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones12  /*Escribe una función “PulgadasACentimetros” a la que le pases un valor en pulgadas (de 
                        tipo double) y te devuelva el valor en centímetros. Haz también la función 
                        “CentímetrosAPulgadas”.*/
{
    class Program
    {
        /// <summary>
        /// Función que realiza conversión de pulgadas a centímetros.
        /// </summary>
        /// <param name="x">Variable asignada para el nº que el usuario ingresa por consola. Pertenece al único parámetro para la función</param>
        /// <returns>Devuelve resultado de la conversión pulagadas a centímetros</returns>
        static double PulgadasACentimetros(double x)
        {
            const double cent = 2.54;
            double resultado = x * cent;
            return resultado;

        }

        /// <summary>
        /// Función que realiza conversión de centímetros a pulgadas.
        /// </summary>
        /// <param name="x">Variable que designa el parámetro de la función. Almacena el valor que el usuario pone por consola.</param>
        /// <returns>Devuelve resultado del cálculo de la conversión (centímetros a pulgadas)</returns>
        static double CentimetrosApulgadas(double x)
        {
            const double cent = 2.54;
            double resultado = x / cent;
            return resultado;
        }
        static void Main(string[] args)
        { 
            double numero;
            
            Console.WriteLine("Escriba las pulgadas que quiere convertir: ");
            numero = double.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es: " + PulgadasACentimetros(numero));

            Console.WriteLine("Escriba los centímetros que quiere convertir: ");
            numero = double.Parse(Console.ReadLine());
            Console.WriteLine("El resultado es: " + CentimetrosApulgadas(numero));

            Console.ReadKey();

        }
    }
}
