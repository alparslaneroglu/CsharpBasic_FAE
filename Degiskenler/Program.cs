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
            Console.WriteLine("Int min degviskeni: " + dgIntMin);
            Console.WriteLine("Uint max degiskeni: " + dgUint);

            Console.WriteLine("Long max degiskeni: " + dgLongMax);
            Console.WriteLine("Long min degiskeni: " + dgLongMin);

            //Ondalıklı Tipler

            float dgFloat = 3.14f;
            double dgDouble = 3.14d;
            decimal dgDecimal = 3.14m;
            Console.WriteLine("Float degiskeni : " + dgFloat);
            Console.WriteLine("Float degiskeni : {0} {1}" ,dgFloat,dgShort);

            //Metinsel İfadeler

            char dgChar = 'e';
            string dgString = "Selam";

            // Mantıksal ifade

            bool dgBool = true; // false

            //Tarih Saat İfadeleri

            DateTime suan = DateTime.Now;
            suan = suan.Date;
            suan = suan.ToLocalTime();

            Console.WriteLine(suan);

            object dgObject = dgIntMax;
            object dgObject1 = "dgIntMax";
            object dgObject2 = 3.14f;

            Console.WriteLine(dgObject2);


            var a = 3.14f; // var(Variable) işlemi ile tip değişimini engelleyebiliyoruz. İlk olarak int ise sonra int değer girilmek zorundadır.String ise string olmak zorundadır.Değişkenler esnek değildir.
                           // a = "deneme";   İlk başta int tanımladığımız için burada string tanımlamamız mümkün olmuyor.
            
            Console.WriteLine(a);

            // Tip Dönüşümleri

            //İki çeşit veri tipi var

            //1.Value Type ---Stackte tutulur.  String Object bir value type olarak geçer.
            /*int aa = 55;
            string aaa = aa.ToString();*/ //Örnek
                                          //2.Reference Type ---Stackte ismi tutulur . Heap 'te referenci tutulur.







        }
    }
}
