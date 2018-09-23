using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas_Menu
{
    class Program
    {
        /// <summary>
        /// Función que lee una lista de enteros que escribe el usuario por consola. Se detiene cuando se escribe -1.
        /// </summary>
        /// <param name="l">Determina el parámetro de la función y la lista</param>
        static void LeeLista(List<int> l)
        {
            int valor;
            Console.WriteLine("Introduce valores en la lista. Pararemos cuando escriba -1.");
            valor = Convert.ToInt32(Console.ReadLine());
            while (valor != -1)
            {
                Console.WriteLine("Introduce valor: ");
                l.Add(valor);
                valor = int.Parse(Console.ReadLine());
            }
        }

        /// <summary>
        /// Función que lee un entero por consola y lo muestra en lista.
        /// </summary>
        /// <param name="l">Determina el primer parámetro de la función y la lista.</param>
        /// <param name="n">Determina el segundo parámetro de la función y el entero</param>
        static void LeeListaN(List<int> l, int n)
        {
            int i = 0;
            while(i < n)
            {
                Console.WriteLine("Escribe nº: ");
                l.Add(Convert.ToInt32(Console.ReadLine()));
                i++;
            }           
        }

        /// <summary>
        /// Función que escribe lista por consola.
        /// </summary>
        /// <param name="l">Determina el parámetro de la función y la lista de la misma.</param>
        static void EscribeLista(List<int> l) 
        {
            Console.Write("<");
            int i; 
            for(i = 0; i < l.Count-1; i++)
            {
                Console.Write(l[i] + ", ");
            }
            Console.Write(l[l.Count-1] + ">");            
        }

        /// <summary>
        /// Función que escribe ("bonito") una lista de tipo string.
        /// </summary>
        /// <param name="l">Determina el parámetro de la función y el string de la misma.</param>
        static void EscribeString(List<string> l)
        {
            Console.Write("< ");
            int i; 
            for(i = 0; i < l.Count-1; i++)
            {
                Console.Write(l[i] + ",");
            }
            Console.Write(l[l.Count-1] + " >");
        }

        /// <summary>
        /// Función que escribe lista de tipo char
        /// </summary>
        /// <param name="l">Determina el parámetro de la función y la lista de la misma</param>
        static void EscribeChar(List<char> l)
        {
            Console.Write("<");
            int i;
            for(i = 0; i < l.Count-1; i++)
            {
                Console.Write(l[i]);
            }
            Console.Write(l[l.Count-1] + ">");
        }

        /// <summary>
        /// Función que escribe lista de tipo double
        /// </summary>
        /// <param name="l">Determina el parámetro de la función y la lista de elemetos tipo double</param>
        static void EscribeDouble(List<double> l)
        {
            Console.Write("<");
            for(int i = 0; i < l.Count-1; i++)
            {
                Console.Write(l[i]);
                Console.Write(" - ");
            }
            Console.Write(l[l.Count-1] + ">");
        }

        /// <summary>
        /// Función que elimina los nº's negativos de una lista de enteros.
        /// </summary>
        /// <param name="l">Determina el parámetro de la función y la lista de enteros.</param>
        static void EliminaNegativos(List<int> l)
        {
            int i;
            
            for(i = 0; i < l.Count; i++)
            {
                if(l[i] < 0)
                {
                    l.RemoveAt(i);
                    i--;
                }
            }
        }

        /// <summary>
        /// Función que clasifica números negativos y positivos de una lista.
        /// </summary>
        /// <param name="lista">Determina el primer parámetro de la función y la lista que contiene tanto negativos como positivos</param>
        /// <param name="lneg">Determina el segundo parámetro de la función y la lista de número negativos ordenados</param>
        /// <param name="lpos">Determina el tercer parámetro de la función y la lista de núemros positivos ordenados</param>
        static void ClasificaNumeros(List<int> lista, List<int> lneg, List<int> lpos)
        {
            int i;
            for(i = 0; i < lista.Count; i++)
            {
                if(lista[i] < 0)
                {
                    lneg.Add(lista[i]);                   
                }
                else
                {
                    if(lista[i] >= 0)
                    {
                        lpos.Add(lista[i]);
                    }
                }
            }
            lneg.Sort();
            lpos.Sort();
            //Console.WriteLine(lneg);
            //Console.WriteLine(lpos);
        }

        /// <summary>
        /// Función que elimina los enteros que se repiten de una lista.
        /// </summary>
        /// <param name="lista">Determina el parámetro de la función y la lista de la misma.</param>
        static void EliminaRepetidos(List<int> lista)
        {
            int i;
            List<int> rep = new List<int>();
            for(i = 0; i < lista.Count; i++)
            {
                if (!rep.Contains(lista[i]))
                {
                    rep.Add(lista[i]);
                }
            }
            lista.Clear();
            lista.AddRange(rep);
        }

        /// <summary>
        /// Función que elimina los espacios tanto del principio como del final de una lista de tipo char.
        /// </summary>
        /// <param name="l">Determina el parámetro de la función y la lista tipo char de la misma.</param>
        static void TrimLista(List<char> l)
        {
            while (l[0]== ' ')
            {
                l.RemoveAt(0);
            }
            while(l[l.Count-1] == ' ')
            {
                l.RemoveAt(l.Count - 1);
            }            
        }

        /// <summary>
        /// Función que ordena una lista de enteros.
        /// </summary>
        /// <param name="l">Determina el parámetro de la función y la lista de enteros.</param>
        static void OrdenaListaSeleccion(List<int> l)
        {
            int min;
            List<int> l2 = new List<int>();

            while (l.Count > 0) //Hasta que la lista quede vacía
            {
                min = l.Min(); //Buscamos el elemento mas pequeño de la lista
                l2.Add(min); //Lo vamos metiendo en la nueva
                l.Remove(min); //Y vamos quitando el elemento para que no lo reconozca otra vez como el más pequeño
            }
            
            l.AddRange(l2);
        }

        /// <summary>
        /// Función que ordena alfabéticamente una lista de strings.
        /// </summary>
        /// <param name="l">Determina el parámetro de la función y lista de la misma.</param>
        static void OrdenaListasPalabra(List<string> l)
        {
            string min;
            List<string> l2 = new List<string>();

            while (l.Count > 0)
            {
                min = l.Min();
                l2.Add(min);
                l.Remove(min);
            }
            l.AddRange(l2);
        }

        /// <summary>
        /// Función que devuelve la posición de la palabra más corta de una lista de tipo string.
        /// </summary>
        /// <param name="l">Determina el parámetro de la función y la lista de la misma</param>
        /// <returns>Devuelve posición en la lista de la palabra menor</returns>
        static string PalabraMenor(List<string> l)
        {   
            string min = l[0];
            int i;

            for (i = 1; i < l.Count; i++)
            {
                if(l[i].Length < min.Length)
                {
                    min = l[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Función que ordena las palabras de una lista por tamaño. De menor a mayor.
        /// </summary>
        /// <param name="l">Determina el parámetro de la función y la lista de la misma.</param>
        static void OrdenaListasPalabra2(List<string> l)
        {
            
            List<string> l2 = new List<string>();
            string min;

            while (l.Count > 0)
            {
                min = PalabraMenor(l);
                l2.Add(min);
                l.Remove(min);
            }
            l.AddRange(l2);
        }

        /// <summary>
        /// Función que inserta un array en otro a partir de una posición.
        /// </summary>
        /// <param name="array">Determina el primer parámetro de la función y el primer array.</param>
        /// <param name="pos">Determina el segundo parámetro de la función y el entero que indica la posición de la inserción.</param>
        /// <param name="array2">Determina el tercer parámetro de la función y array que será insertado.</param>
        /// <returns></returns>
        static int[] InsertaArrayEnArrayPro(int[] array, int pos, int[] array2)
        {
            List<int> l = new List<int>();
            List<int> l2 = new List<int>();

            l.AddRange(array);
            l2.AddRange(array2);

            l.InsertRange(pos, l2);
            int[] copia;
            copia = l.ToArray();
            return copia;
        }

        /// <summary>
        /// Función que escribe array de enteros.
        /// </summary>
        /// <param name="array">Determina el parámetro de la función y el array de la misma.</param>
        static void EscribeArray(int[] array)
        {
            Console.Write("[");
            for(int i =0; i < array.Length-1; i++)
            {
                Console.Write(array[i]);
                Console.Write(", ");
            }
            Console.Write(array[array.Length-1] + "]");
        }

        /// <summary>
        /// Función que devuelve 6 números al azar.
        /// </summary>
        /// <returns>Devuelve los 6 enteros en modo aleatorio.</returns>
        static List<int> SorteoBonoloto()
        {
            List<int> resultado = new List<int>();//Creamos lista vacía
            int pos = 0;//Creamos variable para posición
            Random r = new Random();//Variable para aleatorio
            int rand;//Para almacenar el aleatorio

            List<int> bombo = new List<int>();//Lista vacia para añadir los 49 nº del bombo
            for(int i = 1; i <= 49; i++)
            {
                bombo.Add(i);
            }
            for(int j = 1; j <= 6; j++)
            {
                rand = r.Next(pos, bombo.Count);
                resultado.Add(rand);
                bombo.RemoveAt(rand);//Aquí vamos eliminando los números ya elegidos para que el 
            }                        //aleatorio no los vuelva a elegir.
            return resultado;
        }

        /// <summary>
        /// Función que elimina enteros que se repiten en un array.
        /// </summary>
        /// <param name="array">Determina el parámetro de la función</param>
        /// <returns>Devuelve array sin elementos repetidos</returns>
        static int[] EliminaRepetidos(int[] array)
        {
            List<int> l = new List<int>();//Creo una lista vacia para pasar convertir el array en lista
            l.AddRange(array);//Convierto array en lista
            List<int> lcopia = new List<int>();//Creo otra lista para copiar los elementos que no están repetidos.

            int i;
            for(i = 0; i < l.Count; i++)
            {
                if (!lcopia.Contains(l[i]))//Si el array lcopia no tiene elementos en l, que los copie. Por lo tanto, una 
                {                          //vez que sí los tenga ya no los copia.  
                    lcopia.Add(l[i]);
                    l.RemoveAt(l[i]);
                }
            }
            l.Clear();//Borramos la lista para usarla limpia para el volcado final
            l.AddRange(lcopia);//Añadimos todos los elementos sin réplica en la lista que vaciamos antes.

            int[] a;//Creamos array vacío para volcar la lista resultante del ejercicio
            a = lcopia.ToArray(); //Convertimos lista en array.

            return a; //Devolvemos resultado del array. 
        }

        /// <summary>
        /// Función que une dos listas con algoritmo matemático de UNION.
        /// </summary>
        /// <param name="l1">Determina el primer parámetro de la función y la primera lista de elementos</param>
        /// <param name="l2">Determina el segundo parámetro de la función y la segunda lista de elementos</param>
        /// <param name="resultado">Determina el tercer parámetro de la función y la lista que ubica el resultado</param>
        /// <returns>Devuelve lista de elementos unidos</returns>
        static List<int> UnionListas(List<int> l1, List<int> l2)
        {
            List<int> resultado = new List<int>();
            resultado.AddRange(l1);
            resultado.AddRange(l2);
            List<int> vacia = new List<int>();

            int i;
            for(i = 0; i < resultado.Count; i++)
            {
                if (!vacia.Contains(resultado[i]))
                {
                    vacia.Add(resultado[i]);
                }
            }
            return vacia;
                        
        }

        /// <summary>
        /// Función que calcula la intersección entre elementos de tipo enteros de dos listas.
        /// </summary>
        /// <param name="l1">Determina el primer parámetro de la función y la primera lista de enteros.</param>
        /// <param name="l2">Determina el segundo parámetro de la función y la segunda lista de enteros.</param>
        /// <returns>Devuelve lista nueva con el resultado de la intersección.</returns>
        static List<int> InterseccionLista(List<int> l1, List<int> l2)
        {
            List<int> resultado = new List<int>();
            for (int i = 0; i < l1.Count; i++)
            {
                if (l2.Contains(l1[i]))
                {
                    resultado.Add(l1[i]);
                }
            }   
            return resultado;
        }

        /// <summary>
        /// Función que desordena aleatoriamente una lista de elementos tipo enteros
        /// </summary>
        /// <param name="l">Devuelve lista desordenada aleatoriamente.</param>
        static void DesordenLista(List<int> l)
        {
            List<int> copia = new List<int>();
            Random rnd = new Random();
            int pos;
            
            while(l.Count > 0)
            {
                pos = rnd.Next(0, l.Count);
                copia.Add(l[pos]);
                l.RemoveAt(pos);
            }
            l.AddRange(copia);
        }

        /// <summary>
        /// Función que nos devuelve el valor que más se repite de una lista tipo int
        /// </summary>
        /// <param name="l">Determina el parámetro de la función y la lista de enteros</param>
        /// <returns>Devuelve valor que más se repite en la lista</returns>
        static int ModaLista(List<int> l)
        {
            List<int> listaElementos = new List<int>();
            List<int> listaRepeticiones = new List<int>();

            int i, n;

            for (i = 0; i < l.Count; i++)
            {
                n = l[i];

                if (listaElementos.Contains(n))
                {
                    int pos = listaElementos.IndexOf(n);
                    listaRepeticiones[pos] =
                        listaRepeticiones[pos]+1;
                }
                else
                {
                    listaElementos.Add(n);
                    listaRepeticiones.Add(1);
                }
            }

            int mayorRepite = listaRepeticiones.Max();
            mayorRepite = listaRepeticiones.IndexOf(mayorRepite);
            return listaElementos[mayorRepite];
            
        }

        /// <summary>
        /// Función  que eliminará los dos valores más altos y los dos más bajos del la lista y, 
        /// además, devolverá un real que será la suma de los tres valores que quedan.
        /// </summary>
        /// <param name="l">Determina el parámetro de la función y la lista de elementos tipo double</param>
        /// <returns>Devuelve resultado de calculos de tipo double</returns>
        static double PuntuacionesTrampolin(List<double> l)
        {
            List<double> copia = new List<double>();
            copia.AddRange(l);
            double min, max;
            min = copia.Min();
            copia.Remove(min);
            min = copia.Min();
            copia.Remove(min);

            max = copia.Max();
            copia.Remove(max);
            max = copia.Max();
            copia.Remove(max);

            double suma = 0;
            for(int i = 0; i < copia.Count; i++)
            {
                suma = suma + copia[i];
            }
            return suma;
        }

        static void OrdenaRepetidos(List<int> l)//Usar ModaLista
        {
            List<int> copia = new List<int>();   
        }

        static void Main(string[] args)
        {
            Console.WriteLine("==============");
            Console.WriteLine("MENÚ DE LISTAS");
            Console.WriteLine("==============");
            Console.WriteLine("[1] LeeLista");
            Console.WriteLine("[2] LeeListaN");
            Console.WriteLine("[3] EscribeLista");
            Console.WriteLine("[4] EliminaNegativos");
            Console.WriteLine("[5] ClasificaNumeros");
            Console.WriteLine("[6] EliminaRepetidos");
            Console.WriteLine("[7] TrimLista");
            Console.WriteLine("[8] OrdenaListaSeleccion");
            Console.WriteLine("[9] OrdenaListasPalabra");
            Console.WriteLine("[10] OrdenaListasPalabra2");
            Console.WriteLine("[11] InsertaArrayEnArrayPro");
            Console.WriteLine("[12] SorteoBonoloto");
            Console.WriteLine("[13] EliminaRepetidos");
            Console.WriteLine("[14] UnionListas");
            Console.WriteLine("[15] InterserccionListas");
            Console.WriteLine("[16] DesordenaLista");
            Console.WriteLine("[17] ModaLista");
            Console.WriteLine("[18] PuntuacionTrampolin");
            Console.WriteLine("[19] Adicional_1");
            Console.WriteLine();
            Console.Write("Elige una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            switch (opcion)
            {
                case 1:
                    {
                        List<int> lista = new List<int>();
                        LeeLista(lista);
                        Console.WriteLine();
                        EscribeLista(lista);
                    }
                    break;
                case 2:
                    {
                        Console.WriteLine("Cuántos elementos quieres insertar en la lista?");
                        int elementos = Convert.ToInt32(Console.ReadLine());
                        List<int> l = new List<int>();
                        LeeListaN(l,elementos);
                        EscribeLista(l);
                    }
                    break;
                case 3:
                    {
                        List<int> lista = new List<int>() { 1,2,3,45,6,7,8};
                        EscribeLista(lista);
                    }
                    break;
                case 4:
                    {
                        List<int> lista = new List<int>() { -5, -8, 67, 35, -10 };
                        EscribeLista(lista);
                        Console.WriteLine();
                        EliminaNegativos(lista);
                        EscribeLista(lista);

                    }
                    break;
                case 5:
                    {
                        List<int> lista = new List<int>() { 1, 2, 3, 4, 5, -6, -7, -8, -9 };
                        List<int> negativos = new List<int>();
                        List<int> positivos = new List<int>();
                        EscribeLista(lista);
                        Console.WriteLine();
                        ClasificaNumeros(lista, negativos, positivos);
                        Console.WriteLine();
                        Console.Write("Negativos: ");
                        EscribeLista(negativos);
                        Console.WriteLine();
                        Console.Write("Positivos: ");
                        EscribeLista(positivos);
                    }
                    break;
                case 6:
                    {
                        Console.WriteLine("Cuántos números quieres usar ?");
                        int n = Convert.ToInt32(Console.ReadLine());
                        List<int> lista = new List<int>();
                        int i=0;
                        while(i < n)
                        {
                            Console.WriteLine("Escribe números para la lista. No copiaré repetidos: ");
                            lista.Add(int.Parse(Console.ReadLine()));
                            i++;
                        }                                                
                        EscribeLista(lista);
                        Console.WriteLine();
                        EliminaRepetidos(lista);
                        EscribeLista(lista);
                        //List<int> lista = new List<int>() { 1, 1, 3, 4, 5, -6, -6, 12, 12 };
                        
                    }
                    break;
                case 7:
                    {
                        List<char> lista = new List<char>();
                        lista.AddRange("   La casa del árbol    .   ");
                        TrimLista(lista);
                        EscribeChar(lista);
                    }
                    break;
                case 8:
                    {
                        Console.WriteLine("Cuántos números quieres para la lista?");
                        int n = Convert.ToInt32(Console.ReadLine());
                        List<int> l = new List<int>();
                        int i = 0;
                        while (i < n)
                        {
                            Console.WriteLine("Escribe el nº en la posicion: " + i);
                            l.Add(Convert.ToInt32(Console.ReadLine()));
                            i++;
                        }
                        EscribeLista(l);
                        Console.WriteLine();
                        OrdenaListaSeleccion(l);
                        EscribeLista(l);
                    }
                    break;
                case 9:
                    {
                        List<string> l = new List<string>() { "Manzana", "obrero", "montaña", "arbol", "tienda" };
                        OrdenaListasPalabra(l);
                        EscribeString(l);

                    }
                    break;
                case 10:
                    {
                        List<string> lista = new List<string>() { "matematicas", "tu", "mas", "arbol" };
                        EscribeString(lista);
                        OrdenaListasPalabra2(lista);
                        Console.WriteLine();
                        EscribeString(lista);
                    }
                    break;
                case 11:
                    {
                        Console.WriteLine("En qué posición quieres insertar el segundo array ?");
                        int pos = Convert.ToInt32(Console.ReadLine());
                        int[] array = new int[] { 3, 4, 5, 6 };
                        int[] array2 = new int[] { 10, 11, 12, 13 };
                        EscribeArray(InsertaArrayEnArrayPro(array, pos, array2));                        
                    }
                    break;
                case 12:
                    {
                        List<int> resultado = new List<int>();
                        resultado = SorteoBonoloto();
                        EscribeLista(resultado);
                    }
                    break;
                case 13:
                    {
                        int[] a = new int[] { 1, 1, 1, 3, 3, 3, 4, 4, 4, 5, 5, 5 };
                        EscribeArray(a);
                        a = EliminaRepetidos(a);
                        Console.WriteLine();
                        EscribeArray(a);
                    }
                    break;
                case 14:
                    {
                        List<int> uno = new List<int>() { 2, 2, 2, 8, 9, 9, 9};
                        List<int> dos = new List<int>() { 12, 12, 13, 14 };
                        
                        EscribeLista(UnionListas(uno, dos));                        
                    }
                    break;
                case 15:
                    {
                        List<int> l1 = new List<int>() { 1, 2, 3, 4 };
                        List<int> l2 = new List<int>() { 3, 4, 5 };
                        
                        EscribeLista(InterseccionLista(l1, l2));
                        
                    }
                    break;
                case 16:
                    {
                        List<int> l = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                        EscribeLista(l);
                        Console.WriteLine();
                        DesordenLista(l);
                        EscribeLista(l);
                    }
                    break;
                case 17:
                    {
                        List<int> l = new List<int>() { 1, 1, 1, 2, 2, 3, 4 };
                        Console.WriteLine("El número que mas se repite es el: " + ModaLista(l));
                    }
                    break;
                case 18:
                    {
                        List<double> l = new List<double>() { 1.3, 2.2, 3.3, 8.9, 3.3, 8.2, 4.2 };
                        double resultado;
                        EscribeDouble(l);
                        resultado = PuntuacionesTrampolin(l);
                        Console.WriteLine();
                        Console.WriteLine(resultado);
                    }
                    break;
                case 19:
                    {
                        List<int> l = new List<int>() { 1,2,3,4,5,1,1,1,1,2,2,2,3,3,4 };                      
                        OrdenaRepetidos(l);
                        EscribeLista(l);
                      

                    }
                    break;
            }
            Console.ReadKey();

        }
    }
}
