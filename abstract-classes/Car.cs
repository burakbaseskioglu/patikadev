namespace abstract_classes
{
    public abstract class Car
    {
        //Bu abstract class'dan kalıtım alan tüm sınıflar TekerlekSayisi() metoduna erişebilecek
        //Yani Civic, Corolla ve Focus sınıflarında bu metodu tek tek yazmaktan kurtuluyoruz.
        public int TekerlekSayisi()
        {
            return 4;
        }
        
        //Default olarak Beyaz rengi tanımlıyoruz ama farklı bir renk kullanmamız gereken durumlarda
        //ise bu metodu ezmeye de imkan vermiş olduk
        public virtual Renk Renk()
        {
            return abstract_classes.Renk.Beyaz;
        }

        public abstract Marka Marka();//abstract metot şeklinde yazarak alt sınıflarımıza bu 
        //metodu implemente etmeye ve gövdesini yazmayı zorlamış oluruz.
    }
}