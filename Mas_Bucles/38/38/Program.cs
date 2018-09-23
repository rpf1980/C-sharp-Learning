using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _38 //Escribe un programa que calcule el MCD de 2 números.
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;

                        Console.WriteLine("Escribe un primero número: ");
                        n1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el segundo número: ");
                        n2 = int.Parse(Console.ReadLine());

                        int c = 2;
                        int mcd = 1;

                        while(c <= n1 && c <= n2)
                        {
                            while(n1 %c== 0 && n2 %c== 0)
                            {
                                mcd = mcd * c;
                                n1 = n1 / c;
                                n2 = n2 / c;
                            }
                            c = c + 1;
                        }
                        Console.WriteLine($"El mcd de {n1} y {n2} es: {mcd}");
            Console.ReadKey();                        
        }        
    }
}
