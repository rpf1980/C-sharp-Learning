using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc_3_sentenciasCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double valor, resultado;
            string moneda;


            // Preguntamos dato
            Console.WriteLine("Qué moneda quieres convertir Euros/Pts");
            moneda = (Console.ReadLine());

            Console.WriteLine("Qué valor tiene");
            valor = double.Parse(Console.ReadLine());

            // Condición
            if ( moneda == "Euros" )
            {
                resultado = (valor * 166.386);
                resultado = Math.Round(resultado, 0);
                Console.WriteLine("El valor de " + moneda + " euros es " + resultado + " pts");
            }
            else
            {
                if ( moneda == "Pts")
                {
                    resultado = (valor / 166.386);
                    resultado = Math.Round(resultado, 2);
                    Console.WriteLine("El valor de " + moneda + " pts es " + resultado + " euros");
                }
                else
                {
                    Console.WriteLine("Moneda inválida");
                }
            }
            Console.ReadKey();





        }
    }
}
