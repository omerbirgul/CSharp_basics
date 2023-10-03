namespace ornek2;

interface Iperson
{
     int ID { get; set; }
     string FirstName { get; set; }
     string LastName { get; set; }
}

class Customer : Iperson
{
    public int ID { get ; set ; }
    public string FirstName { get ; set ; }
    public string LastName { get ; set ; }
    public string Adress { get; set; }
}

class Student :Iperson
{
    public int ID { get ; set ; }
    public string FirstName { get ; set ; }
    public string LastName { get ; set ; }
    public string Department { get; set; }
    
}

class PersonManager
{
    public void Add(Customer customer)
    {
        System.Console.WriteLine(customer.FirstName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        PersonManager manager = new PersonManager();
        manager.Add(new Customer{ID=1,FirstName="omer",LastName="birgul"});
    }
}
