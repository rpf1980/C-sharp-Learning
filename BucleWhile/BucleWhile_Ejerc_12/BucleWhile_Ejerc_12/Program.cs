using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleWhile_Ejerc_12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Contador para el bucle
            int i;
            i = 0;
            // Variable para opcion del usuario
            string opcion;
            Console.WriteLine("Qué números quieres, PARES / IMPARES");
            opcion = Console.ReadLine();

            // Condiciones
            if (opcion == "PARES")
            {
                while (i <= 10)
                {
                    Console.WriteLine(i);
                    i = i + 2;
                }
            }
            else
            {
                if (opcion == "IMPARES")
                {
                    i = 1;
                    while (i <= 10)
                    {
                        Console.WriteLine(i);
                        i = i + 2;
                    }
                    
                }
                else
                {
                    Console.WriteLine("El texto que has introducido no corresponde exactamente con las dos opciones");
                }
            }



            /*while (opcion == PARES)
            {
                Console.WriteLine("");
                i = i + 2;
                
            }   if (opcion == IMPARES)
            {
                Console.WriteLine("");
                i = (i % 2 == 1);
            }
            else
            {
                Console.WriteLine("Mira a ver si has escrito mal alguna de las opciones a elegir");
            }*/




            Console.ReadKey();
        }
    }
}
