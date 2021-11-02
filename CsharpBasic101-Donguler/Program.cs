using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic101_Donguler
{
    class Program
    {
        public static int[] sayilar = { 10, 20, 25, 29, 34 };
        public static string[] isimler = { "Oğuz","Kürşat","Burak","Okan","Alparslan" };
        public static int SayiToplami = 0;
        public static int Sayac = 0;
        static void Main(string[] args)
        {
            //while Dongusu
            //DateTime suan = DateTime.Now;
            //int sayac = 0;
            //while (suan.Second<30)
            //{
            //    sayac++;
            //   Console.WriteLine(DateTime.Now);
            //    suan = DateTime.Now;
            //}

            Console.WriteLine("Menu");
            Console.WriteLine("*******************************");
            Console.WriteLine(" 1-: For Dongusu \n 2-: While Dongusu \n 3-: DoWhile Dongusu \n 4-: ForEach Dongusu");
            Console.WriteLine("*******************************");
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

            if (secim==1)
            {
                ForDongusu();
                ToplamYaz();    
            }
            else if (secim==2)
            {
                WhileDongusu();
            }
            else if (secim==3)
            {
                DoWhileDongusu();
                ToplamYaz();
            }
            else if (secim==4)
            {
                ForEachDongusu();
                ToplamYaz();
            }

            Console.WriteLine("Devam Etmek İstiyor musunuz = E/H");
            Console.ReadLine();
        }

        static void ForDongusu()
        {
            for (int i = 0; i < sayilar.Length; i++)
            {
                SayiToplami += sayilar[i]; // SayiToplami = SayiToplami+sayilar[i]; 
                Console.WriteLine((i+1)+".Sayi =" + sayilar[i].ToString());
            }



        }

        static void WhileDongusu()
        {
            while (Sayac < isimler.Length)
            {
                Console.WriteLine(isimler[Sayac]);
                Sayac++;
            }
        }

        static void DoWhileDongusu()
        {
            do
            {
                SayiToplami += sayilar[Sayac];
                Console.WriteLine((Sayac + 1) + ".Sayi =" + sayilar[Sayac]);
                Sayac++;

            } while (Sayac < sayilar.Length);
        }

        static void ToplamYaz()
        {
            Console.WriteLine("*******************************");
            Console.WriteLine("Toplam = " + SayiToplami);
            Console.WriteLine("*******************************");
        }

        static void ForEachDongusu()
        {
            foreach(var sayi in sayilar) //sayilar dizisindekileri tek tek geziyor.
            {
                Console.WriteLine(sayi);
                SayiToplami += sayi;
            }
        }


    }
}
