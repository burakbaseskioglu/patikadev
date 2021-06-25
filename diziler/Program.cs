using System;

namespace diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[5];
            string[] hayvanlar = { "Kedi", "Köpek", "Kuş", "Maymun" };

            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;

            Console.WriteLine(hayvanlar[0]);
            Console.WriteLine(dizi[3]);
            Console.WriteLine(renkler[0]);

            //Döngülerle dizi kullanımı

            // Console.Write("Lütfen dizinin eleman sayısını giriniz:");
            // int boyut = int.Parse(Console.ReadLine());
            // int[] sayilar = new int[boyut];
            // int toplam = 0;
            // for (int i = 0; i < sayilar.Length; i++)
            // {
            //     Console.WriteLine("{0}. sayıyı giriniz:", i + 1);
            //     sayilar[i] = int.Parse(Console.ReadLine());
            //     toplam = toplam + sayilar[i];
            // }

            // Console.WriteLine("Ortalama = {0}", toplam / boyut);

            Console.Write("Lütfen dizinin eleman sayısını giriniz:");
            int boyut = int.Parse(Console.ReadLine());
            int[] sayilar = new int[boyut];
            int toplam = 0;
            for (int i = 0; i < sayilar.Length; i++)
            {
                Console.Write("{0}. sayıyı giriniz:", i + 1);
                sayilar[i] = int.Parse(Console.ReadLine());
            }

            foreach (var sayi in sayilar)
            {
                toplam = toplam + sayi;
            }
            Console.WriteLine("Ortalama = {0}", toplam / boyut);
        }
    }
}
