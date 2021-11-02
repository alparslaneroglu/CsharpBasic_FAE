using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpBasic101_MathFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            //sqrt fonksiyonu karekökü alıyor.
            double a = 0.04d;
            int b = 64;
            Console.WriteLine(Math.Sqrt(b));

            //ceiling metodu en yakın büyük tam sayıya yuvarlar.
            Console.WriteLine(Math.Ceiling(2.12));

            //Round Metodu  en yakın Aşağıya yuvarlar.
            Console.WriteLine(Math.Round(2.12));

            //pow fonksiyonu    2 üzeri 4 anlamında üslü hesaplamalar yapıyor.
            Console.WriteLine(Math.Pow(2,4));

            //Abs fonksiyonu   Mutlak değer alma işlemi

            Console.WriteLine(Math.Abs(a));






            Console.ReadKey();
        }
    }
}
