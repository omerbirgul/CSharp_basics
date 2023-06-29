namespace _02_karsılastirmaOperatorleri;

class Program
{
    static void Main(string[] args)
    {
        
        int a=5,b=5,c=10;
        string username = "omerbirgul";
        string password = "123456";


        string sonuc = (username == "omerbirgul")? 
        (password == "123456")? "username doğru  parola doğru": "username doğru parola yanlış":
        (password == "123456")? "username yanlış parola doğru": "username yanlış parola yanlış";

        System.Console.WriteLine(sonuc);
    }
}
