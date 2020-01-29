using System;
using System.Globalization;
using System.Threading;
namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha1, fecha2;
            TimeSpan diferencia;
            Console.WriteLine("Ingrese desde que fecha contar en formato AAAA/MM/DD");
            fecha1 = Convert.ToDateTime(Console.ReadLine()); //Toma la fecha proporcionada por el usuario y la convierte de String a Date
            Console.WriteLine("Ingrese hasta que fecha contar en formato AAAA/MM/DD");
            fecha2 =Convert.ToDateTime(Console.ReadLine());
            diferencia = fecha2-fecha1;                     //Calcula la diferencia entre las dos fechas
            float diferenciaendias = diferencia.Days;       //Toma los días de la diferencia
            float diferenciaensemanas = 0.0f;               
            diferenciaensemanas = diferenciaendias/7;       //Calcula la cantidad de semanas y fracciones decimales de las mismas
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("|         Los días de diferencia son {0}         |",diferenciaendias);
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("|     La diferencia en semanas es {0}    |",diferenciaensemanas);
            Console.WriteLine("-------------------------------------------------");
        }
    }
}
