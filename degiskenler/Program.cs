using System;

namespace degiskenler
{
    class Program
    {
        static void Main(string[] args)
        {
            byte b1 = 210;   //1 Byte
            sbyte sb1 = 127; //1 byte

            short s1 = 32767; //2 byte
            ushort us1 = 65535; // 2 byte

            int integer1 = 2147483647; //4 byte
            uint integer2 = 4294967295; //4 byte

            long l1 = 145; //8 byte
            ulong ul1 = 201; //8 byte

            //Reel Sayılar
            float f1 = 4.2f; // 4 byte
            double d1 = 16.4; //8 byte
            decimal de1 = 210.11m; //16 byte

            //string ifadeler
            string str1 = "patika";
            string str2 = ".dev";
            string str3 = str1 + str2;
            System.Console.WriteLine(str3);

            //integer tanımlama
            int int1 = 5;
            int int2 = 9;
            int integer3 = int1 + int2;
            System.Console.WriteLine(integer3);

            //Tür dönüşümleri
            string str20 = "20";
            int int40 = 40;
            string yeniDeger = str20 + int40.ToString();
            System.Console.WriteLine(yeniDeger);

            int int60 = Convert.ToInt32(str20) + int40;
            System.Console.WriteLine(int60);

            //DateTime 
            string datetime1 = DateTime.Now.ToString("dd.MM.yyyy");
            System.Console.WriteLine(datetime1);
            string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
            System.Console.WriteLine(datetime2);
            string hour = DateTime.Now.ToString("HH:mm");
            System.Console.WriteLine(hour);


        }
    }
}
