using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones3  /* Escribe una función “TablaMultiplicar” a la que le pases un entero y nos escriba la 
                    tabla de multiplicar de ese número. */
{
    class Program
    {
        /// <summary>
        /// Muestra la tabla de multiplicar del nº entero que se escriba en consola.
        /// </summary>
        /// <param name="numero">Valor que introduce el usuario</param>
        static void TablaMultiplicar(int numero)
        {   //Función de tipo void...no regresa valor, solo realiza instrucciones         
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", numero, i, (numero * i));
                
            }
            
        }
    
        static void Main(string[] args)
        {
            //Variable para almacenar nº que escriba usuario
            int numero = 0;
            Console.Write("Escriba un nº para mostrarle por consola su tabla de multiplicar: ");
            numero = int.Parse(Console.ReadLine());            
            TablaMultiplicar(numero); //Llama la función y asigna su parámetro
            Console.ReadKey();

        }



    }
    
}
