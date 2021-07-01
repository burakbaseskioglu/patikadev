﻿using System;

namespace metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //erisim_belirteci geri_donus_tipi metot_adi(parametreListesi/argüman)
            //{
            //komutlar
            //return
            //}

            int a = 2;
            int b = 3;

            //Console.WriteLine(a + b);
            //int sonuc = Topla(a, b);
            //Console.WriteLine(sonuc);

            Metotlar ornek = new Metotlar();
            //ornek.EkranaYazdir(Convert.ToString(sonuc));

            //a ile b değişkeninin değerlerini değil bellekteki karşılıklarını(adreslerini) 
            //veriyoruz. Kopyalar üzerinde çalışmaz, orijinal değişkenlerin adresleri 
            //üzerinde işlem yapar.

            int sonuc2 = ornek.ArttırVeTopla(ref a, ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a + b));
        }

        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }
    }

    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1, ref int deger2)
        {
            deger1 = deger1 + 1;
            deger2 = deger2 + 1;
            return deger1 + deger2;
        }
    }
}