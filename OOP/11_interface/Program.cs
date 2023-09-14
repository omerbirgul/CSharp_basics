namespace _11_interface;


class Person{
    public string Name { get; set; }
    public string SurName { get; set; }

    public Person(string name, string surName){
        this.Name = name;
        this.SurName = surName;        
    }

    public virtual void intro(){
        System.Console.WriteLine($"name: {this.Name} surname: {this.SurName}");
    }
}


class Student: Person{
    public string StudentNumber { get; set; }

    public Student(string name, string surName, string StudentNumber): base(name,surName){
        this.StudentNumber = StudentNumber;
        
    }

    public override void intro()
    {
        System.Console.WriteLine($"name: {this.Name} surname: {this.SurName} number: {this.StudentNumber}");
        
    }
}

class Program
{
    static void Main(string[] args)
    {
        var p = new Person("omer","birgul");
        var s = new Student("duygu","er","12345");

        p.intro();
        s.intro();
    }
}
