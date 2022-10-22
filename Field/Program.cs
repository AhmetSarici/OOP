// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        #region Sınıf Nasıl ve Nerede Oluşturulur
        //namespace içerisinde
        //namespace dışında
        //class içerisinde(nasted type)


        //// MyClass1.MyClass2 m2= new MyClass1.MyClass2(); şeklinde ulaşılır
        ////Sınıf elemanı değildir
        #endregion


        Myclass my = new Myclass();
        my.cagır();

        OrnekModel o1 = new OrnekModel();
        o1.a = 5;  //Fieldlar türüne özgü değeri alır
        o1.b = 10;
        o1.x();

        System.Console.WriteLine(o1.a);
        o1.y();


        o1.x(50);





    }
}


//Sınıfa açıklama ekleme


///<summary>
/// Bu bir sınıf açıklamasıdır
///</summary>
class OrnekModel
{

    ///<summary>
    /// Bu bir field açıklamasıdır
    ///</summary>
    public int a;//Field
    public int b;//Field sadece class içerisinde tanımlanır
    public void x()
    {
        System.Console.WriteLine(a + " * " + b + " = " + (a * b));
    }

    ///<summary>
    /// Bu bir overload metod açıklamasıdır
    ///</summary>
    /// <param name="a">a parametresi..</param>
    public void x(int a)
    {
        System.Console.WriteLine(a + " " + b);
    }
    public int y()
    {
        return a * b;
    }
}

class Myclass
{
    public void cagır()
    {
        System.Console.WriteLine("Ali artık kod yazıyor");
    }

}