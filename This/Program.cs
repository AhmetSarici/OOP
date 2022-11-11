// See https://aka.ms/new-console-template for more information
class Program
{
    //This keywordü Sınıfın nesnesini temsil eder
    MyClass m1 = new MyClass();
    MyClass m2 = new MyClass();


    //Aynı isimde Field ile metodu ayırmak için kullanılır
    //This keyword'ü class yapılanmasının o anki nesnesine karşılık gelir.


    //Contructurdan constructur çağırmak için kullanılır

}

class MyClass
{
    int a;
    public void Y()
    {
        this.Y(); //bu hali ile rekürsive oluşur
    }
    public void X(int a)
    {

        //a parametre olarak gelen a
        //Field da yer alan a
        this.a = a;

    }
}