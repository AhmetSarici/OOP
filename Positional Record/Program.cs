// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        #region Positional Record
        //Class ve Recordlaa nazaran yeni bir semantik
        MyRecord2 m = new("Ahmet", "Sarıcı");
        var (a, b) = m;
        System.Console.WriteLine("Positional Record Özelliği ile kişi ad soyad :" + a + " " + b);
        //Contruct ve deconstruct özelliğine hızlı bir kullanım imkanı verir.
        MyRecord3 m2 = new("Ahmet", "Sarıcı");
        System.Console.WriteLine(m2.Name);
        #endregion
    }

}

record MyRecord
{
    public MyRecord()
    {

    }
    public void Deconstruct()
    {

    }
}


//Propertyler init olacak şekilde oluşturulur
//Compiler seviyesinde propertyler otomatik oluşturulur
record MyRecord2(string name, string surname)
{
}

//Positional Record kullanılıyor ise manuel bir construct tanımlıyor isek Positional Record Tetiklenek zorunludur.
record MyRecord3(string name, string surname)
{
    public MyRecord3() : this("Ali", "Can")
    {

    }
    public MyRecord3(string name) : this()//boş olan constructor tetiklendiğinde positional record yapıları da tetiklenir.
    {

    }


    public string Name => name;
    public string Surname => surname;
}