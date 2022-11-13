// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        //Sınıfın nesnesi üzerinden geriye hızlıca tupple bir değer döndüren yapı
        //Özel sınıf memberlarının ortak özelliği sınıf isimlerini taşımakta idi
        //Deconstruct deconstruct isminde olmalıdır.***
        #region Deconstruct
        Person p1 = new()
        {
            Name = "Veli",
            Age = 27
        };
        var (x, y) = p1;

        System.Console.WriteLine($"{x} kişisinin yaşı {y}' dir.");
        #endregion
    }
}

class Person
{
    public string? Name { get; set; }

    public int Age { get; set; }

    public void Deconstruct(out string ad, out int yas)
    {
        ad = Name;
        yas = Age;
    }
}