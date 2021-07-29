using System;

namespace interfaces_example
{
    public class Focus : ICar
    {
        public Marka Marka()
        {
            return interfaces_example.Marka.Ford;
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