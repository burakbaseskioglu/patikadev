using System;

namespace static_sinif_ve_uyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Çalışan sayısı:{Calisan.CalisanSayisi}");

            Calisan calisan1 = new Calisan("Ayşe", "Yılmaz", "İnsan Kaynakları");

            Console.WriteLine($"Çalışan sayısı:{Calisan.CalisanSayisi}");

            Calisan calisan2 = new Calisan("Deniz", "Arda", "İnsan Kaynakları");

            Console.WriteLine($"Çalışan sayısı:{Calisan.CalisanSayisi}");

            Console.WriteLine(Islemler.Toplam(100, 50));
            Console.WriteLine(Islemler.Cikar(250, 25));
        }
    }

    class Calisan
    {
        private static int calisanSayisi;
        public static int CalisanSayisi { get => calisanSayisi; }
        private string Isim;
        private string Soyisim;
        private string Departman;

        static Calisan()
        {
            calisanSayisi = 0;
        }

        public Calisan(string isim, string soyisim, string departman)
        {
            this.Isim = isim;
            this.Soyisim = soyisim;
            this.Departman = departman;
            calisanSayisi++;
        }
    }

    static class Islemler
    {
        public static int Toplam(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static int Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }
}
