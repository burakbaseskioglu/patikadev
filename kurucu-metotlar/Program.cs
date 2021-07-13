using System;

namespace kurucu_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan("Ayşe", "Kara", 23425634, "İnsan Kaynakları");
            calisan1.CalisanBilgileri();

            Console.WriteLine();

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Deniz";
            calisan2.Soyad = "Arda";
            calisan2.No = 255646789;
            calisan2.Departman = "Satın Alma";

            calisan2.CalisanBilgileri();

            Console.WriteLine();

            Calisan calisan3 = new Calisan("Burak", "Başeskioğlu");
            calisan3.CalisanBilgileri();
        }
    }

    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;

        public Calisan()
        {

        }

        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }

        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;
        }

        public void CalisanBilgileri()
        {
            Console.WriteLine($"Çalışanın Adı:{Ad}");
            Console.WriteLine($"Çalışanın Soyadı:{Soyad}");
            Console.WriteLine($"Çalışanın Numarası:{No}");
            Console.WriteLine($"Çalışanın Departmanı:{Departman}");
        }
    }
}
