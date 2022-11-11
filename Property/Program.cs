// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {

        #region Property
        //Metod yapısıdır
        //get-set olarak iki block bulunur
        //propetyde parantez() yer almaz
        //mtotlarla aynıdır
        //değer okuma değer atama işleminde kullanılır
        //fielde doğrudan erişim imkanını sınırlarız
        //field değere doğrudan erişim engellenir
        //bu ileve encapsulation kapsülleme denir

        /// Metodlardan farkı türü olmak zorunda
        // // metod    => myClass.x();
        // // property => myClassx="Ali Veli";



        #endregion

        #region Propert İmza
        {
            #region Full property
            //Erişim belirleyicisi
            //Geri dönüş değeri
            //Set/get
            MyclassFullProp my1 = new MyclassFullProp();
            System.Console.WriteLine("Full Prop Örneği : " + my1.Yasi);
            my1.Yasi = 28;
            System.Console.WriteLine("Full Prop Örneği : " + my1.Yasi);
            #endregion
        }

        {
            #region Prop
            //herhangi işlem yapmadan direkt fiealda gönderir
            //10 gönderdin 10 aldın
            //get-set
            //read only olabilir write only olamaz
            MyClassProp my2 = new MyClassProp();
            my2.Yasi = 55;
            System.Console.WriteLine("Prop Örneği : " + my2.Yasi);
            #endregion
        }
        {
            #region Auto Property Initializers C# 6.0
            //İlk değer nesne ayağa kaldırır kaldırmaz verilir
            MyAutoProp my3 = new MyAutoProp();
            System.Console.WriteLine("AutoProp Örneği : " + my3.MyAutoProperty);
            #endregion
        }
        {
            #region Ref Readonly Returns C# 7.2
            //ref metodlarda değişkenin referansını alan yapıydı
            //referans üzerinden erişerek bellek optimizasyonu sağlar
            RefClass my4 = new RefClass();
            System.Console.WriteLine("RefProp Örneği : " + my4.Adi);
            #endregion
        }
        {
            #region Computed(Hesaplanmış) Prop
            MyComputed my5 = new MyComputed();
            System.Console.WriteLine("Computed İşlem Örneği : " + my5.Topla);
            #endregion
        }

        {
            #region Expression-Bodied Property

            // sadece read-only kullanılıyor
            // lambda expression kullanılır
            MyExpBodied my6 = new MyExpBodied();
            System.Console.WriteLine("Expression-Bodied Property Örneği : " + my6.Cinsiyet);

            #endregion
        }

        {
            #region Inıt-DateOnly Properties ve Inıt Accessor  C# 9.0  
            //Nesnenin ilk yaratılış anında değer atanır
            //Run timeda değeri değişmemesi gereken nesneler için


            #endregion
        }
        {
            #region İndexer
            //İndexer
            ///erişim belirleni
            //geri dönüş değeri
            //this
            MyIndexer my7 = new MyIndexer();
            my7[5] = 2022;
            System.Console.WriteLine("Indexer Property Örneği : " + my7[5]);

            #endregion
        }
        // 
        #endregion

    }
}


class Banka
{
    private int bakiye;
    public int Bakiye
    {
        get
        {
            if (bakiye > 15000)
                return bakiye * 10 / 100;
            return 5000;
        }
        set
        {
            if (value < 10000)
            {
                bakiye = value;
            }
            else
            {
                bakiye = value * 95 / 100;
            }
        }
    }


}


class MyclassFullProp
{

    #region Full Property
    //
    private int yas;
    public int Yasi
    {
        get { return yas; }
        set { yas = value; }
    }


    #endregion

}

class MyClassProp
{
    public int Yasi { get; set; }
}


class MyAutoProp
{
    public int MyAutoProperty { get; set; } = 500;
}

class MyIndexer
{


    public int this[int a]
    {
        get
        {
            return a;
        }
        set
        {
            a = value;
        }
    }
}

class RefClass
{
    string adi = "Ahmet Sarici";
    public ref readonly string Adi => ref adi;
}


class MyComputed
{
    int a = 5;
    int b = 15;
    public int Topla { get { return a + b; } }
}

class MyExpBodied
{
    public string Cinsiyet => "Erkek";
}