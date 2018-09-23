using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30 // Suma de todos los pares entre 1 y 1000
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variable
            int i, suma;
            i = 0;
            suma = 0;
            // Bucle
            for(i= 2; i<=1000; i = i + 2)
            {
                Console.WriteLine(i);               
                suma = suma + i;            
            }
            Console.WriteLine("La suma de los pares es: " + suma);                        
            Console.ReadKey();
        }
    }
}
