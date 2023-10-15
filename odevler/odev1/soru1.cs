namespace _1;

class Program
{
    static void Main(string[] args)
    {
        System.Console.Write("Pozitif bir sayi girin:" );
        var sayi = int.Parse(Console.ReadLine());
        List<int> sayiListesi =new List<int>();
        System.Console.WriteLine($"{sayi} adet sayi giriniz: ");
        for(int i =0; i <sayi; i++){
            System.Console.Write($"Sayi #{i+1}: ");
            var eleman = int.Parse(Console.ReadLine());
            sayiListesi.Add(eleman);
            
        }
        System.Console.WriteLine("***************************");
        foreach(int i in sayiListesi){
            if(i % 2 == 0){
                System.Console.WriteLine(i);
            }
        }
        
    }
}
