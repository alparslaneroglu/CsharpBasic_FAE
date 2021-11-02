using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic101_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.DarkYellow;
            //Console.ForegroundColor = ConsoleColor.DarkBlue;
            //Array  -Arraylerin boyutları sonradan değiştirilemez.Eğer 5 olarak tanımladıysak daha fazlası girilemez.

            int[] sayilar = new int[5];
            sayilar[0] = 2;
            sayilar[1] = 10;
            sayilar[2] = 8;
            sayilar[3] = 55;
            sayilar[4] = 23;

            int[] numbers = new int[5] { 3, 5, 9, 43, 28 };

            Console.WriteLine($"Eleman Sayisi :{numbers.Length}");
            Console.WriteLine($"Dizinin Ortalamasi :{numbers.Average()}");
            Console.WriteLine($"Dizinin İlk Elemanı :{numbers.First()}");
            Console.WriteLine($"Dizinin Son Elemanı :{numbers.Last()}");
            Console.WriteLine($"Dizinin En Buyuk Elemanı :{numbers.Max()}");
            Console.WriteLine($"Dizinin En Kucuk :{numbers.Min()}");
            Console.WriteLine($"Dizinin Elamanları Toplamı :{numbers.Sum()}");
            Console.WriteLine($"9 Dizinin Kaçıncı Elemanı  :{Array.IndexOf(numbers,9)}");


            var rnd = new Random();
            


            for (int i = 0; i < 20; i++)
            {
                var rastgeleSayi = rnd.Next(7, 24);
                Console.WriteLine(rastgeleSayi); 
            }


            



            string[] gunler = new string[7];
            gunler[0] = "Pazartesi";
            gunler[1] = "Salı";
            gunler[2] = "Çarşamba";
            gunler[3] = "Perşembe";
            gunler[4] = "Cuma";
            gunler[5] = "Cumartesi";
            gunler[6] = "Pazar";

            //Array.Clear(gunler, 2, 2);
            //Array.Sort(gunler);
            Array.Reverse(gunler); // Mevcut sistemi tersten sıralıyor . Z ->A ' ya sıralamak istersek önce A'dan Z'ye sıralamak gerekir.
            for (int i = 0; i < gunler.Length; i++)
            {
                Console.WriteLine(gunler[i]); 
            }


            char[] array = new char[5];
            array[0] = 's';
            array[1] = 'e';
            array[2] = 'l';
            array[3] = 'a';
            array[4] = 'm';

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }

            Console.WriteLine();
            Array.Resize(ref array, 8);
            array[5] = 'l';
            array[6] = 'a';
            array[7] = 'r';
            // array[8] = '.';  Burada hata veriyor çünkü boyutu aşıyor.Arrayler esnek olmadığı için büyümüyor.

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }





            Console.ReadKey();
            


        }
    }
}
