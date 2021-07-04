using System;

namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken2 = "dersimiz CSharp, Hoşgeldiniz!";
            string degisken3 = "CSharp";

            //Length()
            Console.WriteLine(degisken.Length);

            //ToUpper(), ToLower()
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat(string? str0, string? str1):1. değişken ile 2. değişkeni birleştirir.
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));

            //CompareTo(), Compare()
            //1. değişken, 2. değişkene eşit ise 0 döndürür. 
            //1. değişken, 2. değişkenden daha büyük bir karakter sayısına sahipse 1 döndürür.
            //1. değişken, 2. değişkenden daha az bir karakter sayısına sahipse -1 döndürür.
            Console.WriteLine(degisken.CompareTo(degisken2));

            Console.WriteLine(String.Compare(degisken, degisken2, true));//ignoreCase: true ile
            //büyük-küçük harf duyarsız hale gelir. false ile büyük-küçük harf duyarlıdır.
            Console.WriteLine(String.Compare(degisken, degisken2, false));

            //Contains()
            Console.WriteLine(degisken.Contains(degisken3));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba"));

            //IndexOf(): verilen değeri bulursa bulunduğu indeks değerini verir. Bulamazsa
            //geriye -1 döner.
            Console.WriteLine(degisken.IndexOf("CS"));

            //LastIndexOf()
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert()
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));

            //PadLeft(), PadRight()
            Console.WriteLine(degisken + degisken3.PadLeft(30));
            Console.WriteLine(degisken + degisken3.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken3);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken3);

            //Remove()
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5, 3));
            Console.WriteLine(degisken.Remove(0, 1));

            //Replace()
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split()
            Console.WriteLine(degisken.Split(' ')[1]);

            //SubString()
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));
        }
    }
}
