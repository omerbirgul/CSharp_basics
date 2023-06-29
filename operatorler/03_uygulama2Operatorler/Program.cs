
using System;
namespace _03_uygulama2Operatorler;

class Program
{
    static void Main(string[] args)
    {
        // Girilen iki sayıdan hangisi daha büyüktür?
        Console.Write("Ilk sayiyi gir: ");
        int sayi1 = int.Parse(Console.ReadLine());

        Console.Write("Ikinci sayiyi gir: ");
        int sayi2 = int.Parse(Console.ReadLine());
        
        var sonuc = (sayi1 > sayi2);
        System.Console.WriteLine("sayi1 büyük mü sayi2? " + sonuc);

    }
}
