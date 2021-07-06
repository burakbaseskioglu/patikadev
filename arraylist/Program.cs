using System;
using System.Collections;
using System.Collections.Generic;

namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            // arrayList.Add("Ayşe");
            // arrayList.Add(2);
            // arrayList.Add(true);
            // arrayList.Add('a');

            //İçerisindeki verilere erişme
            //Console.WriteLine(arrayList[0]);

            // foreach (var item in arrayList)
            // {
            //     Console.WriteLine(item);
            // }

            //AddRange()
            Console.WriteLine("******** AddRange() ********");
            //string[] renkler = { "Kırmızı", "Sarı", "Yeşil" };
            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 91, 5 };
            //arrayList.AddRange(renkler);
            arrayList.AddRange(sayilar);

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //Sort()
            Console.WriteLine("******** Sort() ********");
            arrayList.Sort();

            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //BinarySearch()
            Console.WriteLine("******** BinarySearch() ********");
            //BinarySearch'ü kullanabilmek için listeyi önce sıralayıp sonra index'e ulaşabiliriz.
            Console.WriteLine(arrayList.BinarySearch(9));

            //Reverse()
            Console.WriteLine("******** Reverse() ********");
            arrayList.Reverse();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            //Clear()
            Console.WriteLine("******** Reverse() ********");
            arrayList.Clear();
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
