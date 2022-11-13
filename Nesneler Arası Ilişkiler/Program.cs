// See https://aka.ms/new-console-template for more information
class Program
{
    static void Main(string[] args)
    {
        #region Nesneler Arası İlişki Türleri
        //Kalıtımsal, referans veya soyutlama gibi mantıksal ifadeler
        /// is-a
        #region is - a
        {
            //  Kalıtımla alakalıdır.
            //  Kalıtım operatörü ":" ile ortaya çıkan ilişki

            //  A is a B
            //  Opel is a Araba

        }
        #endregion
        #region has - a
        {
            //Başka bir sınıfın nesnesine dair sahiplik ifadesinde bulunulan ilişki
            //Kompozisyon/composition da denir.

            // Opel has a Motor
        }


        #endregion

        #region can - do
        {
            //  interface yapılanmasının getirisi olan ilişki türüdür.
            //  interface = Bir sınıfın içerisinde olacak olan tüm memberların şablonunu oluşturduğumuz kontrattır.
            //  interface uygulayan class o interface içerisinde tanımlanmış member imzalarını kendisinde oluşturmak zorundadır.

            ///      can - do ilişkisi bir nesnenin davranışlarını/kabiliyetlerini belirlemektedir

            /// IAraba interface'ini implemente " : " eden sınıflar gazlar ve frenler
        }

        #endregion

        #endregion
        #region Association
        {
            //Sınıflar arasındaki bağlantının zayıf olmasıdır.
            //Parça - bütün

            //Yolcu ile Otobüs arasındaki ilişki
            //Yolcu biner veya iner ama yolcunun inmesi otobüsü ve diğer yolcuların durumunu değiştirmez.
        }
        #endregion

        #region Aggregation ve Composition
        {
            //Nesneleri birleştirip daha büyük nesne yapmaya verilen isim
            //Bütünsel nesneler yapılır.
            //Her ikisinde de associationda olmayan parça - bütün ilişkisi vardır
            //Her ikisinde de has -a ilişkisi vardır
            //
        }

        //Arabanın tekeri ile vitesi arasındaki ilişki üzerine***

        //Kitapla sayfa ve kapak arasındaki ilişkisi değerlendirilirse***
        #region Aggregation
        {
            //Sahip olunan nesnenin, sahip olan nesneden bağımsız bir şekilde var olabilmesi durumudur.

            //**    Araba teker olmadan olmaz
            //**    Teker araba olmadan anlamlıdır


            //***   Sayfa yırtılırsa kitap zarar görür
            //***   Sayfa kitap olmadan da var olabilir


            //****  Duvar tuğla olmadan olmaz
            //****  Tuğla duvar olmak haricinde tek başına da işlevsel kullanılabilir
        }
        #endregion

        #region Composition
        {
            //Sahip olunan nesnenin, sahip olan nesneden bağımsız bir şekilde var olamaması* durumudur.

            //**    Araba vites olmadan olmaz
            //**    Vites araba olmadan anlamsızdır.

            //***   Kapak olmazsa kitap eksik kalır.
            //***   Kapak tek başına anlamsızdır.

            //****  Duvar çimento olmadan olmaz
            //****  Çimento duvar yapısı olmadığında işlevsel kullanımı yoktur
        }
        #endregion



        #endregion
    }
}


#region is - a
class Araba
{

}
class Opel : Araba
{

}
#endregion


#region has - a
class Araba2
{

}
class Opel2 : Araba2
{
    Motor2? motor;
}
class Motor2
{

}
#endregion


#region can - do
interface IAraba
{
    //interface gövdesiz
    void gaz();
    void fren();
}
class Opel3 : IAraba
{
    public void gaz()
    {

    }
    public void fren()
    {

    }
}

#endregion




