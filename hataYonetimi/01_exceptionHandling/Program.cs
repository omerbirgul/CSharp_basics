namespace _01_exceptionHandling;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            Console.Write("a: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("b: ");
            int b = int.Parse(Console.ReadLine());

            var sonuc = a / b;

            Console.WriteLine($"{0} / {1} = {2}",a,b,sonuc);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("b sifir olamaz");
        }

        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
