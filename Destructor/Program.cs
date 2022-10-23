// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        #region Destructor
        //Classtan üretilmiş nesne imha edilirken totomatik çağırılan metottur
        //Sadece class yapısında kullanılır
        //Overloading yapamaz parametre alamaz
        //Sadece 1 adet kurulabilir
        //Sınıf ismi ile aynı isme sahip olmalıdır
        //İsmin önüne tilda işareti eklenir "~"
        {
            //***Nesne hangi şartlarda imha edilir**//
            //Nesne herhangi referans tarafından işaretlenmiyorsa
            //Nesnenin oluşturulduğu scope sona ermişse
            //Nesne erişilemez hale geldi ise


            x();
            //GC.Collect() 'ile gabage collector ile nesne imha edilir
            GC.Collect();
            System.Console.WriteLine("------------");

            int sayi = 15;
            while (sayi >= 1)
            {
                new MyClass2(sayi--);
            }
            System.Console.WriteLine("**************");
            GC.Collect();
            Console.ReadLine();
        }

        #endregion
    }

    static void x()
    {
        MyClass m2 = new();
    }
}

class MyClass
{
    public MyClass()
    {
        System.Console.WriteLine("Merhaba");
    }
    ~MyClass()
    {
        System.Console.WriteLine("Bye Bye");
    }
}

class MyClass2
{
    int no;
    public MyClass2(int no)
    {
        this.no = no;
        System.Console.WriteLine($"{no}. nesne oluşturulmuştur.");
    }
    ~MyClass2()
    {
        System.Console.WriteLine($"{no}. nesne imha edilmiştir.");
    }
}