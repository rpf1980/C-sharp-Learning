using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicacionListas
{
    class Program
    {
        static void EscribeLista(List<int> l)
        {
            int i;
            Console.Write("< ");
            for (i = 0; i < l.Count - 1; i++)
            {
                Console.Write(l[i] + ", ");
            }
            Console.WriteLine(l[l.Count - 1] + " >");
        }

        static void LeeLista(List<int> l)
        {
            int valor;

            Console.WriteLine("Introduzca valores en la lista, escriba -1 para terminar:");
            valor = int.Parse(Console.ReadLine());
            while (valor != -1)
            {
                l.Add(valor);
                valor = int.Parse(Console.ReadLine());
            }
        }

        static void Main(string[] args)
        {
            // -------------- LISTAS --------------

            // Es un tipo de dato dinámico: no tiene tamaño
            // fijo. Por todo lo demás es muy parecido
            // a un array.
            // La lista contiene muchos elementos del mismo
            // tipo (como los arrays), puedes modificar esos
            // elementos (como los arrays), a los elementos
            // se accede mediante un entero que es el índice
            // (igual que un array) y se puede pasar una lista
            // a una función y modificarla dentro (como los
            // arrays).

            // Como se crea una lista
            int[] a; // Definimos a como array de enteros
            a = new int[5]; // Creamos un array de 
                            // 5 elementos en la variable a

            List<int> lista; // Definimos una lista de enteros
            lista = new List<int>(); // Creamos una lista y la
                                 // guardamos en l

            a[0] = 1;
            a[1] = -5;
            a[2] = 5;
            a[3] = 3;
            a[4] = 9;

            // En una lista no podemos meter así los elementos
            //l[0] = 1; NOOOO!
            lista.Add(1); // Añade el 1 al final de la lista
            lista.Add(-5);
            lista.Add(5);
            lista.Add(3);
            lista.Add(9);

            //Escribimos la lista por pantalla
            int i;
            //En listas se usa Count en lugar de Length
            for (i = 0; i < lista.Count; i++)
            {
                Console.WriteLine(lista[i]);
            }

            // Para crear una lista sobre la marcha con
            // un montón de valores
            List<int> lista2 = new List<int>() { 1, 2, 3, 4, 5 };

            // La principal novedad de las listas es que se
            // pueden modificar: se pueden insertar elementos
            // y se pueden borrar elementos.
            lista2.Add(6); // añade un valor al final de la lista
            lista2.Insert(0, 9); // añade un 9 al principio
                             // A Insert le pasamos la 
                             // posición y el elemento
            lista2.Insert(3, -1);// En la pos 3, inserta -1
            lista2.RemoveAt(3); // Elimina el elemento que esté
                            // en la posición 3
            lista2.Remove(9); // Elimina el valor 9. Si hay más
                          // de uno sólo borra el primero.
            lista2.RemoveRange(1, 2); // Elimina desde la pos. 1
                                  // 2 elementos

            // OTRAS FUNCIONES DE LISTAS
            if (lista2.Contains(1)) // Igual que la de cadenas
            { }

            int pos = lista2.IndexOf(9); // igual de la de cadenas
            int max = lista2.Max();
            int min = lista2.Min();
            double avg = lista2.Average();
            int sum = lista2.Sum();

            lista2.Reverse(); // Le da la vuelta a una lista
            lista2.Sort(); // Te ordena una lista
            lista2.Clear(); // Vacía la lista = dejas la lista
                            // con 0 elementos

            // Al contrario que en las cadenas, las funciones
            // modifican directamente la lista, no te devuelve
            // una copia.

            // FUNCIONES AVANZADAS
            // Hacer una copia de una lista
            List<int> lista3 = new List<int>() { 9, 8, 7, 6 };

            // Método 1, al crearla le puedes decir que te ponga 
            // los elementos de otra lista
            List<int> lista4 = new List<int>(lista3);

            // Método 2, una vez creada, se puede usar AddRange
            List<int> lista5 = new List<int>();
            lista5.AddRange(lista3);

            // Estos dos métodos funcionan también para poner los
            // valores de un array dentro de una lista
            int[] array1 = { 5, 6, 7, 8 };

            lista5.AddRange(array1);

            // Para transformar una lista en un array, se usa la
            // función ToArray
            int[] array2 = lista5.ToArray();

            EscribeLista(lista5);

            List<int> lista6 = new List<int>();
            LeeLista(lista6);
            EscribeLista(lista6);

            Console.ReadKey();
        }
    }
}
