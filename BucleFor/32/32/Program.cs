using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32  // Calcular valor máximo de 10 nº's introducidos por teclado
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int i, numero, maximo;

            // Pedimos número
            Console.WriteLine("Escriba un número: ");
            numero = int.Parse(Console.ReadLine());
            maximo = numero;

            // Acción
            for(i = 1; i < 10; i++)
            {
                Console.WriteLine("Escriba un número: ");
                numero = int.Parse(Console.ReadLine());
            }
            if(maximo < numero)
            {
                maximo = numero;
            }
            Console.WriteLine("El mayor de los diez números es {0}", maximo);
            Console.ReadKey();

            
        }       
    }
}
