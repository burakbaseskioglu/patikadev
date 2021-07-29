using System;

namespace abstract_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.Marka());
            Console.WriteLine(focus.Renk());
            Console.WriteLine(focus.TekerlekSayisi());

            Console.WriteLine("**********");

            Civic civic = new Civic();
            Console.WriteLine(civic.Marka());
            Console.WriteLine(civic.Renk());
            Console.WriteLine(civic.TekerlekSayisi());

            Console.WriteLine("**********");

            Corolla corolla = new Corolla();
            Console.WriteLine(corolla.Marka());
            Console.WriteLine(corolla.Renk());
            Console.WriteLine(corolla.TekerlekSayisi());
        }
    }
}
