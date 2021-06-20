using System;

namespace karar_yapilari
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = new DateTime(2021, 6, 20, 12, 30, 30).Hour;

            if (time >= 6 && time < 11)
            {
                Console.WriteLine("Günaydın...");
            }
            else if (time <= 18)
            {
                Console.WriteLine("İyi günler...");
            }
            else
            {
                Console.WriteLine("İyi geceler...");
            }

            string sonuc = time <= 18 ? "İyi günler..." : "İyi geceler...";
            Console.WriteLine(sonuc);

            sonuc = time >= 6 && time < 11 ? "Günaydın" : time <= 18 ? "İyi günler..." : "İyi geceler...";
            Console.WriteLine(sonuc);
        }
    }
}
