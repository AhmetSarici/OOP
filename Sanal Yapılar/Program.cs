// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        #region Name
        //Bir nesne üretilirken compiler esnasında memberlar belirlidir yani bilinmektedir.
        //Sanal yapılar ile bilinen bu yapıların runtime esnasında belirlenmesidir.

        //Sınıf içerisinde bildirilen bir yapının türeyen sınıfta da tekrar bildirilebilir.
        //Bunlar property ya da metod olabilir..
        //Namehiding (isim çakışmasından) farklı olarak atadaki davranışın torunda değiştirilmesidir yeniden yapılandırılması.

        //Bu yapı namehiding durumu oluşmasın diye ezilip/yeniden yazılması/iptal etmek/değiştirmek için kullanılır.
        //İlgili member vitual keywordu ile işaretlenir
        ///     public virtual
        ///     virtual public


        //Virtual olan member ezilmek istenirse override ile işaretlenmelidir.
        //override edilmek zorunda değildir, edilirse ezilmiş olur
        //override edilecekse o memberin virtual ile işaretli olması gerekir.
        //

        ///     public virtual void MyMethod(){}
        ///     public override void MyMethod(){}
        {
            #region Örnek1
            {
                // Terlik t = new();
                // t.Bilgi();
                // Kalem k = new();
                // k.Bilgi();
            }
            #endregion
            #region Örnek2
            {
                // Memeli m = new();
                // m.Konus();
                // Maymun m2 = new();
                // m2.Konus();
                // Inek i = new();
                // i.Konus();
            }
            #endregion
            #region Örnek3
            {
                Ucgen u = new(3, 4);
                System.Console.WriteLine(u.AlanHesapla());
                Dortgen d2 = new(8, 8);
                System.Console.WriteLine(d2.AlanHesapla());
            }
            #endregion

        }



        #endregion        
    }
}


#region Örnek1


class Obje
{
    virtual public void Bilgi()
    {
        System.Console.WriteLine("Ben bir objeyim");
    }
}

class Terlik : Obje
{
    public override void Bilgi() //Override ile işaretlenmezse namehiding olur.
    {
        System.Console.WriteLine("Ben bir terliğim");
    }
}

class Kalem : Obje
{
    public override void Bilgi() //Override ile işaretlenmezse namehiding olur.
    {
        System.Console.WriteLine("Ben bir kalemim");
    }

}
#endregion


#region Örnek2

class Memeli
{
    virtual public void Konus()
    {
        System.Console.WriteLine("Ben konuşmuyorum");
    }
}
class Maymun : Memeli
{
    override public void Konus()
    {
        System.Console.WriteLine("Ben bir maymunum");
    }
}

class Inek : Memeli
{
    override public void Konus()
    {
        System.Console.WriteLine("Ben bir ineğim");
    }
}

#endregion


#region Örnek3
class Sekil
{
    protected int _boy;
    protected int _en;
    public Sekil(int boy, int en)
    {
        _boy = boy;
        _en = en;
    }
    virtual public int AlanHesapla()
    {
        return 0;
    }
}
class Ucgen : Sekil
{
    public Ucgen(int boy, int en) : base(boy, en)
    {

    }
    override public int AlanHesapla()
    {
        return _boy * _en / 2;
    }
}
class Dortgen : Sekil
{
    public Dortgen(int boy, int en) : base(boy, en)
    {

    }
    override public int AlanHesapla()
    {
        return _boy * _en;
    }
}
class Dikdortgen : Sekil
{
    public Dikdortgen(int boy, int en) : base(boy, en)
    {

    }
    override public int AlanHesapla()
    {
        return _boy * _en;
    }
}

#endregion
