namespace _04_writeOwnExcepitonClass;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            NewMethod();
        }
        catch(RecordNotFoundException e)
        {
            System.Console.WriteLine(e.Message);
        }
    }

    private static void NewMethod()
    {
        List<string> students = new List<string> { "engin", "derin", "salih" };

        if (!students.Contains("ahmet"))
        {
            throw new RecordNotFoundException("record not found :(");
        }
        else
        {
            System.Console.WriteLine("record found");
        }
    }
}
