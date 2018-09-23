using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _29
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int a, b, i;
            i = 1;
            Console.WriteLine("Teclee dos nº's por pantalla y te diré cuántos pares existen entre ellos");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("");
            b = int.Parse(Console.ReadLine());

            // Condiciones
            if (a < b)//Primero si a < b
            {
                
            	//Recorremos desde el menor (a) al mayor (b)
                for (i = a; i <= b; i++)
                {
                    if (i % 2 == 1)//Y buscamos los impares
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            else
            {
                if (a > b)//Segunada condición si a > b
                {
                    for (i = b; i <= a; i = i + 2)//Y esta vez hayamos los impares de otra forma.
                    							  //Lo hacemos desde el bucle
                    {
                        Console.WriteLine("");
                        Console.WriteLine(i);
                    }
                }
                else
                {
                    Console.WriteLine("Los números son iguales");
                }
            }
            Console.ReadKey();








            Console.ReadKey();

        }
    }
}
