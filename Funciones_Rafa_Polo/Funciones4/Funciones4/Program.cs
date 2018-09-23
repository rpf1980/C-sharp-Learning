using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones4  /* Escribe una función “ImprimeSerie” a la que le pases dos enteros y te escriba por la 
                    pantalla todos los valores comprendidos entre ambos. Lo hará en orden ascendente si 
                    el primero es menor que el segundo y descendente en caso contrario. Usa “for”. */
{
    class Program
    {
        /// <summary>
        /// Función que escribe por pantalla todos los valores comprendidos entre dos enteros, ambos incluidos...
        /// si el primer nº es menor los imprime en orden ascendente, y viceversa.
        /// </summary>
        /// <param name="a">Variable del parámetro asignda para albergar primer nº</param>
        /// <param name="b">Variable del parámetro asignda para albergar segundo nº</param>
        static void ImprimeSerie(int a, int b)
        {
            int valores;
            if(a < b)
            {
                for(a = a; a <= b; a++)
                {
                    Console.WriteLine(a);
                    valores = a;
                }
            }
            else
            {
                for(a = a; a >= b; a--)
                {
                    Console.WriteLine(a);
                    valores = a;
                }
            }
            
        }

        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Escriba un nº: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Escriba un segundo nº: ");
            b = int.Parse(Console.ReadLine());
            ImprimeSerie(a,b);

            Console.ReadKey();

        }
    }
}
