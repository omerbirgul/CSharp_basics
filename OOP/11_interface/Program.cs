namespace _11_interface;


class Person{
    public string Name { get; set; }
    public string SurName { get; set; }

    public Person(string name, string surName){
        this.Name = name;
        this.SurName = surName;

        
    }
}


class Student: Person{
    public string StudentNumber { get; set; }

    public Student(string name, string surName, string StudentNumber): base(name,surName){
        this.StudentNumber = StudentNumber;
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        var p = new Person("omer","birgul");
        var s = new Student("duygu","er","12345");

        System.Console.WriteLine($"name: {p.Name} surname: {p.SurName}");
        System.Console.WriteLine($"name: {s.Name} surname: {s.SurName} number: {s.StudentNumber}");
    }
}
