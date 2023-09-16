namespace _02_throwException;

class Program
{

    static void checkPassword(string password){
        if(password.Length <8 || password.Length > 15)
        throw new Exception("Parola 7-15 karakter uzunlugunda olmali.");

        if(!password.Any(char.IsDigit))
        throw new Exception("Parola en az bir rakam icermeli.");

        if(!password.Any(char.IsLetter))
        throw new Exception("Parola en az bir harf icermeli.");
    }
    static void Main(string[] args)
    {

        System.Console.Write("Parola Girin: ");
        string parola = Console.ReadLine();

        try
        {
            checkPassword(parola);
            System.Console.WriteLine("parola geçerli");
        }
        catch (Exception e)
        {
            System.Console.WriteLine(e.Message);
        }
        
    }
}
