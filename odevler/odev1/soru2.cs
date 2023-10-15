namespace _2;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Birinci sayiyi girin: ");
        var n = int.Parse(Console.ReadLine());

        System.Console.Write("Ikinci sayiyi girin: ");
        var m = int.Parse(Console.ReadLine());

        List<int> liste = new List<int>();
        System.Console.WriteLine($"{n} adet sayi girin: ");
        for(int i = 0; i < n; i++){
            System.Console.Write($"Sayi #{i+1}: ");
            var eleman = int.Parse(Console.ReadLine());
            liste.Add(eleman);
        }
        System.Console.WriteLine("Girdiğiniz sayiya esit ya da tam bolunen sayilar: ");
        foreach(int listeEleman in liste){
            if(listeEleman == m || listeEleman % m == 0){
                System.Console.WriteLine(listeEleman);
            }
        }

    }
}
