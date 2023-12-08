namespace _16_recapDemo;

interface ILogger
{
    void Log();
}

class Program
{
    static void Main(string[] args)
    {
        CustomerManager customerManager = new CustomerManager();
        customerManager.logger = new FileLogger();
        customerManager.Add();
    }
}

class CustomerManager
{
    public ILogger logger { get; set; }
    public void Add()
    {
        logger.Log();
        System.Console.WriteLine("Customer Added");
    }
}

class DatabaseLogger:ILogger
{
    public void Log()
    {
        System.Console.WriteLine("Database Logged");
    }
}

class FileLogger:ILogger
{
    public void Log()
    {
        System.Console.WriteLine("File Logged");
    }
}
