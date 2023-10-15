namespace _4;

class Program
{
    static void Main(string[] args)
    {
        System.Console.WriteLine("Bir cumle yazin: ");
        var cumle = Console.ReadLine();

        var harf = harfSayisiBul(cumle);
        var kelime = kelimeSayisiBul(cumle);


        System.Console.WriteLine($"Cumledeki harf sayisi: {harf}");
        System.Console.WriteLine($"Cumledeki kelime sayisi: {kelime}");

    }

    static int harfSayisiBul(string a){
        string safUzunluk = a.Replace(" ","");
        return safUzunluk.Length;
    }

    static int kelimeSayisiBul(string a){
        string[] kelimeler = a.Split(" ");
        return kelimeler.Length;

    }
}
