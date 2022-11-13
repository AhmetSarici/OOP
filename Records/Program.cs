// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        //C# 9.0
        //Inıt-Only Properties ile nesnenin ilk değerinin verilmesini vedeğerin değiştirilmemesini garanti altına alır.
        //Readonly properties'e ilk yaratılış anında değer atanmıyor
        //Inıt-Only buna imkan sağlanıyor
        #region ReadOnly
        {
            MyClass m1 = new()
            {
                //  MyProperty = 5
                //Atamayı kabul etmiyor
            };
            MyClass m2 = new();
            System.Console.WriteLine("Readonly Property " + m2.MyProperty);
        }

        #endregion

        #region Init-Only Properties
        {
            MyClass m3 = new()
            {
                Isim = "AHMET SARICI",
                Yıl = 2023

            };
            System.Console.WriteLine("İsim :" + m3.Isim + "\nYıl bilgisi: " + m3.Yıl);
        }
        #endregion
        #region Records C#9.0
        {
            //Bütün propetiesleri init-only properties özelliğine sahip olmasını sağlar
            //Bütün değerler sabit/değişmez olarak kalmasını sağlar
            //Nesne ön planda ise "class" nesnenin değerleri ön planda ise "records" 'tır.
            //**
            //class'ta Equals(x,y) kıyası yapılamaz
            //Record'ta verisel kıyas yapılabilir
            {
                MyClass2 a1 = new()
                {
                    MyProperty = 5
                };
                MyClass2 a2 = new()
                {
                    MyProperty = 5
                };
                MyRecord a3 = new()
                {
                    MyProperty = 5
                };
                MyRecord a4 = new()
                {
                    MyProperty = 5
                };
                System.Console.WriteLine("Class kıyas  : " + a1.Equals(a2));
                System.Console.WriteLine("Records kıyas: " + a3.Equals(a4));



            }
            {
                #region With Expression
                {
                    EmployeeClass b1 = new()
                    {
                        ad = "Ali",
                        maas = 16000
                    };
                    // EmployeeClass b2 = new()
                    // {
                    //     ad = b1.ad,
                    //     maas = 15000
                    // };
                    ///Üsttekinin yerine
                    EmployeeClass b2 = b1.With(15000);
                    System.Console.WriteLine("Class ile hazırlanan :" + b1.ad + " " + b1.maas);
                    System.Console.WriteLine("Class ile hazırlanan :" + b2.ad + " " + b2.maas);
                    EmplooyeRecord b3 = new()
                    {
                        ad = "Veli",
                        maas = 16000
                    };
                    EmplooyeRecord b4 = b3 with { maas = 17000 };
                    System.Console.WriteLine("Record ile hazırlanan :" + b3.ad + " " + b3.maas);
                    System.Console.WriteLine("Record ile hazırlanan :" + b4.ad + " " + b4.maas);

                }

                #endregion
            }

        }
        #endregion

    }
}

record MyRecord
{
    public int MyProperty { get; set; }
}

class MyClass2
{
    public int MyProperty { get; set; }
}

class MyClass
{

    public int MyProperty { get; } = 3;
    public string Isim { get; init; } = "Ahmet Sarıcı";
    public int Yıl { get; init; } = 2022;
}


class EmployeeClass
{
    public string? ad { get; init; } //Nulable operatörü ?
    public int maas { get; init; }

    public EmployeeClass With(int Maas2)
    {
        return new EmployeeClass
        {
            ad = this.ad,
            maas = Maas2
        };
    }
}
record EmplooyeRecord
{
    public string? ad { get; init; } //Nulable operatörü ?
    public int maas { get; init; }
}