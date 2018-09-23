using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones5  /*Escribe una función “Signo” a la que le pasemos un número y nos devuelva “1” si es 
                        positivo, “0” si es cero y “-1” si es negativo.*/
{
    class Program
    {
        /// <summary>
        /// Función que determina si un nº es -, + , 0... devulve -1, 1 y 0 por cada opción.
        /// </summary>
        /// <param name="n">Parámetro que almacena valor que usuario elige por consola</param>
        static int Signo(int n)
        {
            int signo;
            
            if (n > 0)
            {
                signo = 1;                
            }
            else
            {
                if(n == 0)
                {
                    signo = 0;
                }
                else
                {
                    //if(n < 0)
                    //{
                        signo = -1;
                    //}
                }                                
            }

            return signo;
        }

        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Si es menor que cero te muestro un - 1, si es cero te muestro un 0, y si es positivo te muestro +1");
            Console.WriteLine();
            Console.Write("Escribe un nº: ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(Signo(n));
            Console.ReadKey();
        }
    }
}
