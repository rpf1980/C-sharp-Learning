using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc_8_sentenciasCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Determinar la secuencia Mayor Medio Menor de tres números
            // Variables
            int a, b, c, mayor, menor, medio;

            // Pedimos los valores
            Console.WriteLine("Introduzca el valor para A");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca valor para B");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduzca valor para C");
            c = int.Parse(Console.ReadLine());

            // Condiciones
            if (( a > b) && (b > c))
            {
                Console.WriteLine("El mayor es {0}, el mediano es {1}" + " y el menor es {2}", a, b, c);
            }
            else
            {
                if ((a > c) && (c > b))
                {
                    Console.WriteLine("El mayor es {0}, el mediano es {1}" + " y el menor es {2}", a, c, b);
                }
                else
                {
                    if ((b > a) && (a > c))
                    {
                        Console.WriteLine("El mayor es {0}, el mediano es {1}" + " y el menor es {2}", b, a, c);
                    }
                    else{

                        if ((b > c) && (c > a))
                        {
                            Console.WriteLine("El mayor es {0}, el mediano es {1}" + " y el menor es {2}", b, c, a);
                        }
                        else
                        {
                            if ((c > a) && (a > b))
                            {
                                Console.WriteLine("El mayor es {0}, el mediano es {1}" + " y el menor es {2}", c, a, b);
                            }
                            else
                            {
                                Console.WriteLine("El mayor es {0}, el mediano es {1}" + " y el menor es {2}", c, b, a);
                            }

                        }
                    }
                }
                
            }
            Console.ReadKey();

        } 
          
    }
}
