namespace abstract_classes
{
    public class Civic : Car
    {
        public override Marka Marka()
        {
            return abstract_classes.Marka.Honda;
        }

        public override Renk Renk()
        {
            return abstract_classes.Renk.Gri;
        }
    }
}