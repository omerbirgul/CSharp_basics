namespace _02_genericList;

class Product
{
    public string Name { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> sayilar = new List<int>();
        sayilar.Add(10);
        sayilar.Add(20);
        sayilar.Add(30);


        List<string> isimler = new List<string>();
        isimler.Add("ali");
        isimler.Add("omer");
        isimler.Add("mehmet");

        List<Product> urunler = new List<Product>(){
        new Product() { Name = "Samsung S6"},
        new Product() { Name = "Samsung S7"},
        new Product() { Name = "Samsung S8" },
        new Product() { Name = "Samsung S9" }
    };

        List<Product> urunler2 = new List<Product>(){
        new Product() { Name = "Iphone 10" },
        new Product() { Name = "Iphone 11" },
        new Product() { Name = "Iphone 12" },
        new Product() { Name = "Iphone 13" }
    };



        urunler.AddRange(urunler2);
        urunler.RemoveAt(urunler.Count-1);
        urunler.ForEach(p =>
        {
            Console.WriteLine(p.Name);
        });

        Console.WriteLine($"liste sayisi: {urunler.Count}");




    }
}
