namespace _01_classUygulama;

class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogr1 = new Ogrenci();
        ogr1.AdSoyad = "Duygu Er";
        ogr1.OgrenciNo = 100;
        ogr1.Sube = "Bilgisayar Mühendisi";

        Ogrenci ogr2 = new Ogrenci();
        ogr2.AdSoyad = "Ömer Birgul";
        ogr2.OgrenciNo = 200;
        ogr2.Sube = "Bilgisayar Mühendisi";


        Ogrenci[] ogrenciler = new Ogrenci[2];

        ogrenciler[0] = ogr1;
        ogrenciler[1] = ogr2;

        foreach( var ogrenci in ogrenciler){
            System.Console.WriteLine($"{ogrenci.AdSoyad} isimli ogrencinin numarası: {ogrenci.OgrenciNo} ve subesi: {ogrenci.Sube}");
        }
    }
}

class Ogrenci{
    public int OgrenciNo { get; set; }
    public string AdSoyad { get; set; }
    public string Sube { get; set; }
}
