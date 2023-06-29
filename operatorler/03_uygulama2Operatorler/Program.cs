
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

        // Console.Write("email giriniz: ");
        // var userEmail = Console.ReadLine();

        // Console.Write("parola giriniz: ");
        // var userPassword = Console.ReadLine();

        // string email = "omerbirgul@hotmail.com";
        // string password = "123456";

        // var statu = (userEmail == email)?
        // (userPassword == password)? "email doğru, parola doğru" : "email doğru, parola yanliş":
        // (userPassword == password)? "email yanliş, parola doğru": "email yanliş parola yanliş";

        // System.Console.WriteLine(statu);



        // 3-) Girilen bir sayının pozitif çift sayı olup olmadığını kontrol et.

        // Console.Write("sayi girin: ");
        // int a = int.Parse(Console.ReadLine());
        
        // var deger = (a >= 0) && (a % 2 == 0)? "sayi pozitif çiftdir" : " ";
        // System.Console.WriteLine(deger);



        // 4-) Girilen 3 sayiyi buyukluk olarak karsilastiriniz.

        Console.Write("Ilk sayi girin: ");
        var x =  int.Parse(Console.ReadLine());

        Console.Write("Ikinci sayi girin: ");
        var y =  int.Parse(Console.ReadLine());

        Console.Write("Ucuncu sayi girin: ");
        var z =  int.Parse(Console.ReadLine());

       var karsilastirma = (x > y) && (x > z);
       System.Console.WriteLine("en buyuk sayi x: " + karsilastirma);

       karsilastirma = (y > x) && (y > z);
       System.Console.WriteLine("en buyuk sayi y: " + karsilastirma);

       karsilastirma = (z > x) && (z > y);
       System.Console.WriteLine("en buyuk sayi z: " + karsilastirma);

    }
}
