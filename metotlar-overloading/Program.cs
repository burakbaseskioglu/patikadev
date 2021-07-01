using System;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler:Bir fonksiyona bir iş yaptırıp ve yapılan iş sonucunda bir değerin
            //setlenip ve setlenen değeri kullanmak istiyorsak kullanırız.
            string sayi = "100";

            bool sonuc = int.TryParse(sayi, out int outSayi);//sayi değişkeni çevrilebiliyorsa
            //geriye outSayi değişkeni ile dön.

            //TryParse():Bir sayının dize gösterimini 32 bitlik işaretli tamsayı eşdeğerine 
            //dönüştürür. Dönüş değeri, işlemin başarılı olup olmadığını gösterir.

            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("Başarısız!");
            }

            Metotlar metotlar1 = new Metotlar();
            metotlar1.Topla(2, 3, out int toplamSonuc);
            Console.WriteLine(toplamSonuc);

            //Metotların aşırı yüklenmesi - Overloading

            int ifade = 999;
            metotlar1.EkranaYazdir(Convert.ToString(ifade));
            metotlar1.EkranaYazdir(ifade);
            metotlar1.EkranaYazdir("Burak","Başeskioğlu");


            //Metot imzası
            //metotAdı + parametreSayisi + parametre
        }
    }

    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;//return ifade yerine out parametre ile işlemi yapmış olduk.
        }

        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void EkranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1 + veri2);
        }
    }
}
