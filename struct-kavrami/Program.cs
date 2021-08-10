using System;

namespace struct_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen1 = new Dikdortgen();
            dikdortgen1.kisaKenar = 3;
            dikdortgen1.uzunKenar = 4;
            Console.WriteLine($"Class Alan Hesabı:{dikdortgen1.alanHesapla()}");

            DikdortgenStruct dikdortgenStruct1 = new DikdortgenStruct(3, 4);
            Console.WriteLine($"Struct Alan Hesabı:{dikdortgenStruct1.alanHesapla()}");
        }
    }

    class Dikdortgen
    {
        public int kisaKenar;
        public int uzunKenar;

        public long alanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }

        public Dikdortgen()
        {
            kisaKenar = 3;
            uzunKenar = 4;
        }
    }

    struct DikdortgenStruct
    {
        public int kisaKenar;
        public int uzunKenar;

        public long alanHesapla()
        {
            return this.kisaKenar * this.uzunKenar;
        }

        public DikdortgenStruct(int kisaKenar, int uzunKenar)
        {
            this.kisaKenar = kisaKenar;
            this.uzunKenar = uzunKenar;

            
        }
    }
}
