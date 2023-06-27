namespace _04_diziler;

class Program
{
    static void Main(string[] args)
    {
        string[] isimler = {"ahmet", "çınar","ali","zeynep","duygu"};
        int[] numaralar = {101,102,103,104,105};

        isimler.SetValue("ege",0);
        // System.Console.WriteLine(isimler.GetValue(0));
        // System.Console.WriteLine(Array.IndexOf(isimler,"duygu"));
        Array.Sort(isimler);
        System.Console.WriteLine(isimler.GetValue(0));
        Array.Reverse(isimler);
        System.Console.WriteLine(isimler.GetValue(0));

        var result = isimler[..3];

        foreach(var isim in result){
            System.Console.WriteLine(isim);
        }
  


        // System.Console.WriteLine($"Öğrenci adı: {isimler[0]} ve numara: {numaralar[0]}");
        // System.Console.WriteLine($"Öğrenci adı: {isimler[1]} ve numara: {numaralar[1]}");
        // System.Console.WriteLine($"Öğrenci adı: {isimler[2]} ve numara: {numaralar[2]}");
        // System.Console.WriteLine($"Öğrenci adı: {isimler[3]} ve numara: {numaralar[3]}");
        // System.Console.WriteLine($"Öğrenci adı: {isimler[4]} ve numara: {numaralar[4]}");
    }
}
