namespace _02_methodlar;

class Program
{
    static void Main(string[] args)
    {
        Ogrenci ogr1 = new Ogrenci() {AdSoyad = "Duygu Er",OgrenciNo = 100,Sube = "Bilgisayar Mühendisi"};
        Ogrenci ogr2 = new Ogrenci() {AdSoyad = "Omer Birgul",OgrenciNo = 200,Sube = "Bilgisayar Mühendisi"};
        Ogrenci ogr3 = new Ogrenci() {AdSoyad = "Mehmet Dilek",OgrenciNo = 300,Sube = "PDR"};
        

        Ogrenci[] ogrenciler = new Ogrenci[3]{ogr1,ogr2,ogr3};



        foreach( var ogrenci in ogrenciler){
            System.Console.WriteLine(ogrenci.bilgileriYazdir());
        }
    }
}

class Ogrenci{
    public int OgrenciNo { get; set; }
    public string AdSoyad { get; set; }
    public string Sube { get; set; }

    public string bilgileriYazdir(){
        string sonuc = $"{this.AdSoyad} isimli ogrencinin numarası: {this.OgrenciNo} ve subesi: {this.Sube}";
        return sonuc;
    }
}