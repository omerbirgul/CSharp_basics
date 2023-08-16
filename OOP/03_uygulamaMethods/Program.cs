using System;
namespace _03_uygulamaMethods;

class Program
{
    static void Main(string[] args)
    {
        var soru1 = new Soru(){
        SoruMetni = "Hangisi programlama dili degildir?",
        Secenekler = new string[4] {"C#", "Java", "HTML", "Dart"},
        Cevap = "HTML"};

        var soru2 = new Soru(){
        SoruMetni = "Hangisi en populer programlama dilidir?",
        Secenekler = new string[4] {"C#", "Java", "Pyhton", "Dart"},
        Cevap = "C#"};

        var soru3 = new Soru(){
        SoruMetni = "Hangisi web programlama platformu degildir?",
        Secenekler = new string[4] {"Asp.Net#", "Django", "Spring", "React Native"},
        Cevap = "React Native"};


        var sorular = new Soru[] {soru1, soru2 , soru3};

        foreach(var soru in sorular){
            System.Console.WriteLine(soru.SoruMetni);
            foreach(var secenek in soru.Secenekler){
                System.Console.WriteLine(secenek);
            }
            Console.Write(" Cevabiniz: ");
            var cevabimiz = (Console.ReadLine()).ToLower();
            soru.cevapKontrol(cevabimiz);
            if(soru.cevapKontrol(cevabimiz)){
                System.Console.WriteLine("dogru");
            }else{
                System.Console.WriteLine("yanlis");
            }

            System.Console.WriteLine("*****************************");
            System.Console.WriteLine("*****************************");
        }
        
        
    }


}
class Soru{
    public string SoruMetni { get; set; }
    public string[] Secenekler { get; set; }
    public string Cevap { get; set; }

    public bool cevapKontrol(string cevap){
        return this.Cevap.ToLower() == cevap.ToLower();
    }
}