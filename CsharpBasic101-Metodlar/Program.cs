using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic101_Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {

            //static kelimesi sadece console için geçerli.
            //Static int Topla(int sayi1,int sayi2) burada sonucu int istiyoruz diye int  metoda yazıyoruz.Ve return yazmak zorundayız.Return içerisine string bir ifade yazılamaz.Double değer yazılamaz.Çünkü veri tipi olarak int tanımladık.
            
            
            //verilen iki sayıyı toplayan metod

            int toplam = Topla(3, 6);
            Console.WriteLine("Toplama işlemi sonucu =" + toplam);
            int top1 = MetodTest();
            int top2 = MetodTest(23, 23);
            int top3 = MetodTest(23, 23, 23);

            Console.WriteLine("1.Toplama İşlemi sonucu =" + top1);
            Console.WriteLine("2.Toplama İşlemi sonucu =" + top2);
            Console.WriteLine("3.Toplama İşlemi sonucu =" + top3);

            toplam = Topla(2, 3, 4, 2, 1, 2, 1, 2, 1, 3, 2, 2, 3, 1);
            Console.WriteLine("Toplama işlemi sonucu =" + toplam);

            string adSoyad;
            Console.WriteLine(Ad()+" "+SoyAd());

            //Bir kenarı 2 olan karenin alanını hesaplayınız.

           int alan = AlanHesapla(2);
            Console.WriteLine("Karenin alanı ="+" " + alan);

            int kenar1 = 2;
            int kenar2 = 4;
            float r = 5;


            Console.WriteLine("Bir kenarı 2cm olan karenin alanı = "+AlanHesapla(kenar1));
            Console.WriteLine("Bir kenarı 2cm olan diğer kenarı 4cm olan dikdörtgenin alanı = "+AlanHesapla(kenar1,kenar2));
            Console.WriteLine("Çemberin Alanı = "+ AlanHesapla(r));


            Console.ReadKey();
        }

        static int AlanHesapla(int a)
        {
            int alan = a * a;
            
            return alan; // direkt olarak bu scopta return alan*alan; şeklinde de yazılabilir.
        }

        static int AlanHesapla(int a,int b)
        {
            return a * b;
        }
        
        static double AlanHesapla(float r,double pi=Math.PI)
        {
            double rr = Convert.ToDouble(r * r);

            return rr*pi;

        }

        static string Ad()
        {
            string ad = "Alparslan";
            return ad;
        }
        static string SoyAd()
        {
            string Soyad = "Eroğlu";
            return Soyad;
        }


        static void Deneme()
        {



        }
        static int Topla(int sayi1,int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;
            
        }
        
        static int Topla(params int[] sayilar)
        {
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam += sayilar[i];

            }
            return toplam;
            
        }


        //Overload durumu : Bir metoda fazla yük bindirmektir.Metodların parametre sayılarını değiştirerek aynı ısımde tanımlayabiliriz.Yoksa aynı isimde olması mümkün değildir.Hata verir.
        static int MetodTest(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            return toplam;

        }

        static int MetodTest(int sayi1, int sayi2, int sayi3)
        {
            int toplam = sayi1 + sayi2 +sayi3;
            return toplam;

        }   
            
        static int MetodTest()
            
        {
            int toplam = 1 + 2;
            return toplam;
        }
        

       




    }
}
