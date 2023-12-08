namespace _04_constructorInjection;

interface ILogger
{
    void Log();
}

class Program
{
    static void Main(string[] args)
    {
        EmployeeManager employeeManager = new EmployeeManager(new FileLogger());
        employeeManager.Add();
    }
}

class DatabaseLogger : ILogger
{
    public void Log()
    {
        System.Console.WriteLine("Logged to Database");
    }
}

class FileLogger : ILogger
{
    public void Log()
    {
        System.Console.WriteLine("Logged to File");
    }
}

class EmployeeManager
{
    ILogger _logger;
    public EmployeeManager(ILogger logger)
    {
        _logger = logger;
    }
    public void Add()
    
    {
        _logger.Log();
        System.Console.WriteLine("Added");
    }
}
