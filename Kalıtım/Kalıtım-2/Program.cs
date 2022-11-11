// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        #region Kalıtım-2

        {
            // Bir class sadece bir base class'a sahip olabilir, tek bir ataya izin verilir.
            // Nesne üretilirken en üstteki atadan başlanarak nesne üretilmeye başlanır heap'te.
            new D();
            System.Console.WriteLine("--------------------");
            //Base clastaki contructor parametre alıyorsa eğer
            new MyClass2();
            new MyClass2(99);


            //This constructorlar arasında geçişi sağlarken Base base classa derived class aracılığı ile parametreli constructorların hangisini tetikleneceği belirlenir.
            //This o an ki sınıf
            //Derived ise sınıf üst sınıfın memberlerı da gelir.
            System.Console.WriteLine("--------------------");

            P2 pclass = new();
            pclass.X();
            System.Console.WriteLine("P2 - Derived : " + pclass.MyProperty);
        }
        #endregion
    }
}





class A
{
    public A()
    {
        System.Console.WriteLine($"{nameof(A)}'dan üretildi.");
    }

}
class B : A
{
    public B()
    {
        System.Console.WriteLine($"{nameof(B)}'den üretildi.");
    }
}

class C : B
{
    public C()
    {
        System.Console.WriteLine($"{nameof(C)}'den üretildi.");
    }
}

class D : C
{
    public D()
    {
        System.Console.WriteLine($"{nameof(D)}'den üretildi.");
    }
}


class MyClass
{
    public MyClass(int a)
    {
        System.Console.WriteLine($"MyClass2 den gelen değer {a} MyClass1 mesajı");
    }
}

class MyClass2 : MyClass
{
    public MyClass2() : base(55)
    {
        System.Console.WriteLine($"MyClass2 değer alınmadı");
        System.Console.WriteLine("--------*-------");
    }

    public MyClass2(int b) : base(125)
    {
        System.Console.WriteLine($"MyClass2 ye* gelen değer {b}");
    }
}

class P1
{
    //   int a;
    // public int b;
    public int MyProperty { get; set; }

}

class P2 : P1
{
    //  int c;
    public void X()
    {
        MyProperty = 123;
    }
}
