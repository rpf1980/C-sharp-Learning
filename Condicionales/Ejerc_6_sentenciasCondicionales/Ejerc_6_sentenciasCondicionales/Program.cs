using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejerc_6_sentenciasCondicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            int numero;

            // Pedimos un número
            Console.WriteLine("Dígame un número cualquiera: ");
            numero = int.Parse(Console.ReadLine()); // Sirve para mostrar los dígitos de un número entero

            // Condición
            if (numero > -10 && numero < 10)
            {
                Console.WriteLine("Tiene una cifras");
            }
            else
            {
                if (numero > -100 && numero < 100)
                {
                    Console.WriteLine("Tiene dos cifras");
                }
                else
                {
                    if (numero > -1000 && numero < 1000)
                    {
                        Console.WriteLine("Tiene tres cifras");
                    }
                    else
                    {
                        if (numero > -10000 && numero < 10000)
                        {
                            Console.WriteLine("Tiene cuatro cifras");

                        }
                        else
                        {
                            if (numero > -100000 && numero < 100000)
                            {
                                Console.WriteLine("Tiene 5 cifras");
                            }
                            else
                            {
                                Console.WriteLine("El número queda fuera de rango");
                            }
                        }
                    }
                }

            }

            /*if (numero <= 9 && numero >= -9)
            {
                Console.WriteLine("El número tiene 1 cifra");
            }
            else
            {
                if ((numero <= 99) && (numero >= -99))
                {
                    Console.WriteLine("El número tiene 2 cifras");
                }
                else
                {
                    if (numero <= 999 && numero >= -999)
                    {
                        Console.WriteLine("El número tiene 3 cifras");
                    }
                    else
                    {
                        if (numero <= 9999 && numero >= -9999)
                        {
                            Console.WriteLine("El número tiene 4 cifras");
                        }
                        else
                        {
                            if (numero <= 99999 && numero >= -99999)
                            {
                                Console.WriteLine("El número tiene 5 cifras");
                            }
                            else
                            {
                                Console.WriteLine("El número queda fuera del rango requerido");
                            }
                        }
                    }
                    
                }
               
            }*/
            Console.ReadKey();
        }

    }
}
