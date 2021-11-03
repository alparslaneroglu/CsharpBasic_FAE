using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic101_SayiTahminOyunu
{
    class Program
    {
        static void Main()
        {
            do
            {
                Random rnd = new Random();
                int rastgele = rnd.Next(1, 100), tahmin = 0, sayac = 0;
                Console.WriteLine("1-100 arasında bir sayı tahmin edin..");

                do
                {
                    try
                    {
                        sayac++;
                        tahmin = int.Parse(Console.ReadLine());
                        if (tahmin < 1 || tahmin > 99)
                        {
                            throw new ArgumentException("Lütfen 1-100 arasında giriş yapınız..");
                        }
                        if (rastgele < tahmin)
                        {
                            Console.WriteLine("Aşağı");
                        }
                        else if (rastgele > tahmin)
                        {
                            Console.WriteLine("Yukarı");
                        }
                        else
                        {
                            Console.WriteLine("Tebrikler " + sayac + ".denemede bildiniz");
                            break;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);

                    }
                } while (true);

                Console.WriteLine("Tekrar Oynamak İçin 'P ' basınız.");
                string cevap = Console.ReadLine();
                if (cevap != null && cevap.ToLower() != "p") break; // break çalışması için döngüde olması lazım.Yoksa herhangi bir döngüyü kıramaz.
                
            } while (true);



            Console.ReadKey();

        }
    }
}
