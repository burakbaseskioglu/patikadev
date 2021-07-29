using System;

namespace interfaces_example
{
    public class Corolla : ICar
    {
        public Marka Marka()
        {
            return interfaces_example.Marka.Toyota;
        }

        public Renk Renk()
        {
            return interfaces_example.Renk.Beyaz;
        }

        public int TekerlekSayisi()
        {
            return 4;
        }
    }
}