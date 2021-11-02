using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic101_DateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime zaman = DateTime.Now;
            Console.WriteLine(zaman);
            Console.WriteLine(zaman.ToShortDateString());
            Console.WriteLine(zaman.ToLongDateString());
            Console.WriteLine(zaman.ToLongTimeString());
            Console.WriteLine(zaman.ToShortTimeString());
            Console.WriteLine(zaman.Hour);
            Console.WriteLine(zaman.Minute);
            Console.WriteLine(zaman.Second);
            Console.WriteLine(zaman.Millisecond);
            
            Console.WriteLine(zaman.Day);
            Console.WriteLine(zaman.Month);
            Console.WriteLine(zaman.Year);


            Console.WriteLine(zaman.AddDays(3));
            Console.WriteLine(zaman.AddDays(-2));
            Console.WriteLine(zaman.AddYears(+2));
            Console.WriteLine(zaman.AddYears(-2));

            Console.WriteLine(zaman.AddMonths(+2));
            Console.WriteLine(zaman.AddMonths(-2));


            Console.WriteLine(zaman.AddHours(+2).ToLongTimeString());
            Console.WriteLine(zaman.AddMinutes(-10).ToLongTimeString());


            Console.WriteLine(DateTime.IsLeapYear(2021)); // Şubatın 29 çektiği zaman true veriyor.
            Console.WriteLine(DateTime.DaysInMonth(2023,6));



            DateTime simdi = new DateTime(2021, 11, 02);
            DateTime KurbanBayrami = new DateTime(2022, 07, 09);

            TimeSpan span = KurbanBayrami.Subtract(simdi);
            Console.WriteLine(span);
            Console.WriteLine($"Bayrama {span.TotalDays} gün var");

            DateTime KursBitis = new DateTime(2022, 03, 11);
            TimeSpan span1 = KursBitis.Subtract(simdi);
            Console.WriteLine(span1);
            Console.WriteLine($"Kursun bitmesine {span1.TotalDays} gün var");
                    
                
            Console.ReadKey();


        }
    }
}
