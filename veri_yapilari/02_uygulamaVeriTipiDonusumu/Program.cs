using System;
namespace _02_mainMetodu;

class Program
{
    static void Main(string[] args)
    {
        
       Console.Write("Kısa Kenarı Giriniz: ");
       int kisa = int.Parse(Console.ReadLine());

       Console.Write("Uzun Kenarı Giriniz: ");
       int uzun = int.Parse(Console.ReadLine());

       var alan = kisa * uzun;
       var cevre = (kisa + uzun) * 2;
       
       Console.WriteLine($"alan:{alan} çevre: {cevre}");
        
    }
}