namespace _0_accessModifiers; 
using System;
class Program
{
    static void Main(string[] args)
    {
        var soru1 = new Soru(1,"Hangisi programlama dili degildir?",new string[4] {"C#", "Java", "HTML", "Dart"},"HTML");
        var soru2 = new Soru(2,"Hangisi en populer programlama dilidir?",new string[4] {"C#", "Java", "Pyhton", "Dart"},"C#");
        var soru3 = new Soru(3,"Hangisi web programlama platformu degildir?",new string[4] {"Asp.Net#", "Django", "Spring", "React Native"},"React Native");

        System.Console.WriteLine(soru1.soruYazdir());
        System.Console.Write("seceneginiz:");
        var cevabimiz = (Console.ReadLine()).ToLower();

        if(soru1.cevapKontrol(cevabimiz)){
            System.Console.WriteLine("dogru");
        }else{
            System.Console.WriteLine("yanlis");
        }


        
    }


}
class Soru{


    public Soru(int SoruId, string SoruMetni, string[] Secenekler, string Cevap){
        this.SoruMetni = SoruMetni;
        this.SoruId = SoruId;
        this.Secenekler = Secenekler;
        this.Cevap = Cevap;
    }
    private string SoruMetni { get; set; }
    private string[] Secenekler { get; set; }
    private string Cevap { get; set; }
    private int SoruId { get; set; }

    public string soruYazdir(){
        string soru = "";
        soru += this.SoruMetni + "\n";
        foreach(var secenek in this.Secenekler){
            soru += secenek + "\n";
        }
        return soru;
    }

    public bool cevapKontrol(string cevap){
        return this.Cevap.ToLower() == cevap.ToLower();
    }
}