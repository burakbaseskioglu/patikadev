namespace abstract_classes
{
    public class Focus : Car
    {
        public override Marka Marka()
        {
            return abstract_classes.Marka.Ford;
        }
    }
}