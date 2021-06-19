using System;

namespace tip_donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implicit Conversion(Bilinçsiz Dönüşüm)
            System.Console.WriteLine("********** Implicit Conversion **********");
            byte a = 5;
            sbyte b = 30;
            short c = 10;

            int d = a + b + c;
            System.Console.WriteLine($"d: {d}");

            long h = d;
            System.Console.WriteLine($"h: {h}");

            float i = h;
            System.Console.WriteLine($"i: {i}");


            string e = "Burak ";
            char f = 'b';
            object g = e + f + d;
            System.Console.WriteLine($"g: {g}");

            //Explicit Conversion(Bilinçli Dönüşüm)
            System.Console.WriteLine("********** Explicit Conversion **********");

            int x = 4;
            byte y = (byte)x;
            System.Console.WriteLine($"y: {y}");

            float w = 12.2f;
            byte v = (byte)w;
            System.Console.WriteLine($"v: {v}");

            //ToString() Metodu
            System.Console.WriteLine("********** ToString() Metodu **********");

            string s1 = "10", s2 = "30";
            int sayi1, sayi2;
            int toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);
            toplam = sayi1 + sayi2;
            System.Console.WriteLine($"Toplam : {toplam}");

            //Parse metodu
            System.Console.WriteLine("********** Parse() Metodu **********");
            ParseMethod();
        }

        public static void ParseMethod()
        {
            string metin1 = "20";
            string metin2 = "14,30";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = Double.Parse(metin2);

            System.Console.WriteLine($"rakam1: {rakam1}");
            System.Console.WriteLine($"double1: {double1}");
        }
    }
}
