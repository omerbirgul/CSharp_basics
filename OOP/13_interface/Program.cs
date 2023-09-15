namespace _13_interface;


interface Ikisi
{
    string adSoyad { get; set; }
    string adres { get; set; }
    double maas { get; set; }


}

interface IPersonel
{
    string departman { get; set; }
    void bilgi();

}

class Yonetici : IPersonel, Ikisi
{
    public Yonetici(string _adsoyad, string _adres, string _departman)
    {
        this.adSoyad = _adsoyad;
        this.adres = _adres;
        this.departman = _departman;
    }
    public string adSoyad { get; set; }
    public string adres { get; set; }
    public string departman { get; set; }
    public double maas { get; set; }

    public void bilgi()
    {
    }
}

class Robot : IPersonel
{

    public Robot(string _departman)
    {
        this.departman = _departman;
    }
    public string departman { get; set; }

    public void bilgi()
    {
        Console.WriteLine($"{this.departman} bolumunde robot.");
        
    }
}



class Isci : IPersonel
{

    public Isci(string _adsoyad, string _adres, string _departman)
    {
        this.adSoyad = _adsoyad;
        this.adres = _adres;
        this.departman = _departman;
    }
    public string adSoyad { get; set; }
    public string adres { get; set; }
    public string departman { get; set; }
    public double maas { get; set; }

    public void bilgi()
    {
        Console.WriteLine($"{this.adSoyad} isimli personel {this.departman} bolumunde iscidir.");
    }


}
class Program
{
    static void Main(string[] args)
    {
        var personeller = new IPersonel[3];
        personeller[0] = new Yonetici("omer", "Manisa", "yazilim");
        personeller[1] = new Isci("duygu", "Ankara", "uretim");
        personeller[2] = new Robot("muhasebe");

        foreach (var i in personeller)
        {
            i.bilgi();
        }
    }
}
