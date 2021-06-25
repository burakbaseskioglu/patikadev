using System;

namespace diziler_array_sinifi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array.Sort() metodu: Diziler üzerinde sıralama işlemi yapar. Eğer string bir dizi
            //ise alfabetik olarak sıralama yapar. Eğer sayısal bir dizi ise elemanları küçükten
            //büyüğe doğru sıralar.
            Console.WriteLine("******* Sırasız Dizi *******");

            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            Console.WriteLine("******* Sıralı Dizi *******");

            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            Console.WriteLine("******* Clear Metodu *******");
            //Array.Clear() Metodu:Dizinin belirtilen elemanlarını varsayılan değerine getirir.
            //Örneğin sayısal bir dizi ise '0' olarak ayarlar.

            Array.Clear(sayiDizisi, 2, 2);//sayiDizisi elemanlarını kullanarak 2. index'ten
            //itibaren 2 tane elemanı sıfırlar.
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            Console.WriteLine("******* Reverse Metodu *******");
            //Array.Reverse() Metodu:Dizinin ortasını belirleyerek aynalar gibi düşünebiliriz.
            //Yani dizinin ilk elemanı ile son elemanını yer değiştirir.

            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }


            Console.WriteLine("******* IndexOf Metodu *******");
            //Array.IndexOf() Metodu:Verilen dizinin, verilen elemanının index'ini getirir.
            //Eğer dizi içerisinde elemanı bulamazsa -1 döndürür.

            Console.WriteLine(Array.IndexOf(sayiDizisi, 23));


            Console.WriteLine("******* Resize Metodu *******");
            //Array.Resize() Metodu:Dizileri yeniden boyutlandırmak için kullanılır.
            //Aşağıdaki örnekte 8 elemanlı olan sayiDizisi Resize metodu ile 9 elemanlı bir
            //hale getirildi. Daha sonra 9 elemanına 99 değeri atandı.
            Array.Resize<int>(ref sayiDizisi, 9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
            {
                Console.WriteLine(sayi);
            }

            int[] sayiDizisi2 = { 1, 3, 4, 9, 8, 7 };
            Array.Resize<int>(ref sayiDizisi2, 12);
            sayiDizisi[6] = 10;
            //Bu örnekte başlangıçta 6 elemanlı olan sayiDizisi Resize metodu ile 12 elemanlı hale
            //getirildi. Daha sonra 7. elemanına 10 değeri atandı. Diğer boş olan 
            //indexlerin değeri ise varsayılan olarak 0 atanır.

            int[] sayiDizisi3 = { 1, 3, 4, 9, 8, 7 };
            Array.Resize<int>(ref sayiDizisi3, 3);
            //Bu örnekte başlangıçta 6 elemanlı olan sayiDizisi Resize metodu ile 3 elemanlı hale
            //getirildi. sondaki 3 eleman kırpıldı. Artık dizi şu şekilde: {1,3,4}
        }
    }
}
