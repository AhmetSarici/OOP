// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        #region Name Hiding
        {
            //Aynı memberın atada da yer aldığı durum
            //Derived te yar alan member kullanlır.

            //Eskiden torundaki new operatörü ile kullanılırdı bu zorunluluk kalktı.


            D d1 = new();
            d1.X();
        }
        #endregion

        #region Record
        //Recordlar sadece recordlardan kalıtım alabilir.

        //Classlardan kalıtım alamazlar
        //Bir record birden fazla atadan kalıtım alamaz
        //base ve this keywordleri aynı işlevi yürütür.
        //NameHiding olabilmekte

        #endregion
    }
}

class A
{
    public void X()
    {
        System.Console.WriteLine("A sınıfında oluşturuldu");
    }
}
class B : A
{

}
class C : B
{

}

class D : C
{
    public void X()
    {
        System.Console.WriteLine("D sınıfında oluşturuldu");
    }

    // public new void X()
    // {
    //     System.Console.WriteLine("D sınıfında oluşturuldu");
    // }
}
