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
    public void Add(Iperson person)
    {
        System.Console.WriteLine(person.FirstName);
    }
}

class Program
{
    static void Main(string[] args)
    {
        PersonManager manager = new PersonManager();
        Customer customer = new Customer()
        {
           ID=1,
           FirstName="omer",
           LastName="birgul" 
        };
        manager.Add(customer);

        Student student = new Student(){
            ID=1,
            FirstName="duygu",
            LastName="er",
            Department="Computer science"
        };

        manager.Add(student);
    
    }
}
