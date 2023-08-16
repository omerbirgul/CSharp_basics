namespace _03_uygulamaMethods2;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}


class Araba{
    public string Marka { get; set; }
    public string Model { get; set; }
    public string Renk { get; set; }
    public bool Otomatik { get; set; }

    public void Start(){
        System.Console.WriteLine("araba calisti");
    }
}
