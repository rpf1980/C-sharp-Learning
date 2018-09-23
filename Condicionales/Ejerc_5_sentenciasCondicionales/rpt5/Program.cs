using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rpt5 // Si los nº's son consecutivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int x, y, z;

            // Pedimos valores
            Console.Write("Ingrese el primer número: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo, por favor: ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el tercer y último número: ");
            z = int.Parse(Console.ReadLine());

            // Condiciones
            if (z == y + 1 && y == x + 1)
            {
                Console.WriteLine("Los números están ordenados de menor a mayor y son consecutivos");
            }
            else
            {
                if (z == y - 1 && y == x - 1)
                {
                    Console.WriteLine("Los números están ordenados de mayor a menor y son consecutivos");

                }
                else
                {
                    if (x < y && y < z)
                    {
                        Console.WriteLine("Los números están ordenados de menor a mayor pero no son consecutivos");
                    }
                    else
                    {
                        if (x > y && y > z)
                        {
                            Console.WriteLine("Los números están ordenados de mayor a menor pero no son consecutivos");
                        }
                        else
                        {
                            if (x == y && y == z)
                            {
                                Console.WriteLine("Los números son todos iguales");
                            }
                            else
                            {
                                Console.WriteLine("Los números no tienen ningún orden, seguro que hay números iguales");
                            }
                        }
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
