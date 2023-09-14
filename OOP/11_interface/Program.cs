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


class Teacher: Person{
    public string Branch { get; set; }

    public Teacher(string name, string surName, string branch):base(name,surName)
    {
        this.Branch = branch;
    }

    public void Teach(){
        System.Console.WriteLine("I'm teaching");
    }

    public override void intro()
    {
        System.Console.WriteLine($"name: {this.Name} surname: {this.SurName} branc: {this.Branch}");
        
    }
}


class Program
{
    static void Main(string[] args)
    {
        var p = new Person("omer","birgul");
        var s = new Student("duygu","er","12345");
        var t = new Teacher("Sevket","Cakir","Algorithm");

        t.intro();
        t.Teach();
        p.intro();
        s.intro();
    }
}
