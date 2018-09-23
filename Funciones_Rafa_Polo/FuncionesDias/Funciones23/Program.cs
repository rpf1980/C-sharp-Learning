using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funciones23  
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
            int totaldias;
            switch (mes)
            {
                case 1: totaldias = 31; break;
                case 2: totaldias = 28; break;
                case 3: totaldias = 31; break;
                case 4: totaldias = 30; break;
                case 5: totaldias = 31; break;
                case 6: totaldias = 30; break;
                case 7: totaldias = 31; break;
                case 8: totaldias = 31; break;
                case 9: totaldias = 30; break;
                case 10: totaldias = 31; break;
                case 11: totaldias = 30; break;
                case 12: totaldias = 31; break;
                default: totaldias = 0; break;

            }
            return totaldias;
        }

        /// <summary>
        /// Función que determina si un año es bisiesto.
        /// </summary>
        /// <param name="anno">Determina parámetro de la función</param>
        /// <returns>Devuelve respuesta booleana</returns>
        static bool Bisiesto(int anno)
        {
            bool bisiesto;

            if (anno % 4 == 0 && anno % 100 != 0 || anno % 400 == 0)
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
        static int DiasMes2(int mes, int anno)
        {
            int dias;
            if (Bisiesto(anno) && mes == 2)
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
        static int DiasTranscurridos(int dia, int mes, int anno)
        {
            int diaHoy = 0;
            int i;

            for(i=1; i<mes; i++)
            {
                diaHoy = diaHoy + DiasMes2(i, anno);
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
        static int DiasTranscurridos1980(int dia, int mes, int anio)  
                                                                
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
        static int DiasEntreFechas(int dias, int mes, int anio, int dias2, int mes2, int anio2)  
                                      
        {
            int suma;
            suma = DiasTranscurridos1980(dias, mes, anio) - DiasTranscurridos1980(dias2, mes2, anio2);

            return suma;

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
            totalDias = DiasTranscurridos1980(dia, mes, anio) % 7;

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
                        
            if (hora < 10)
            {
                Console.Write("0"+ hora + ":");
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
                Console.Write(segundo);
            }
                
            
        }

        /// <summary>
        /// Función que le pasamos por parámetros segundos y nos devuelve formato HH:MM:SS
        /// </summary>
        /// <param name="segundos">Parámetro de la función</param>
        static void EscribeSegundosBonitos(int segundos)
        {
            int hora, restoHora, minuto, segun;
            
            hora = segundos/3600;
            //restoHora = segundos - (hora*3600);
            //restoHora = segundos % 3600;

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
        static int SegundosTranscurridos(int hora1, int minuto1, int segundo1, int hora2, int minuto2, int segundo2)
        {
            int resultado = HorasASegundos(hora1, minuto1, segundo1) - HorasASegundos(hora2, minuto2, segundo2);
            return resultado;
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
            //Variable
            int dias = 0;
            int totalhoras = 0;
            int totalsegundos = 0;

            //Datos
            dias = DiasTranscurridos1980(dia, mes, anio);
            //Tranformaamos los dias en minutos, sumamos minutos y transformamos en segundos.
            totalhoras = dias * 24 + hora;
            totalsegundos = HorasASegundos(totalhoras, minuto, segundo);

            return totalsegundos;
        }

        static void Main()
        {

            //EscribeHoraBonita(2, 4, 2);
            //Console.WriteLine(SegundosTranscurridos(2, 4, 30, 1, 2, 15));

            //int dia = 5;
            //int mes = 1;
            //int anio = 2011;
            //Console.WriteLine(DiasTranscurridos(dia, mes, anio));


            int dia = 1;
            int mes = 8;
            int anio = 2018;
            int dia2 = 22;
            int mes2 = 8;
            int anio2 = 2018;
            Console.WriteLine(DiasEntreFechas(dia, mes, anio, dia2, mes2, anio2));

            Console.ReadKey();

        }
    }
}
