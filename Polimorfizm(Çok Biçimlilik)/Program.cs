// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        //Polimorfizm iki veya daha fazla nesnenin aynı tür classlardan referans almasıdır.
        //Polimorfizm heapte oluşturulan nesnenin farklı türde işaretçi ile refarans edilmesidir.

        ///     class B:A{}

        ///     A a=new A();
        ///     B b=new A();

        //O nesnenin birden fazla türün davranışını sergilemesine imkan verir.
        //Polimorfizm aralarında kalıtımsal ilişki olan sınıflar arasında uygulanabilir.
        ///     **Ata torunu işaret edebilir.

        //"Hilmi" değerinin Strign'e de object'e de atanabiliyor olması
        //byte değerinin int değerine atanabiliyor olması (bilinçsiz dönüşüm)
        #region Polimorfizm-1
        Kus t = new Tavuk();
        System.Console.WriteLine("___________");
        A a = new B();

        System.Console.WriteLine("___________");
        B b = new B();

        System.Console.WriteLine("___________");
        C c = new B();

        #endregion
    }
}
class Kus
{

    public Kus()
    {
        System.Console.WriteLine("Benim kanatlarım var");
    }
}
class Tavuk : Kus
{
    public Tavuk()
    {
        System.Console.WriteLine("Benim kanatlarım var ama uçamam");
    }
}

class A : C
{
    public A()
    {
        System.Console.WriteLine("A'nın ürünü");
    }
}
class B : A
{
    public B()
    {
        System.Console.WriteLine("B'nın ürünü");
    }
}
class C
{
    public C()
    {
        System.Console.WriteLine("C'nın ürünü");
    }
}