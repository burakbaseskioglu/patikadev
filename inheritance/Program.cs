using System;

namespace inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            TohumluBitkiler tohumluBitki1 = new TohumluBitkiler();
            tohumluBitki1.TohumlaCogalma();

            Console.WriteLine("***************");

            Kuslar marti = new Kuslar();
            marti.Ucmak();
            
        }
    }
}
