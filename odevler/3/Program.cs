namespace _3;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Pozitif bir sayi girin: ");
        var n = int.Parse(Console.ReadLine());

        List<string> kelimeListesi = new List<string>();
        System.Console.WriteLine($"{n} adet kelime girin: ");
        for(int i = 0; i < n; i++){
            string kelime = Console.ReadLine();
            kelimeListesi.Add(kelime);
        }
        System.Console.WriteLine("****************");
        kelimeListesi.Reverse();
        foreach(string item in kelimeListesi){
            System.Console.WriteLine(item);
        }
    }
}
