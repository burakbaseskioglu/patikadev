using System;

namespace donguler_while_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******** while ********");

            //1'den başlayarak console'dan girilen sayıya kadar ortalama hesaplayan program
            int toplam = 0;
            int sayac = 1;
            Console.Write("Sayı giriniz:");
            int sayi = int.Parse(Console.ReadLine());

            while (sayi >= sayac)
            {
                toplam = toplam + sayac;
                sayac++;
            }
            Console.WriteLine(toplam / sayi);

            //'a'dan 'z'ye kadar olan tüm harfleri yazdıran program
            char karakter = 'a';
            while (karakter <= 'z')
            {
                Console.WriteLine(karakter);
                karakter++;
            }

            Console.WriteLine("******** foreach ********");

            string[] arabalar = { "BMW", "Ford", "Toyota", "Nissan" };
            foreach (var araba in arabalar)
            {
                Console.WriteLine(araba);
            }
        }
    }
}
