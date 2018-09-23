using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _42  /*Juego del número secreto. El ordenador elegirá un número al azar entre 1 y 100. El 
usuario irá introduciendo números por teclado, y el ordenador le irá dando pistas: "mi 
número es mayor" o "mi número es menor", hasta que el usuario acierte. Entonces el 
ordenador le felicitará y le comunicará el número de intentos que necesitó para acertar 
el número secreto.*/
{
    class Program
    {
        static void Main(string[] args)
        {
            int aleatorio = (new Random()).Next(1, 101);
            int numero, contador;

            Console.WriteLine("Prueba con un nº cualquiera: ");
            numero = int.Parse(Console.ReadLine());
            contador = 1;

            while(numero != aleatorio)
            {
                if(numero > aleatorio)
                {
                    Console.WriteLine("Tú nº es mayor que el nº secreto, sigue probando");

                }
                else
                {
                    Console.WriteLine("Tu nº es menor que el nº secreto, sigue jugando");

                }
                numero = int.Parse(Console.ReadLine());
                contador = contador + 1;

            }
            Console.WriteLine("Enhorabuena, has acertado nuestro número");
            Console.WriteLine("Número de intentos: " + contador);
            
            if(contador == 1)
            {
                Console.WriteLine("A la primera...!!! Qué SUERTE !!!");

            }
            else
            {
                if (contador < 15)
                {
                    Console.WriteLine("Bueno..no está mal del todo!!!");

                }
                else
                {
                    Console.WriteLine("Muchos intentos llevas ya, no amigo... vamos a dejar que juegue otro!!!");
                }
            }
            Console.ReadKey();
                
            
           

        }
    }
}
