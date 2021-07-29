using System;

namespace interfaces_example
{
    public class Civic : ICar
    {
        public Marka Marka()
        {
            return interfaces_example.Marka.Honda;
        }

        public Renk Renk()
        {
            return interfaces_example.Renk.Gri;
        }

        public int TekerlekSayisi()
        {
            return 4;
        }
    }
}