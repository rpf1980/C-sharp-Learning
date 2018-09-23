using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones10   /* Escribe una función “Primo” que nos devuelva “verdadero” si el número que le 
                        pasamos por parámetro es primo y “falso” en caso contrario. */
{
    class Program
    {
        static bool Primo(int numero)
        {
            int i, divisores;
            divisores = 0;

            for(i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                {
                    divisores = divisores + 1;
                }
            }
            if(divisores <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Escriba un nº para mostrarle si es o no es primo");
            numero = int.Parse(Console.ReadLine());

            if (Primo(numero))
            {
                Console.WriteLine("Es primo");
            }
            else
            {
                Console.WriteLine("No es primo");
            }
            Console.ReadKey();
        }
    }
}
