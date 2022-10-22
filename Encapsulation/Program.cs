// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {

        #region Encapsulation
        //Fieldlara erişimi kontrolsüz değişime kapatmak kontrol altına almaktır
        //Metodlarla ve Propertyler ile yapılabilir
        {

            #region Metodla
            MyClass3 m = new();
            m.Aset(15);
            System.Console.WriteLine("Metod ile yapılan kapsülleme ile        " + m.AGet());
            #endregion

            #region Propertyler ile
            MyClass3 m2 = new();
            m2.Yas = 55;
            System.Console.WriteLine("Property ile ile yapılan kapsülleme ile " + m2.Yas);

            #endregion
        }
        #endregion
    }
}
class MyClass3
{
    int a;
    public int AGet()
    {
        return this.a;
    }
    public void Aset(int value)
    {
        this.a = value;
    }

    private int yas;
    public int Yas
    {
        get { return yas; }
        set { yas = value; }
    }

}