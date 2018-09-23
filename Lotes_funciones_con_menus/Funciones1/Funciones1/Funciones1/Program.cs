using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones1
{
    class Program
    {
        /// <summary>
        /// Función que dice para o impar ante el nº que ponga el usuario.
        /// </summary>
        /// <param name="numero">Determina parámetro de la función</param>
        /// <returns>Devuelve opción (string)---> par o impar</returns>
        static bool Par(int numero)
        {
            bool pares;
            int i = 2;

            if(numero %i == 0)
            {
                pares = true;
            }
            else
            {
                pares = false;
            }
            return pares;
        }

        /// <summary>
        /// Función que imprime verdadero si el año es bisiesto y viceversa.
        /// </summary>
        /// <param name="anio">Determina el parámetro de la función (año)</param>
        /// <returns>Devuelve Verdadero o Falso según sea bisiesto o no</returns>
        static bool Bisiesto(int anio)
        {
            bool bisiesto;
            if (anio % 4 == 0)
            {
                bisiesto = true;
                Console.WriteLine("Verdadero");
            }
            else
            {
                bisiesto = false;
                Console.WriteLine("Falso");
            }
            return bisiesto;
        }

        /// <summary>
        /// Función que imprime tabla de multiplicar de cualquier nº.
        /// </summary>
        /// <param name="numero">Determina parámetro de la función</param>
        static void TablaMultiplicar(int numero)
        {
            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", numero, i, (numero*i)); 
            }
        }

        /// <summary>
        /// Función que imprime serie de nº's por consola.
        /// </summary>
        /// <param name="a">Determina primer parámetro de la función</param>
        /// <param name="b">Determina segundo parámetro</param>
        static void ImprimeSerie(int a, int b)
        {
            int valores;
            if (a < b)
            {
                for(a = a; a <= b; a++)
                {
                    Console.WriteLine(a);
                    valores = a;
                }
            }
            else
            {
                for(a = a; a >= b; a--)
                {
                    Console.WriteLine(a);
                    valores = a;
                }
            }
        }

        /// <summary>
        /// Función que devuelve -1 para negativo, 1 para positivo, 0 para cero.
        /// </summary>
        /// <param name="numero">Determina el parámetro de la función</param>
        /// <returns>Devuelve signo según opción</returns>
        static int Signo(int numero)
        {
            int signo;
            
            if(numero > 0)
            {
                signo = 1;
            }
            else
            {
                if(numero == 0)
                {
                    signo = 0;
                }
                else
                {
                    signo = -1;
                }
            }
            return signo;
        }

        /// <summary>
        /// Función que devuelve el mayor de entre dos números.
        /// </summary>
        /// <param name="numero1">Determina primer parámetro</param>
        /// <param name="numero2">Determina segundo parámetro</param>
        /// <returns>Devuelve número mayor</returns>
        static int Max(int numero1, int numero2)
        {
            if(numero1 > numero2)
            {
                return numero1;
            }
            else
            {
                return numero2;
            }
        }

        /// <summary>
        /// Función que devuelve menor de dos nº's escritos.
        /// </summary>
        /// <param name="n1">Determina primer parámetro de la función</param>
        /// <param name="n2">Determina segundo parámetro</param>
        /// <returns>Devuelve nº menor</returns>
        static int Min(int n1, int n2)
        {
            if(n1 < n2)
            {
                return n1;
            }
            else
            {
                return n2;
            }
        }

        /// <summary>
        /// Función que calcula MCD de dos nº's
        /// </summary>
        /// <param name="a">Determina el primer parámetro de la función</param>
        /// <param name="b">Determina el segundo parámetro de la función</param>
        /// <returns>Devuelve el cálculo del MCD de los nº</returns>
        static int Mcd(int a, int b)
        {
            int i, mcd;
            i = a;
            while(!(a % i == 0 && b % i == 0))
            {
                i--;
            }
            mcd = i;
            return mcd;
        }

        /// <summary>
        /// Función que calcula MCM de dos números pasados por parámetro.
        /// </summary>
        /// <param name="a">Determina el primer parámetro</param>
        /// <param name="b">Determina el segundo parámetro</param>
        /// <returns>Devuelve cálculo del MCM de los nº's</returns>
        static int Mcm(int a, int b)
        {
            int i, mcm;
            i = a;
            while(!(i %a == 0 && i %b == 0))
            {
                i++;
            }
            mcm = i;
            return mcm;
        }

        /// <summary>
        /// Función que dice si el nº es o no primo.
        /// </summary>
        /// <param name="numero">Determina parámetro de la función</param>
        /// <returns>Devuelve opción ( es primo ó no primo)</returns>
        static bool Primo(int numero)
        {
            int i, divisores;
            divisores = 0;

            for(i = 1; i <= numero; i++)
            {
                if(numero % i == 0)
                {
                    divisores = divisores + 1;
                }
            }
            if(divisores <= 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("MENU FUNCIONES 1");
            Console.WriteLine("==============");
            Console.WriteLine(" 1- Par");
            Console.WriteLine(" 2- Bisiesto");
            Console.WriteLine(" 3- TablaMultiplicar");
            Console.WriteLine(" 4- ImprimeSerie");
            Console.WriteLine(" 5- Signo");
            Console.WriteLine(" 6- Max");
            Console.WriteLine(" 7- Min");
            Console.WriteLine(" 8- Mcd");
            Console.WriteLine(" 9- Mcm");
            Console.WriteLine(" 10- Primo");
            Console.WriteLine();
            Console.Write("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();
           
            switch (opcion)
            {
                case 1:
                    {
                        int numero;

                        Console.WriteLine("Escribe un número y te diré si es par o no: ");
                        numero = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        if (Par(numero))
                        {
                            Console.WriteLine("Es par");
                        }
                        else
                        {
                            Console.WriteLine("Es impar");
                        }
                    }
                    break;

                case 2:
                    {
                        int anio;
                        Console.WriteLine("Escribe el año para decirte si es bisiesto: ");
                        anio = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Bisiesto(anio);
                    }
                    break;

                case 3:
                    {
                        int numero = 0;
                        Console.WriteLine("Escriba un nº para mostrarle por consola su tabla de multiplicar: ");
                        numero = int.Parse(Console.ReadLine());
                        TablaMultiplicar(numero);
                    }
                    break;

                case 4:
                    {
                        int a, b;
                        Console.WriteLine("Escribe un nº: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe otro: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        ImprimeSerie(a, b);
                        
                    }
                    break;
                case 5:
                    {
                        int n;
                        Console.WriteLine("Si es menor que cero te muestro un -1, si es cero te muestro un 0, y si es positivo te muestro 1.");
                        Console.WriteLine();
                        Console.WriteLine("Escribe un nº: ");
                        n = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine(Signo(n));
                        
                    }
                    break;
                case 6:
                    {
                        int num1, num2;
                        Console.WriteLine("Escribe un número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe otro: ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("El mayor de los números escritos es: " + Max(num1, num2));
                    }
                    break;
                case 7:
                    {
                        int num1, num2;
                        Console.WriteLine("Escribe un número: ");
                        num1 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe otro: ");
                        num2 = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        Console.WriteLine("El menor de los números escritos es: " + Min(num1, num2));
                    }
                    break;
                case 8:
                    {
                        int a, b;
                        Console.WriteLine("Escriba el primer nº: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escriba el segundo nº: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El MCD de " + a + " y " + b + " es: " + Mcd(a, b));
                    }
                    break;
                case 9:
                    {
                        int a, b;
                        Console.WriteLine("Escribe un valor entero para el primer nº: ");
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe un valor para el segundo nº: ");
                        b = int.Parse(Console.ReadLine());
                        Console.WriteLine("El m.c.m. de " + a + " y " + b + " es: " + Mcm(a, b));
                    }
                    break;
                case 10:
                    {
                        int numero;
                        Console.WriteLine("Escriba un nº para mostrarle si es o no es primo");
                        numero = int.Parse(Console.ReadLine());

                        if (Primo(numero))
                        {
                            Console.WriteLine("Es primo");
                        }
                        else
                        {
                            Console.WriteLine("No es primo");
                        }
                        break;
                    }

                    default: Console.WriteLine("Ejercicio no válido"); break;
            }
            Console.ReadKey();
        }
    }
}
