using System;

namespace Degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            //PascalCase 
            //camelCase

            //isimlendirme kuralları

            // isimler rakam ile başlayalamaz ama içinde rakam bulundurabilir.

            //İsimler özel karakterler barındıramazlar.'@,#,%,^' gibi ancak '_ ' istisnadır.
            //Sistemde tanımlı keywordleri değişken ismi olarak kullanamayız.(new gibi)
            //Aynı namespaces üzerinde tanımlı bir değişken ismini tekrar tanımlayamıyoruz.

            //Yazım stili TAD olarak adlanırılıyor. TAP=> TipAdi Ad=Deger; şeklinde dizayn ediliyor.

            //tamsayi tipleri
            byte dgByte = 255;  //0-255 arası değer alır.
            sbyte dgsByte = 127; //-128 ile 127 arası değer alır.
            short dgShort = 32767; // -32768 ile 32767 arasıdır.
            ushort dgUshort = 65535; // 0 ile 65535 
            int dgIntMax = int.MaxValue;
            int dgIntMin = int.MinValue;
            uint dgUint = uint.MaxValue;
            long dgLongMax = long.MaxValue;
            long dgLongMin = long.MinValue;


            Console.WriteLine("Byte degiskeni: " + dgByte);
            Console.WriteLine("sByte degiskeni: " + dgsByte);

            Console.WriteLine("Int max degiskeni: " + dgIntMax);
            Console.WriteLine("Int min degiskeni: " + dgIntMin);
            Console.WriteLine("Uint max degiskeni: " + dgUint);

            Console.WriteLine("Long max degiskeni: " + dgLongMax);
            Console.WriteLine("Long min degiskeni: " + dgLongMin);


            
        }
    }
}
