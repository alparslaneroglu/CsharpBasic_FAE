using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic101_TestMetodlar
{
    class Program
    {

        public static bool kontrol = true;
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("*******************************");
            Console.WriteLine(" 1-: Karenin Alanı \n 2-: Dikdörtgenin Alanı \n 3-: Çemberin Alanı \n");
            Console.WriteLine("*******************************");
        
            do
            {
                Console.Write("Seciminizi Giriniz:");
                int secim = 0;
                try
                {
                    secim = int.Parse(Console.ReadLine());
                    //secim = Convert.ToInt32(Console.ReadLine()); string'i ınt e çeviriyor.


                }
                catch (Exception)
                {
                    Console.Write("Nümerik Bir Deger Giriniz..");
                }
                try
                {

                    switch (secim)
                    {
                        case 1:
                            KareAlanHesapla();
                            break;
                        case 2:
                            DikdörgenAlanHesapla();
                            break;
                        case 3:
                            CemberAlanHesapla();
                            break;


                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Bir sayı giriniz.");
                    
                }
               
                Console.Write("Devam etmek istiyorsaniz 'e' ye basin :");
                string devamMi = "";
                devamMi = Console.ReadLine();
                if (devamMi != "e")
                {
                    Console.WriteLine("Güle güle");
                    kontrol = false;
                    // break;  kontrol=false ile aynı görevi görüyor.While true olmadığını anlayınca döngüyü bitiriyor.
                } 
            } while (kontrol==true);

            
            Console.ReadKey();

        }

        static int KareAlanHesapla()
        {
            Console.WriteLine("Bir sayi giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Karenin Alanı ="+" "+sayi*sayi);
            return sayi*sayi;
            int sec = 0;
          
        }
        static int DikdörgenAlanHesapla()
        {
            Console.WriteLine("Bir sayi giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci sayiyi giriniz:");
            int sayi2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Dikdörtgenin Alanı =" + " " + sayi1 * sayi2);
            return sayi1 * sayi2; 
        }

        static double CemberAlanHesapla()
        {
            double pi = Math.PI;
            Console.WriteLine("Yarı çapı giriniz:");
            int sayi1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Çemberin Alanı =" + " " + sayi1 * (pi * pi));
            return sayi1 * (pi * pi);
        }
    }
}
