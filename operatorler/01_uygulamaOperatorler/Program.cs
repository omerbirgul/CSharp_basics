
namespace _01_uygulamaOperatorler;

class Program
{
    static void Main(string[] args)
    {

        //Kullanıcıdan alınan 2 sayının çarpımı ile x,y,z toplamının farkını bul.
        int x=2, y= 5, z=10;
        Console.Write("Ilk sayiyi girin: ");
         int a = int.Parse(Console.ReadLine());

        Console.Write("Ikinci sayiyi girin: ");
        int b = int.Parse(Console.ReadLine());

        int sonuc1 = (a*b) - (x+y+z);
        
        System.Console.WriteLine("sonuç1 = " + sonuc1);

        // //********************************************

        //Kullanıcıdan alınan bir sayının tek/ çift kontorlünü yap.  
        Console.Write("Deger girin: ");
        int c =int.Parse(Console.ReadLine());
        string sonuc2 = (c % 2) == 1? "tek" : "çift";
        System.Console.WriteLine("sonuc2 = " + sonuc2);


        // //*********************************************

        //(x,y,z) toplamının mod 3'ü kaçtır?
        var sonuc3 = ((x+y+z) % 3);
        System.Console.WriteLine("sonuç3 = " + sonuc3);


        // //*******************************************

        //y'nin x. kuvvetini hesaplayınız.
        var sonuc4 = Math.Pow(y,x);
        System.Console.WriteLine("sonuç4 = " + sonuc4);

        // //****************************************





    }
}
