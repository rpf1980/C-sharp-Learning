using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace condicional_carnet_bebida
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            string carnet, bebida;

            // Preguntamos
            Console.WriteLine("Tienes carnet?? (s/n)");
            carnet = Console.ReadLine();
            Console.WriteLine("Has bebido?? (s/n)");
            bebida = Console.ReadLine();

            // Condición
            if(( carnet == "s" ) && ( bebida == "n"))
            {

                Console.WriteLine("Puedes conducir");

            }
            else
            {
                Console.WriteLine("No puedes conducir");

            }
            Console.ReadKey();

           
            
        }
    }
}
