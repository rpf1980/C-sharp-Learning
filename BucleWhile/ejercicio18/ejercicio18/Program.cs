using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Lee números hasta que el usuario escriba < 0

            // Varibles n para numeros que pide, promedio para el cálculo, i para el contador de vueltas bucle

            int n, promedio, suma, cont;

            suma = 0;
            cont = 0;

            // Usuario inserta valores

            Console.Write("Introduce números enteros positivos: ");
            n = int.Parse(Console.ReadLine());

            // Condiciones
            // Si los números son pares

            while(n >= 0)
            {
                suma = suma + n;
                cont = cont + 1;

                Console.Write("Introduce números enteros positivos: ");
                n = int.Parse(Console.ReadLine());
            }
            promedio = suma / cont;
            Console.Write("El promedio de los números introducidos es: " + promedio);
            Console.ReadKey();

                   

        }
    }
}
