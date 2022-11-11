// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {

        #region Kalıtım
        // OOP 'nin en önemli özelliğidir
        // Farklı sınıf nesnelerine özellik aktrabilme imkanı sağlar
        //Farklı sınıflardaki aynı işlevi yürüten memberların bir üst sınıfta toplayarak alt sınıflara memberların sağlanması.
        //Üst sınıf alt sınıfları kapsayan nitelikte olmalıdır.

        ////**C# 'ta Kalıtım Alabilen Yapılar**//
        //Bir sınıf sınıftan kalıtım alabilir
        //Recordtan recorda, class'tan class'a
        //Record birtek Object sınıfından alabilir*
        //Kalıtım compiler saviyesinde aktarılır


        {
            Muhasebeci muhasebeci = new Muhasebeci();
            Mudur mudur = new Mudur();
            Yazilimci yazilimci = new();
            yazilimci.Adi = "Ali";
            yazilimci.KullandigiDil = "C#";

            System.Console.WriteLine(yazilimci.Adi + " isimli personel " + yazilimci.KullandigiDil + " dilini bilmektedir.");
        }

        #endregion

    }

}


class Araba
{
    public string Marka { get; set; }
    public string Model { get; set; }
    public int KM { get; set; }
}

class Opel : Araba //Opel Araba sınıfından erişilebilir memberları kalıtım olarak almaktadır
{

}

class Muhasebeci : Personel
{
    public bool Musavir { get; set; }
}
class Yazilimci : Personel
{
    public string KullandigiDil { get; set; }
}

class Mudur : Personel
{

}

class Personel
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public bool MedeniHal { get; set; }
}