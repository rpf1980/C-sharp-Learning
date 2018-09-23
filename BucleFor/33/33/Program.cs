using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _33  // Generalizamos el ejercicio anterior, calcular el promedio de los dos nº's
{ class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int numero, maximo, minimo, suma, promedio, i;

            // Pedimos nº
            Console.WriteLine("Escribe un numero: ");
            numero = int.Parse(Console.ReadLine());
            maximo = numero;
            minimo = numero;
            suma = 0;
            // Acciones
            for (i = 1; i < 10; i++)
            {
                Console.WriteLine("Escribe un número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > maximo)
                {
                    maximo = numero;
                }

                if (numero < minimo)
                {
                    minimo = numero;
                }

                suma = suma + numero;
            }
            promedio = suma / 10;
            Console.WriteLine("El número mayor es " + maximo + " el menor es " + minimo + " y el promedio es " + promedio);
            Console.ReadKey();
        }
    }
}
