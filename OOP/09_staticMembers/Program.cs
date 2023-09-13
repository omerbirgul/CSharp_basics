namespace _09_staticMembers;


class Student{
    
    public string Name { get; set; }
    public int StudentNumber { get; set; }
    public static string School ="my school";
    public static string Adress = "my school adress";


    public Student(string name, int studentnumber){
        this.Name = name;
        this.StudentNumber = studentnumber;
    }

    public void DisplayStudentDetails(){
        System.Console.WriteLine($"name: {this.Name} -- number: {this.StudentNumber}");
    }

    public static void DisplaySchoolDetails(){
        System.Console.WriteLine($"school name: {School} -- adress:{Adress}");
    }
}

static class HelperMethods{
    public static string KarakterDuzelt(string str){
        return str
                    .Replace("ö","o")
                    .Replace("ü","u")
                    .Replace("ç","c")
                    .Replace("ğ","g")
                    .Replace("ı","i")
                    .Replace(" ","-");
    }
}

class Program
{
    static void Main(string[] args)
    {
        var s1 = new Student("omer", 100);
        var s2 = new Student("duygu", 200);
        var s3 = new Student("doruk", 300);

        Student.DisplaySchoolDetails();


        var str = "ölçme ve değerlendirme sınavı ";
        var result = HelperMethods.KarakterDuzelt(str);
        System.Console.WriteLine(result);

        

    }
}
