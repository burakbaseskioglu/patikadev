using System;
using System.Collections.Generic;

namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> kullanicilar = new Dictionary<int, string>();
            kullanicilar.Add(10, "Ayşe Yılmaz");
            kullanicilar.Add(12, "Ahmet Yılmaz");
            kullanicilar.Add(18, "Deniz Arda");
            kullanicilar.Add(20, "Özcan Coşar");

            //Dizi elemanlarına erişim
            Console.WriteLine("********* Dizi elemanlarına erişim ********");
            Console.WriteLine(kullanicilar[12]);

            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item);
            }

            //Count
            Console.WriteLine("********* Count ********");
            Console.WriteLine(kullanicilar.Count);

            //Contains
            Console.WriteLine("********* Contains ********");
            Console.WriteLine(kullanicilar.ContainsKey(12));
            Console.WriteLine(kullanicilar.ContainsValue("Burak Başeskioğlu"));

            //Remove
            Console.WriteLine("********* Remove ********");
            kullanicilar.Remove(12);
            foreach (var item in kullanicilar)
            {
                Console.WriteLine(item.Value);
            }

            //Keys
            Console.WriteLine("********* Keys ********");
            foreach (var item in kullanicilar.Keys)
            {
                Console.WriteLine(item);
            }
            
            //Values
            Console.WriteLine("********* Values ********");
            foreach (var item in kullanicilar.Values)
            {
                Console.WriteLine(item);
            }
        }
    }
}
