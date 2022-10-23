// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        #region Constructor
        {
            //Nesne üretiminde ilk tetiklenen metottur
            // new(), new MyClass()  yer alan "()"
            // ilk değerler buradan atanması mümkündür
            //Özel sınıf elemanıdır

            //*Metot adı sınıf adı ile aynıdır
            //*Yapı olarak metottur
            //*Geri dönüş değeri yoktur
            //*Public olmalıdır.
            new MyClass();
            new MyClass();
            MyClass m1 = new();
        }
        #endregion
        #region Default Constructor
        {
            //Herhangi tanımlanmasa bile var olan default constructor verdır ve çağırıldığında tetiklenir
        }
        #endregion

        #region Paremetreli Constructor
        {
            //
            MyClass2 m2 = new(42);

        }
        #endregion
        #region  Constructor Overload
        {
            //Oveloading olması için aynı isimli metotların farklı türde parametre almasıdır 
            //
            MyClass3 m3 = new();
            MyClass3 m4 = new(152);
            MyClass3 m5 = new("C#");

        }
        #endregion

        #region Özellikler
        //Sınıfın constructorunu private yapılırsa
        //Nesne üretiminde hata alınır



        #region This
        {
            //This keyword'ü ile constructorlar arası geçiş
            //Bir sınıfın içinde yer alan this keyword'ü o anki nesnesini temsil eder.
            //2. constructordan 1. yi de tetikleme

            //This keyword'ünde constructorlara ya da manuel değer verilebilir
            //Farklı bir property ya da field çağırılamaz

            System.Console.WriteLine("------------");
            MyClass4 m6 = new(66);
            System.Console.WriteLine("------------");
            MyClass4 m7 = new(10, 99);
        }
        #endregion


        #endregion

        #region Records Constructor
        {
            //Classlardaki kuraller aynı şekilde geçerlidir.
        }
        #endregion

    }
}


class MyClass
{
    public MyClass()
    {
        System.Console.WriteLine("Bir adet my class nesnesi oluşturulmuştur");
    }
}
class MyClass2
{
    public MyClass2(int a)
    {
        System.Console.WriteLine($"Bir adet my class-2 nesnesi oluşturulmuştur a değeri {a}");
    }
}

class MyClass3
{
    public MyClass3()
    {
        System.Console.WriteLine($"Bir adet my class-3 nesnesi oluşturulmuştur. \nBu constructorda overload özelliği vardır");
    }
    public MyClass3(int a)
    {
        System.Console.WriteLine($"Bir adet my class-3 nesnesi oluşturulmuştur \nBu constructorda overload özelliği vardır ve a değeri {a}");
    }
    public MyClass3(string b)
    {
        System.Console.WriteLine($"Bir adet my class-3 nesnesi oluşturulmuştur \nBu constructorda overload özelliği vardır ve b string değeri {b}");
    }
}

class MyClass4
{
    public MyClass4()
    {
        System.Console.WriteLine($"1. Constructor");
    }
    public MyClass4(int a) : this()
    {
        System.Console.WriteLine($"2. Cosntructor {a}");
    }

    public MyClass4(int a, int b) : this(a)
    {
        System.Console.WriteLine($"3. Cosntructor {a} | {b}");
    }
}