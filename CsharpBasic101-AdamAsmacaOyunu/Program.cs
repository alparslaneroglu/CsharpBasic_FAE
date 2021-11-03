using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic101_AdamAsmacaOyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *Önceden tanımlı kelimelerin bulunduğu bir adam asmaca oyunu programlayınız.    
             * 6 HAK üzerinden oynanacak.
             * Puanlandırma sorudaki harfSayisi*100=max olacak şekilde hesaplanacak. Puan her yanlış cevapta %15 azaltılacak.
             * 2Çeşit kullanıcı girişi olacak.
             * 1.si harf harf tahmin 
             * 2.si kelime tahmini
             
            */
            string menu;
            do
             {
                Console.WriteLine("Menu");
                Console.WriteLine("*******************************");
                Console.WriteLine(" 1-: Harf Tahmini \n 2-: Kelime Tahmini \n ");
                Console.WriteLine("*******************************");
                Console.Write("Lütfen Seçiminizi Girini :");
                try
                {
                    int secim = Convert.ToInt32(Console.ReadLine());
                    if (secim == 1)
                    {
                        do
                        {
                            int hak = 6, bilinen = 0;
                            string[] sorular = { "zeytinburnu", "kahramanmaras", "canakkale", "sanliurfa" };
                            Random rnd = new Random();
                            string seciliSoru = sorular[rnd.Next(sorular.Length)];
                            double puan = seciliSoru.Length * 100;
                            char[] ekran = new char[seciliSoru.Length];
                            for (int i = 0; i < seciliSoru.Length; i++)
                            {
                                ekran[i] = '_'; // Ekrana seçili kelimenin harfleri kadar _ koy.

                            }

                            do
                            {
                                foreach (char ee in ekran)
                                {
                                    Console.Write(ee + " ");

                                }
                                string ozet = $"\n --> {seciliSoru.Length} harf. Puan : {puan} . Kalan Hakkiniz : {hak}";

                                Console.WriteLine(ozet);
                                Console.WriteLine("Tahmininizi Giriniz.");
                                string tahmin = Console.ReadLine().ToLower(); // Kullanıcı büyük harfle yazdıysa bizim kelimelerimiz küçük harf olduğu için küçüğe dönüştürür.
                                if (tahmin.Length == 1)
                                {
                                    bool bildiMi = false, girildiMi = false;
                                    for (int k = 0; k < ekran.Length; k++)
                                    {
                                        if (ekran[k] == tahmin[0])
                                        {
                                            girildiMi = true;
                                            break;
                                        }


                                    }
                                    if (!girildiMi)
                                    {
                                        for (int i = 0; i < seciliSoru.Length; i++)
                                        {
                                            if (seciliSoru[i] == tahmin[0])
                                            {
                                                bildiMi = true;
                                                ekran[i] = tahmin[0];
                                                bilinen++;
                                            }
                                        }
                                    }

                                    if (!bildiMi) //bildimi==false ile aynı şeydir. Normalde Default değer true .
                                    {
                                        hak--;
                                        puan *= 0.85;
                                    }


                                }
                                else
                                {
                                    if (tahmin == seciliSoru)   // Tek satır şeklinde yazılabilir. if(tahmin == secilisoru) break; şeklinde yazılabilir.Parantezlere gerek kalmaz.
                                    {
                                        break;
                                    }
                                    hak--;
                                    puan *= 0.85;
                                }
                            } while (hak > 0 && bilinen != seciliSoru.Length);

                            Console.WriteLine(hak > 0 ? "Tebrikler Bildiniz.." : "Bilemedeniz..."); // if kullanımı turnery if kullanımı.
                            Console.WriteLine("Tekrar oynamak icin x e bas..");


                            if (Console.ReadLine().ToLower() != "x")
                            {
                                break;
                            }


                        } while (true);



                    }

                    else if (secim == 2)
                    {
                        Console.WriteLine("Bakım Aşamasında");
                    }
                    else
                    {
                        Console.WriteLine("1 yada 2 arasında bir seçim yapın...");

                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("1 ile 2 arasında bir seçim yapın.");
                }
                Console.WriteLine("Menuye donmek için m 'ye bas..");
                menu = Console.ReadLine();
            } while (menu=="m");
           
            Console.ReadKey();
        }

        }
    }

