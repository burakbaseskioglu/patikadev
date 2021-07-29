using System;

namespace interfaces_example
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus = new Focus();
            Console.WriteLine(focus.Marka().ToString());
            Console.WriteLine(focus.TekerlekSayisi());
            Console.WriteLine(focus.Renk().ToString());

            Civic civic = new Civic();
            Console.WriteLine(civic.Marka().ToString());
            Console.WriteLine(civic.TekerlekSayisi());
            Console.WriteLine(civic.Renk().ToString());
        }
    }
}
