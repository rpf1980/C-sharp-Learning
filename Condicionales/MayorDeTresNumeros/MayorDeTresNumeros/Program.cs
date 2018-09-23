using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorDeTresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            short a, b, c;

            // Preguntamos
            Console.WriteLine("Dime el primer número");
            a = short.Parse(Console.ReadLine());
            Console.WriteLine("Dime el segundo");
            b = short.Parse(Console.ReadLine());
            Console.WriteLine("Dime el tercer número");
            c = short.Parse(Console.ReadLine());

            // Condicion
            if (( a >= b) && ( a >= c))
            {
                Console.WriteLine("El mayor es " + a);
            }
            else
                if (( b >= a) && ( b >= c))
            {
                Console.WriteLine("El mayor es " + b);
            }
            else
            {
                Console.WriteLine("El mayor es " + c);
            }
            Console.ReadKey();
            {


            }
                

            }
        }
    }

