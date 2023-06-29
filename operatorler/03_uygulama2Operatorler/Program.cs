
using System;
namespace _03_uygulama2Operatorler;

class Program
{
    static void Main(string[] args)
    {
        // 1-) Girilen iki sayıdan hangisi daha büyüktür?

        // Console.Write("Ilk sayiyi gir: ");
        // int sayi1 = int.Parse(Console.ReadLine());

        // Console.Write("Ikinci sayiyi gir: ");
        // int sayi2 = int.Parse(Console.ReadLine());
        
        // var sonuc = (sayi1 > sayi2);
        // System.Console.WriteLine("sayi1 büyük mü sayi2? " + sonuc);



        // 2-) Parola ve email bilgisini isteyip doğruluğunu kontrol ediniz.

        Console.Write("email giriniz: ");
        var userEmail = Console.ReadLine();

        Console.Write("parola giriniz: ");
        var userPassword = Console.ReadLine();

        string email = "omerbirgul@hotmail.com";
        string password = "123456";

        var statu = (userEmail == email)?
        (userPassword == password)? "email doğru, parola doğru" : "email doğru, parola yanliş":
        (userPassword == password)? "email yanliş, parola doğru": "email yanliş parola yanliş";

        System.Console.WriteLine(statu);

    }
}
