using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Multidimensionales
{
    class Program
    {
        /// <summary>
        /// Este programa escribe bonito el array bidimensional
        /// </summary>
        /// <param name="array">array</param>
        static void EscribeArray3x3(int[,] array)
        {
            int i, j;

            for (i = 0; i < 3; i++)
            {
                Console.Write("| ");
                for (j = 0; j < 3; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine("|");
            }
        }
        /// <summary>
        /// Este programa rellena el array bidimensional del 1 al 9
        /// </summary>
        /// <param name="array">array</param>
        static void Rellena3x3(int[,] array)
        {
            int i, j;
            int cont = 1;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    array[i, j] = cont;
                    cont++;
                }
            }
        }
        /// <summary>
        /// Este programa rellena aleatoriamente el array bidimensional
        /// </summary>
        /// <param name="array">array</param>
        static void RellenaAleatorio3x3(int[,] array)
        {
            int i, j;
            Random r = new Random();
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    array[i, j] = r.Next(1,100);
                }
            }
        }
        /// <summary>
        /// Este programa realiza la suma de todos los elementos que hay en el array bidimensional
        /// </summary>
        /// <param name="array">array</param>
        /// <returns>Nos devuelve un entero con el resultado</returns>
        static int SumaArray3x3(int[,] array)
        {
            int i, j;
            int suma=0;
            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    suma =suma+ array[i, j];
                }
            }
            return suma;
        }
        /// <summary>
        /// Este programa escribe bonito el array multidimensional
        /// </summary>
        /// <param name="array">array</param>
        static void EscribeArrayBi(int[,] array)
        {
            int i, j;
            for (i = 0; i < array.GetLength(0); i++)
            {
                Console.Write("| ");
                for (j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i,j] + " ");
                }
                Console.WriteLine("|");
            }
        }
        /// <summary>
        /// Este programa rellena aleatoriamente el array bidimensional 
        /// </summary>
        /// <param name="array">array</param>
        static void RellenaAleatorioBi(int[,] array)
        {
            int i, j;
            Random r = new Random();
            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(1,11);
                }
            }
        }
        /// <summary>
        /// Este programa rellena el array bidimensional en orden
        /// </summary>
        /// <param name="array">array</param>
        static void RellenaOrdenBi(int[,] array)
        {
            int i, j;
            int cont = 1;
            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    array[i,j]=cont;
                    cont++;
                }
            }
        }
        /// <summary>
        /// Este programa suma todos los elementos que hay en el array bidimensional
        /// </summary>
        /// <param name="array">array</param>
        /// <returns>Nos devuelve un entero con el resultado de la suma</returns>
        static int SumaArrayBi(int[,] array)
        {
            int i, j;
            int suma = 0;
            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    suma = suma + array[i, j];
                }
            }
            return suma;
        }
        /// <summary>
        /// Este programa suma los dos arrays bidimensionales y el resultado lo pone en el tercer array bidimensional en la misma posición
        /// </summary>
        /// <param name="array1">array1</param>
        /// <param name="array2">array2</param>
        /// <param name="arrayresultado">arrayresultado</param>
        static void Suma2ArrayBi(int[,] array1, int[,] array2, int[,] arrayresultado)
        {
            int i, j;
            if ((array1.GetLength(0)==array2.GetLength(0))&&(array1.GetLength(1)==array2.GetLength(1)))
            {
                for (i = 0; i < array1.GetLength(0); i++)
                {
                    for (j = 0; j < array1.GetLength(1); j++)
                    {
                        arrayresultado[i, j] = array1[i, j] + array2[i, j];
                    }
                }
            }
            else
            {
                throw new Exception("Error");
            }
        }
        /// <summary>
        /// Este programa te copia el array1 en el array2
        /// </summary>
        /// <param name="array1">array1</param>
        /// <param name="array2">array2</param>
        static void CopiaArrayBi(int[,] array1, int[,] array2)
        {
            int i, j;
            if ((array1.GetLength(0) == array2.GetLength(0)) && (array1.GetLength(1) == array2.GetLength(1)))
            {
                for (i = 0; i < array1.GetLength(0); i++)
                {
                    for (j = 0; j < array1.GetLength(1); j++)
                    {
                        array2[i, j] = array1[i, j];
                    }
                }
            }
            else
            {
                throw new Exception("Error");
            }
        }
        /// <summary>
        /// Este programa te copia el array1 al array2
        /// </summary>
        /// <param name="array1">array1</param>
        /// <returns>Nos devuelve otro del mismo tamaño y con los mismos datos</returns>
        static int[,] CopiaArrayBiPro(int[,] array1)
        {
            int[,] array2 = new int[array1.GetLength(0), array1.GetLength(1)];
            int i, j;
            for (i = 0; i < array1.GetLength(0); i++)
            {
                for (j = 0; j < array1.GetLength(1); j++)
                {
                    array2[i, j] = array1[i, j];
                }
            }
            return array2;
        }
        static void RellenaArrayAjedrez(int[,] array)
        {
            int i, j;
            int cero = 0;
            for (i = 0; i < array.GetLength(0); i++)
            {
                for (j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = cero;
                    cero = cero + 1;
                    if (cero==2)
                    {
                        cero = 0;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            int opcion, actividad;
            Console.WriteLine("MENU DE ARRAYS MULTIDIMENSIONALES");
            Console.WriteLine("==============");
            Console.WriteLine(" 1- Relación de Ejercicios de Arrays Multidimensionales ");
            Console.WriteLine();
            Console.Write("Elige una opción: ");

            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    {
                        Console.WriteLine(" 1- EscribeArray3x3");
                        Console.WriteLine(" 2- Rellena3x3");
                        Console.WriteLine(" 3- RellenaAleatorio3x3");
                        Console.WriteLine(" 4- SumaArray3x3");
                        Console.WriteLine(" 5- EscribeArrayBi");
                        Console.WriteLine(" 6- RellenaAleatorioBi");
                        Console.WriteLine(" 7- RellenaEnordenBi");
                        Console.WriteLine(" 8- SumaArrayBi");
                        Console.WriteLine(" 9- Suma2ArraysBi");
                        Console.WriteLine(" 10- CopiaArrayBi");
                        Console.WriteLine(" 11- CopiaArrayBiPro");
                        Console.WriteLine(" 12- RellenaArrayAjedrez");
                        Console.WriteLine(" 13- RellenaDiagonal");
                        Console.WriteLine(" 14- RellenaX");
                        Console.WriteLine(" 15- RellenaCuadros");
                        Console.WriteLine();
                        Console.Write("Elige una opción: ");
                        actividad = int.Parse(Console.ReadLine());
                        Console.Clear();
                        switch (actividad)
                        {
                            case 1:
                                {
                                    int[,] array = new int[3, 3];
                                    EscribeArray3x3(array);
                                }
                                break;
                            case 2:
                                {
                                    int[,] array = new int[ 3, 3 ];
                                    Rellena3x3(array);
                                    EscribeArray3x3(array);
                                }
                                break;
                            case 3:
                                {
                                    int[,] array = new int[3, 3];
                                    RellenaAleatorio3x3(array);
                                    EscribeArray3x3(array);
                                }
                                break;
                            case 4:
                                {
                                    int[,] array = new int[3,3];
                                    int suma;
                                    RellenaAleatorio3x3(array);
                                    EscribeArray3x3(array);
                                    suma = SumaArray3x3(array);
                                    Console.WriteLine("El resultado de la suma es: " + suma);
                                }
                                break;
                            case 5:
                                {
                                    int i, j;
                                    Console.WriteLine("¿Cuántos números quieres en la lista?");
                                    i = int.Parse(Console.ReadLine());
                                    Console.WriteLine("¿Cuántos números quieres en la columna?");
                                    j = int.Parse(Console.ReadLine());
                                    int[,] array = new int[i, j];
                                    EscribeArrayBi(array);
                                }
                                break;
                            case 6:
                                {
                                    int i, j;
                                    Console.WriteLine("¿Cuántos números quieres en la lista?");
                                    i = int.Parse(Console.ReadLine());
                                    Console.WriteLine("¿Cuántos números quieres en la columna?");
                                    j = int.Parse(Console.ReadLine());
                                    int[,] array = new int[i, j];
                                    RellenaAleatorioBi(array);
                                    EscribeArrayBi(array);
                                }
                                break;
                            case 7:
                                {
                                    int i, j;
                                    Console.WriteLine("¿Cuántos números quieres en la lista?");
                                    i = int.Parse(Console.ReadLine());
                                    Console.WriteLine("¿Cuántos números quieres en la columna?");
                                    j = int.Parse(Console.ReadLine());
                                    int[,] array = new int[i, j];
                                    RellenaOrdenBi(array);
                                    EscribeArrayBi(array);
                                }
                                break;
                            case 8:
                                {
                                    int i, j, suma=0;
                                    Console.WriteLine("¿Cuántos números quieres en la lista?");
                                    i = int.Parse(Console.ReadLine());
                                    Console.WriteLine("¿Cuántos números quieres en la columna?");
                                    j = int.Parse(Console.ReadLine());
                                    int[,] array = new int[i, j];
                                    RellenaAleatorioBi(array);
                                    EscribeArrayBi(array);
                                    suma = SumaArrayBi(array);
                                    Console.WriteLine("El resultado de la suma es: " + suma);
                                }
                                break;
                            case 9:
                                {
                                    int i, j, i2, j2;
                                    Console.WriteLine("¿Qué tamaño quieres en la lista del primer array bidimensional?");
                                    i = int.Parse(Console.ReadLine());
                                    Console.WriteLine("¿Qué tamaño quieres en la columna del primer array bidimensional??");
                                    j = int.Parse(Console.ReadLine());
                                    Console.WriteLine("¿Qué tamaño quieres en la lista del segundo array bidimensional?");
                                    i2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("¿Qué tamaño quieres en la columna del segundo array bidimensional??");
                                    j2 = int.Parse(Console.ReadLine());
                                    int[,] array1 = new int[i, j];
                                    int[,] array2 = new int[i2, j2];
                                    int[,] arrayresultado=new int[array1.GetLength(0), array1.GetLength(1)];
                                    RellenaAleatorioBi(array1);
                                    EscribeArrayBi(array1);
                                    Console.WriteLine();
                                    RellenaAleatorioBi(array2);
                                    EscribeArrayBi(array2);
                                    Console.WriteLine();
                                    Suma2ArrayBi(array1, array2,arrayresultado);
                                    EscribeArrayBi(arrayresultado);
                                }
                                break;
                            case 10:
                                {
                                    int i, j;
                                    Console.WriteLine("Dime un tamaño para la lista del primer array");
                                    i = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Dime un tamaño para la columna del primer array");
                                    j = int.Parse(Console.ReadLine());
                                    int[,] array1 = new int[i, j];
                                    int[,] array2 = new int[array1.GetLength(0), array1.GetLength(1)];
                                    RellenaAleatorioBi(array1);
                                    Console.WriteLine();
                                    EscribeArrayBi(array1);
                                    Console.WriteLine();
                                    CopiaArrayBi(array1, array2);
                                    Console.WriteLine();
                                    EscribeArrayBi(array2);
                                }
                                break;
                            case 11:
                                {
                                    int i, j;
                                    Console.WriteLine("Dime un tamaño para la lista del primer array");
                                    i = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Dime un tamaño para la columna del primer array");
                                    j = int.Parse(Console.ReadLine());
                                    int[,] array1 = new int[i, j];
                                    int[,] array2;
                                    RellenaAleatorioBi(array1);
                                    Console.WriteLine();
                                    EscribeArrayBi(array1);
                                    Console.WriteLine();
                                    array2 = CopiaArrayBiPro(array1);
                                    Console.WriteLine();
                                    EscribeArrayBi(array2);
                                }
                                break;
                            case 12:
                                {
                                    int[,] array = new int[8,8];
                                    RellenaArrayAjedrez(array);
                                    EscribeArrayBi(array);
                                }
                                break;
                            case 13:
                                {
                                }
                                break;
                            case 14:
                                {
                                }
                                break;
                            case 15:
                                {
                                }
                                break;

                        }
                    }
                    break;

                default: Console.WriteLine("Ejercicio no válido"); break;
            }

            Console.ReadKey();
        }
    }
}