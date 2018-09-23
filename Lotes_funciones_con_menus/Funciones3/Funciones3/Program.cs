using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones3
{
    class Program
    {
        /// <summary>
        /// Función que calcula los días del mes.
        /// </summary>
        /// <param name="mes">Determina el único parámetro de la función</param>
        /// <returns></returns>
        static int DiasMes(int mes)
        {
            int dia;

            switch (mes)
            {
                case 1: dia = 31;break;
                case 2: dia = 28; break;
                case 3: dia = 31; break;
                case 4: dia = 30; break;
                case 5: dia = 31; break;
                case 6: dia = 30; break;
                case 7: dia = 31; break;
                case 8: dia = 31; break;
                case 9: dia = 30; break;
                case 10: dia = 31; break;
                case 11: dia = 30; break;
                case 12: dia = 31; break;
                default:dia = 0;break;
            }
            return dia;
        }

        /// <summary>
        /// Función que determina si un año es bisiesto.
        /// </summary>
        /// <param name="anno">Determina parámetro de la función</param>
        /// <returns>Devuelve respuesta booleana</returns>
        static bool Bisiesto(int anio)
        {
            bool bisiesto;
            if(anio %4 == 0 && anio %100 != 0 || anio %400 == 0)
            {
                bisiesto = true;
            }
            else
            {
                bisiesto = false;
            }
            return bisiesto;
        }

        /// <summary>
        /// Función que pide al usuario mes y año para devolverle valor del mes. Devuelve valor del mes aún si es bisiesto.
        /// </summary>
        /// <param name="mes">Determina el primer parámetro de la función</param>
        /// <param name="anno">Determina el segundo parámetro de la función</param>
        /// <returns>Devuelve valor del mes, siendo año bisiesto o no</returns>
        static int DiasMes2(int mes, int anio)
        {
            int dias;
            if (Bisiesto(anio) && mes == 2)
            {
                dias = 29;
            }
            else
            {
                dias = DiasMes(mes);
            }
            return dias;
        }

        /// <summary>
        /// Función que calcula los días transcurridos desde primero de año hasta la fecha que se pase por parámetro.
        /// </summary>
        /// <param name="dia">Determina primer parámetro de la función</param>
        /// <param name="mes">Determina segundo parámetro</param>
        /// <param name="anno">Determina tercer parámetro</param>
        /// <returns>Devuelve cantidad de días transcurridos</returns>
        static int DiasTranscurridos(int dia, int mes, int anio)
        {
            int diaHoy = 0;
            int i;

            for(i=1; i<mes; i++)
            {
                diaHoy = diaHoy + DiasMes2(i, anio);
            }
            diaHoy = diaHoy + dia;
            return diaHoy;
        }

        /// <summary>
        /// Función que calcula los días transcurridos desde 1980 hasta la fecha que se pase por parámetro.
        /// </summary>
        /// <param name="dia">Determina primer parámetro</param>
        /// <param name="mes">Determina segundo parámetro</param>
        /// <param name="anio">Determina tercer parámetro</param>
        /// <returns>Devuelve nº de días transcurridos desde 1980</returns>
        static int DiaTranscurridos1980(int dia, int mes, int anio)
        {
            int sumaAnios = 0;
            int i;
            for (i = 1980; i < anio; i++)
            {
                if (Bisiesto(i))
                {
                    sumaAnios = sumaAnios + 366;
                }
                else
                {
                    sumaAnios = sumaAnios + 365;
                }
                
            }
            sumaAnios = sumaAnios + DiasTranscurridos(dia, mes, anio);
            return sumaAnios;


        }

        /// <summary>
        /// Función que compara dos fechas y devuelve resultado de los días que pasaron de una fecha a la otra. 
        /// </summary>
        /// <param name="dias">Determina primer parámetro</param>
        /// <param name="mes">Determina segundo parámetro</param>
        /// <param name="anio">Determina tercer parámetro</param>
        /// <param name="dias2">Determina cuarto parámetro de la función</param>
        /// <param name="mes2">Determina quinto parámetro de la función</param>
        /// <param name="anio2">Determina sexto parámetro</param>
        /// <returns>Devuelve resultado en días que resulta de la resta de las fechas</returns>
        static int DiasEntreFechas(int dia, int mes, int anio, int dias2, int mes2, int anio2)
        {
            int diferencia;
            diferencia = DiaTranscurridos1980(dias2, mes2, anio2) - DiaTranscurridos1980(dia, mes, anio);

            return diferencia;
        }

        /// <summary>
        /// Función que imprime día de la semana que corresponde a la fecha que se pase por parámetro.
        /// </summary>
        /// <param name="dia">Determina primer parámetro</param>
        /// <param name="mes">Determina segundo</param>
        /// <param name="anio">Determina tercero</param>
        /// <returns>Devuelve entero que corresponde a un día de la semana... 1=lunes, 2=martes, 3=miércoles</returns>
        static int DiaSemanaFecha(int dia, int mes, int anio)
        {
            int totalDias;
            totalDias = DiaTranscurridos1980(dia, mes, anio) % 7;

            int diasemana;
            switch (totalDias)
            {
                case 1: diasemana = 2; break;
                case 2: diasemana = 3; break;
                case 3: diasemana = 4; break;
                case 4: diasemana = 5; break;
                case 5: diasemana = 6; break;
                case 6: diasemana = 7; break;
                case 0: diasemana = 1; break;
                default: diasemana = 0; break;
            }
            return diasemana;

        }

        /// <summary>
        /// Función que conversa horas y minutos a segundos.
        /// </summary>
        /// <param name="hora">Determina la variable que almacena el  cálculo de horas a segundos</param>
        /// <param name="minuto">Determina la variable que almacena el cálculo de minutos a segundos</param>
        /// <param name="segundo">Determina parámetro para valores de segundos</param>
        /// <returns>Devuelve resultado de la conversión a segundos</returns>
        static int HorasASegundos(int hora, int minuto, int segundo)
        {
            int suma;
            hora = hora * 3600;
            minuto = minuto * 60;
            suma = hora + minuto + segundo;
            return suma;
        }

        /// <summary>
        /// Función que devuelve formato de hora HH:MM:SS.
        /// </summary>
        /// <param name="hora">Determina parámetro hora</param>
        /// <param name="minuto">Determina parámetro minuto</param>
        /// <param name="segundo">Determina parámetro segundo</param>
        static void EscribeHoraBonita(int hora, int minuto, int segundo)
        {
            if(hora < 10)
            {
                Console.Write("0" + hora + ":");
            }
            else
            {
                Console.Write(hora + ":");
            }
            if(minuto < 10)
            {
                Console.Write("0" + minuto + ":");
            }
            else
            {
                Console.Write(minuto + ":");
            }
            if(segundo < 10)
            {
                Console.Write("0" + segundo);
            }
            else
            {
                Console.WriteLine(segundo);
            }
        }

        /// <summary>
        /// Función que le pasamos por parámetros segundos y nos devuelve formato HH:MM:SS
        /// </summary>
        /// <param name="segundos">Parámetro de la función</param>
        static void EscribeSegundosBonitos(int segundos)
        {
            int hora, minuto, segun;
            hora = segundos / 3600;

            minuto = (segundos % 3600) / 60;
            segun = (segundos % 3600) % 60;

            EscribeHoraBonita(hora, minuto, segun);
        }

        /// <summary>
        /// Función que imprime cuántos segundos caben entre dos horas (horas, minutos, segundos)
        /// </summary>
        /// <param name="hora1">Determina primer parámetro</param>
        /// <param name="minuto1">Determina segundo parámetro</param>
        /// <param name="segundo1">Determina tercer parámetro</param>
        /// <param name="hora2">Determina cuarto parámetro</param>
        /// <param name="minuto2">Determina quinto parámetro</param>
        /// <param name="segundo2">Determina sexto parámetro</param>
        /// <returns>Devuelve resultado en segundos</returns>
        static int SegundosTranscurridos(int hora, int minuto, int segundo, int hora2, int minuto2, int segundo2)
        {
            int resto;
            resto = HorasASegundos(hora2, minuto2, segundo2) - HorasASegundos(hora, minuto, segundo);
            return resto;

        }

        /// <summary>
        /// Función que imprime cuántos segundos han pasado desde 01/01/1980 hasta la fecha actual.
        /// </summary>
        /// <param name="dia">Determina primer parámetro para la función</param>
        /// <param name="mes">Determina segundo parámetro para la función</param>
        /// <param name="anio">Determina tercer parámetro</param>
        /// <param name="hora">Determina cuarto parámetro</param>
        /// <param name="minuto">Determina quinto parámetro</param>
        /// <param name="segundo">Determina parámetro sexto</param>
        /// <returns>Devuelve resultados en formato segundos</returns>
        static int SegundosTranscurridos1980(int dia, int mes, int anio, int hora, int minuto, int segundo)
        {
            //Variables
            int dias = 0;
            int totalhora = 0;
            int totalsegundos = 0;

            //Transformamos los dias en minutos, sumamos minutos y transformamos en segundos.
            totalhora = dias * 24 + hora;
            totalsegundos = HorasASegundos(totalhora, minuto, segundo);

            return totalsegundos;
        }
       
        
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("Menú FUNCIONES 3");
            Console.WriteLine("================");
            Console.WriteLine("Opciones: ");
            Console.WriteLine(" 1- DiasMes");
            Console.WriteLine(" 2- DiasMes2");
            Console.WriteLine(" 3- DiasTranscurridos");
            Console.WriteLine(" 4- DiasTranscurridos1980");
            Console.WriteLine(" 5- DiasEntreFechas");
            Console.WriteLine(" 6- DiaSemanaFecha");
            Console.WriteLine(" 7- HorasAsegundos");
            Console.WriteLine(" 8- EscribeHoraBonita");
            Console.WriteLine(" 9- EscribeSegundosBonitos");
            Console.WriteLine(" 10- SegundosTranscurridos");
            Console.WriteLine(" 11- SegundosTranscurridos1980");
            Console.WriteLine();
            Console.WriteLine("Elige una opción: ");
            opcion = int.Parse(Console.ReadLine());
            Console.Clear();

            switch (opcion)
            {
                case 1:
                    {
                        int mes;
                        Console.WriteLine("Escribe el nº del mes y te diré cuántos días tiene");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("El mes tiene " + DiasMes(mes) + " dias");
                    }
                    break;
                case 2:
                    {
                        int mes, anio;
                        Console.WriteLine("Escribe el nº del mes: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el año: ");
                        anio = int.Parse(Console.ReadLine());
                        Console.WriteLine("El mes " + mes + " tiene " + DiasMes2(mes, anio) + " dias.");
                    }
                    break;
                case 3:
                    {
                        int dia, mes, anio;
                        Console.WriteLine("Introduce el día: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el mes: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el año: ");
                        anio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Los días transcurridos desde principio de año son: " + DiasTranscurridos(dia, mes, anio));
                        
                        
                    }
                    break;
                case 4:
                    {
                        int dia, mes, anio;
                        Console.WriteLine("Introduce el día: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el mes: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Introduce el año: ");
                        anio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Los días transcurridos desde el 1/1/1980 son: " + DiaTranscurridos1980(dia, mes, anio));


                    }
                    break;
                case 5:
                    {
                        int mes, dia, anio, mes2, dia2, anio2;
                        Console.WriteLine("Escribe el día de la primera fecha: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ahora el mes: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Y el año: ");
                        anio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe el día de la segunda fecha: ");
                        dia2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe su mes: ");
                        mes2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe su año: ");
                        anio2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Los días transcurridos entre esas dos fechas son: " + DiasEntreFechas(dia, mes, anio, dia2, mes2, anio2));
                    }
                    break;
                case 6:
                    {
                        int dia, mes, anio;
                        Console.WriteLine("Escribe el día: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe mes: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Y ahora escribe el año: ");
                        anio = int.Parse(Console.ReadLine());
                        Console.WriteLine("El puesto en la semana correspondiente a la fecha es el: " + DiaSemanaFecha(dia, mes, anio));
                    }
                    break;
                case 7:
                    {
                        int h, m, s;
                        Console.Write("Escriba las horas: ");
                        h = int.Parse(Console.ReadLine());
                        Console.Write("Escriba los minutos: ");
                        m = int.Parse(Console.ReadLine());
                        Console.Write("Escriba los segundos: ");
                        s = int.Parse(Console.ReadLine());
                        Console.WriteLine("La conversión a segundos daría como resultado: " + HorasASegundos(h, m, s) + " segundos.");
                    }
                    break;
                case 8:
                    {
                        int hora, minuto, segundo;
                        Console.Write("Hora: ");
                        hora = int.Parse(Console.ReadLine());
                        Console.Write("Minuto: ");
                        minuto = int.Parse(Console.ReadLine());
                        Console.Write("Segundo: ");
                        segundo = int.Parse(Console.ReadLine());
                        EscribeHoraBonita(hora, minuto, segundo);
                    }
                    break;
                case 9:
                    {
                        int segundos;
                        Console.WriteLine("Introduce los segundos: ");
                        segundos = int.Parse(Console.ReadLine());

                        EscribeSegundosBonitos(segundos);
                    }
                    break;
                case 10:
                    {
                        int hora, minuto, segundo, hora2, minuto2, segundo2;
                        Console.WriteLine("Escribe hora: ");
                        hora = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe minuto: ");
                        minuto = int.Parse(Console.ReadLine());
                        Console.WriteLine("Y ahora escribe segundos: ");
                        segundo = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe nueva hora: ");
                        hora2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe nuevos minutos: ");
                        minuto2 = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe nuevos segundos: ");
                        segundo2 = int.Parse(Console.ReadLine());

                        Console.WriteLine("Los segundos transcurridos son " + SegundosTranscurridos(hora, minuto, segundo, hora2, minuto2, segundo2));
                    }
                    break;
                case 11:
                    {
                        int dia, mes, anio, hora, minuto, segundo;
                        Console.WriteLine("Escribe dia: ");
                        dia = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe mes: ");
                        mes = int.Parse(Console.ReadLine());
                        Console.WriteLine("Y ahora escribe años: ");
                        anio = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe horas: ");
                        hora = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe minutos: ");
                        minuto = int.Parse(Console.ReadLine());
                        Console.WriteLine("Escribe segundos: ");
                        segundo = int.Parse(Console.ReadLine());

                        Console.WriteLine("Los segundos transcurridos desde 1980 son: " + SegundosTranscurridos1980(dia, mes, anio, hora, minuto, segundo));

                    }
                    break;
                default: Console.WriteLine("Opción no válida");break;
            }
            Console.ReadKey();


        }
    }
}
