namespace _04_constructorMethods; 
using System;
class Program
{
    static void Main(string[] args)
    {
        var soru1 = new Soru(1,"Hangisi programlama dili degildir?",new string[4] {"C#", "Java", "HTML", "Dart"},"HTML");
        var soru2 = new Soru(2,"Hangisi en populer programlama dilidir?",new string[4] {"C#", "Java", "Pyhton", "Dart"},"C#");
        var soru3 = new Soru(3,"Hangisi web programlama platformu degildir?",new string[4] {"Asp.Net#", "Django", "Spring", "React Native"},"React Native");

        
    }


}
class Soru{

    public Soru(){
        System.Console.WriteLine("obje eklendi");
    }

    public Soru(int SoruId, string SoruMetni, string[] Secenekler, string Cevap){
        this.SoruMetni = SoruMetni;
        this.SoruId = SoruId;
        this.Secenekler = Secenekler;
        this.Cevap = Cevap;
    }
    public string SoruMetni { get; set; }
    public string[] Secenekler { get; set; }
    public string Cevap { get; set; }

    public bool cevapKontrol(string cevap){
        return this.Cevap.ToLower() == cevap.ToLower();
    }
}