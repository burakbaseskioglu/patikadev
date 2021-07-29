namespace abstract_classes
{
    public class Corolla : Car
    {
        public override Marka Marka()
        {
            return abstract_classes.Marka.Toyota;
        }
    }
}