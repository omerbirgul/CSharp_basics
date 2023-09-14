namespace _10_uygulamaStaticMembers;


class Product{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public double ProductPrice { get; set; }
    public bool IsApproved { get; set; }
}


static class ProductManager{
    static Product[] Products;
    
    static ProductManager()
    {
        Products = new Product[5];

        Products[0] = new Product{ProductId = 1, ProductName = "Iphone 10", ProductPrice = 10000, IsApproved = true};
        Products[1] = new Product{ProductId = 2, ProductName = "Iphone 11", ProductPrice = 20000, IsApproved = true};
        Products[2] = new Product{ProductId = 3, ProductName = "Iphone 12", ProductPrice = 30000, IsApproved = true};
        Products[3] = new Product{ProductId = 4, ProductName = "Iphone 13", ProductPrice = 40000, IsApproved = true};
        Products[4] = new Product{ProductId = 5, ProductName = "Iphone 14", ProductPrice = 50000, IsApproved = true};
    }


    public static Product[] GetProducts(){
        return Products;
    }

    public static Product getProductById(int id){
        Product product = null;

        foreach(var j in Products  ){
            if(j.ProductId == id){
                product = j;
            }
        }

        return product;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var p1 = ProductManager.getProductById(2);
            System.Console.WriteLine($"name: {p1.ProductName}, price: {p1.ProductPrice}");

        
    }
}
