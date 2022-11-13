// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        #region Static Polimorfizm
        {
            //Buradaki metot overridenda derleme anında belilenmiştir.
            Matematik m = new();
            m.Topla(4, 5);
            m.Topla(1, 2, 3);
        }
        #endregion

        #region Dinamik Polimorfizm
        {
            //Çalışma anında belilenen override
            Arac a = new();
            a.Calistir();

            Arac a2 = new Taksi();
            a2.Calistir();

            Taksi t1 = new Taksi();
            t1.Calistir();
        }
        #endregion

        #region Tür Dönüşümleri
        {
            //Özünde C olan nesne talep halinde kendi türüne cast operatörü ile dönüştürülebilmektedir

            //Object türünde buna boxing/unboxing deniyor.
            ///     cast operatörü
            A anesnesi = new C();
            C cnesnesi = (C)anesnesi;

            C cn2 = new C();
            A an2 = cn2;        // A an2=(A)cn2





            //boxing : objectin içerisine yollarken değer
            ///     cast operatörü
            object o1 = new A();
            object i1 = 123;

            //unboxing : objectin içinden kendi türünde geri elde etme işlemi
            ///     cast operatörü
            A oyeni = (A)o1;
            int iyeni = (int)i1;

            ///** Torun atasının dengi olmadığı için tür dönüşümü gerçekleşmez run time hatası alınır
            ///**Yani B ile türetilen bir nesnenin işaretçisi/dönüşümü C olamaz.
            ///Her zaman üst altını işaret eder, alt üstünü işaret edemez.


            {
                //      as operatörü
                A a3 = new C();
                C? c3 = a3 as C;//? Nulable operatörü

                //Burada atayı torunun referans etmeye çalışıldığı durumlarda null döner.

                //      is operatörü
                //Bu operatör işaretçinin türünü sorgulamamıza olanak tanır.
                System.Console.WriteLine($"a3 C sınıfından mıdır? :{a3 is C}");
                System.Console.WriteLine($"a3 A sınıfından mıdır? :{a3 is A}");
                System.Console.WriteLine($"a3 B sınıfından mıdır? :{a3 is B}");
                System.Console.WriteLine($"a3 D sınıfından mıdır? :{a3 is D}");
                System.Console.WriteLine($"o1 A sınıfından mıdır? :{a3 is A}");
            }
        }
        #endregion
    }
}

#region Satatic Polimorfizm


class Matematik
{
    public long Topla(int a, int b) => a + b;
    public long Topla(int a, int b, int c) => a + b + c;
    public long Topla(int a, int b, int c, int d) => a + b + c + d;
}
#endregion

#region Dinamik Polimorfizm


class Arac
{
    public virtual void Calistir() => System.Console.WriteLine("Araç Çalıştırıldı..");
}
class Taksi : Arac
{
    public override void Calistir() => System.Console.WriteLine("Taksi Çalıştırıldı..");
}

#endregion


#region Tür Dönüşümleri


class A
{
    public int X { get; set; }
}

class B : A
{
    public int Y { get; set; }
}

class C : B
{
    public int Z { get; set; }
}

class D : C
{

}
#endregion
