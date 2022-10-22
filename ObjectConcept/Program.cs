// See https://aka.ms/new-console-template for more information

//Nesneler complex type'tır
class Program
{
    static void Main(string[] args)
    {
        //Nesne üretimi için: new Type()
        // "()" constructur


        // new MyClass(); //// 1. nesne
        //**Ram deki heap bölgesinde nesne oluşturuldu 

        // MyClass my;     
        //**Referans Ramdeki stack bölgesinde
        //**Bir nesne referans etmiyorsa default olarak null alır. 

        // = operatörü asign eder, atama yapar
        // Referanssız nesneler Garbage Collector ile yok edilir.


        MyClass my = new MyClass();/// 2. nesne oluşturuldu ve atandı
        MyClass my2 = new();
        my2.A = 500;
        System.Console.WriteLine(my2.A);



        #region Target-Typed New Expression C# 9.0
        {
            MyClass my3 = new();
            my3.X = 15;
            System.Console.WriteLine(my3.X);
        }
        #endregion

        #region Object Initializer
        {
            MyClass my4 = new()
            {

                X = 800,
                A = 750
            };
            //my4.X = 15;
            System.Console.WriteLine("**Object Initializer**");
            System.Console.WriteLine(my4.X + ": x değeri ve A değeri : " + my4.A);
        }
        #endregion

        #region Shallow & Deep Copy

        {
            #region  Shallow bir nesne birden fazla referans ile nesnenin işaretlenmesi
            {
                //Değerin,referansın nesnenin miktarı artmadan kopyalanmasıdır
                MyClass m1 = new MyClass();
                MyClass m2 = m1;//Shallow Copy
                MyClass m3 = m2;//Shallow Copy
                MyClass m4 = new MyClass();
            }
            #endregion
        }
        {
            #region Deep Copy
            {
                //Bir nesnenin değerleri ile birlikte nesnenin kopyalanarak arttırılmasıdır
                //int a=5;
                //int b=a;
                MyClass2 ma = new MyClass2();
                ma.Yıl = 2022;
                MyClass2 mb = ma;//Shallow ma değiştiğinde mb de değişir


                MyClass2 mc = ma.Clone();//Deep Copy ma değiştiğinde mb değişmez

                ma.Yıl = 2050;
                System.Console.WriteLine("Shallow Kopyalanmış mb nesnesi ma değiştiğinde değişir: " + mb.Yıl);
                System.Console.WriteLine("Deep Kopyalanmış mc nesnesi ma değiştiğinde değişmez : " + mc.Yıl);
            }
            #endregion
        }


        #endregion



    }
}

class MyClass2
{
    public int Yıl { get; set; }
    public MyClass2 Clone()
    {
        return (MyClass2)this.MemberwiseClone();
    }
}


class MyClass
{
    private int a;
    public int X
    {
        get { return a; }
        set { a = value; }
    }

    public int A { get; set; }
}