namespace _05_constructorMethodsUygulama;

class Program
{
    static void Main(string[] args)
    {
        var p2 = new Product(new Random().Next(1111,9999), "Samsung", 3000, true);
        var c1 = new Comment{CommentId = 1, Text = "Guzel Telefon"};
        p2.Comments = new Comment[3];
        p2.Comments[0] = c1;
       

        System.Console.WriteLine("*******************************");

        System.Console.WriteLine(p2.Name);
        System.Console.WriteLine(p2.ProductId);
        System.Console.WriteLine(p2.Price);
        System.Console.WriteLine(p2.IsApproved);
        System.Console.WriteLine(p2.Comments[0].Text);
    }
}

class Product{
    public int ProductId { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public bool IsApproved { get; set; }
    public Comment[] Comments { get; set; }

    public Product(int productId):this(){
        this.ProductId = (new Random()).Next(1111,9999);
    }

    public Product(int productId, string name, double fiyat, bool isApproved)
    {
        this.ProductId = productId;
        this.Name  = name;
        this.Price = fiyat;
        this.IsApproved = isApproved;
    }
    
}

class Comment{
    public int CommentId { get; set; }
    public string Text { get; set; }
}
