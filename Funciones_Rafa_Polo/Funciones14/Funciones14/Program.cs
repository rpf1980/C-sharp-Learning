using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones14  /* Escribe una función “LeeNatural” que nos lea un número natural desde el teclado. La 
                    función nos pondrá un texto en el que se nos indica que introduzcamos un número y 
                    después nos leerá el número del teclado. Si el número introducido es 0 o negativo, nos 
                    volverá a pedir otro número. */
{
    class Program
    {
        static int LeeNatural()
        {
            int numero;
            Console.WriteLine("Escriba un nº, por favor: ");
            numero = int.Parse(Console.ReadLine());

            while(numero <= 0 )
            {
                Console.WriteLine("Se necesita nº positivo para el ejercicio");
                Console.WriteLine("Escriba un nº, por favor: ");
                numero = int.Parse(Console.ReadLine());

            }
            return numero;
        }

        static void Main(string[] args)
        {
            int numero;
            numero = LeeNatural();
            Console.WriteLine(numero);
            Console.ReadKey();
        }
    }
}
