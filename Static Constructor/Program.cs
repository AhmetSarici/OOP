// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {

        //Bir sınıfta ilk tetiklenen fonksiyon static constructor, sonra constructor'dır
        #region Static Contructor
        //Contructor her nesne üretiliken tetiklenen fonksiyondur
        //Static Constructor ilgili sınıftan ilk üretilirken tetiklenen fonksiyondur. 
        //*Static yapılanmalar uygulama bazlı dataların yerleştirildiği yerdir.
        {
            A a = new A();
            System.Console.WriteLine("--------");
            A b = new A();
            //Singleton Design Patternda kullanılabiliyor
            var datebase1 = DateBase.GetInstance;
            var datebase2 = DateBase.GetInstance;

            datebase1.ConnectionString = "abcabcabc";
            var datebase3 = DateBase.GetInstance;
            System.Console.WriteLine("İlk iki nesne ile aynı nesne midir : " + datebase3.ConnectionString);

        }
        #endregion
    }


}

class A
{
    public A()
    {
        System.Console.WriteLine("Contructor Çalışıyor");
    }
    static A()
    {
        //Geri dönüş değeri ve erişim beliyleyicisi olmaz
        //Overloading olmaz sadece 1 tanedir
        //İlla ilk nesne üretilmese bile static bir member'ın yapı da tetikler
        System.Console.WriteLine("Static Constructor Çalışıyor");
    }
}

#region Singleton Design Pattern
//Bir sınıftan uygulama bazında sadece bir nesne oluşturulması için kullanılır


class DateBase
{
    //Sınıf nesnesi tekil hale getirilmek isteniyorsa contructorının private olması gerekir.
    DateBase()
    {

    }
    public string ConnectionString { get; set; }
    static DateBase datebase;//Field
    static public DateBase GetInstance //Property ile kapsülleme
    {
        get
        {
            return datebase;
        }
    }

    static DateBase()
    {
        datebase = new DateBase();
        System.Console.WriteLine("Singleton Nesne Oluşturuldu.");
    }
}
#endregion
