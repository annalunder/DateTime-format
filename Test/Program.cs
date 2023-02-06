using Microsoft.VisualBasic;
using System;
using System.Threading;

namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var date1 = DateTime.Now;                            // Ger exakt rätt tid
            var date2 = DateTime.UtcNow;                         // Greenwich time, dvs. UTC-tid
            var date3 = DateTime.Today;                          // Ej bra att använda då den ger tiden 00:00:00

            var date4 = DateTime.Now.AddDays(1);                 // I morgon

            var date5 = DateTime.Now.DayOfWeek;                  // Veckodag

            var date6 = DateTime.Now.DayOfYear;                  // Dag på året

            var date7 = DateTime.Now.ToLongDateString();         // Datum skrivet ut långt
            var date8 = DateTime.Now.ToShortDateString();        // Datum skrivet kort
            var date9 = DateTime.Now.ToShortTimeString();        // Klockslag skrivet kort

            var date10 = DateTime.Now.AddHours(3).ToString();   // 3 h senare

            var date11 = DateTime.Now.AddMinutes(10);           // Tio minuter senare
            var date12 = DateTime.Now.AddDays(-1).ToString();   // Igår

            var date13 = DateTime.DaysInMonth(2023, 2);         // Antal dagar i en specifik månad ett visst år
            var date14 = (date1.ToLongTimeString());            // Samma som nästa
            var date15 = (DateTime.Now.ToLongTimeString());     // ToLongTimeString ger enbart tid utan datum

            Console.WriteLine("Hej Anna! Klockan är nu " + date1);
            Console.WriteLine("-------------------------------------------");

            Console.WriteLine(date2);

            // Console.Clear();

            Console.WriteLine(date3);
            Console.WriteLine(date4);
            Console.WriteLine("Today it is " + date5 + " and it is day " + date6 + " of the year 2023.");
            Console.WriteLine("Idag är det " + date7);

            Console.WriteLine("Datumet skrivet kort: " + date8);
            Console.WriteLine("Tiden skrivet kort: " + date9);

            Console.WriteLine(date10);

            Console.WriteLine("Om tio minuter är klockan " + date11);
            Console.WriteLine("Igår var det " + date12);

            Console.WriteLine("Februari månad har " + date13 + " dagar.");
            Console.WriteLine("Nästa två tillvägagångssätt kommer att ge samma resultat:");
            Console.WriteLine(date14);
            Console.WriteLine(date15);
        }
    }
}