namespace _07_properties;

class Product {
    public string Name{
        get {
            return _name;
        }
        set{
            if(!string.IsNullOrEmpty(value)){
                _name = value;
            }else{
                System.Console.WriteLine("name bos gecilemez");
            }
        }
    }
    private string _name;

    private double _price;
    public double Price {
         get {return _price;}
         set{
            if(value < 0){
                _price = 0;
            }else{
                _price = value;
            }
        } 
        }            
}

class Program
{
    static void Main(string[] args)
    {
        Product p = new Product();
        System.Console.WriteLine("isim giriniz: ");
        p.Name = Console.ReadLine();

        System.Console.WriteLine("fiyat giriniz: ");
        p.Price = int.Parse(Console.ReadLine());

        System.Console.WriteLine("isim: " + p.Name);
        System.Console.WriteLine("fiyat: " + p.Price);
        
    }
}
