using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BucleWhile_Ejerc_13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Programa que muestra la tabla de multiplicar del número que ingreses

            // Variables
            int i, numero, resultado;
            i = 0;
            resultado = 0;
            Console.Write("Escriba un número para mostrarte por consola su tabla de multiplicar: ");
            numero = int.Parse(Console.ReadLine());
            
            //Bucle
            for(i = 1; i <= 10; i++)
            {
                resultado = numero * i;
                Console.WriteLine(numero + " x " + i + " = " + resultado);
                
            }
            Console.ReadKey();
        }   
    }
}
