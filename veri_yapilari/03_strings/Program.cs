namespace _03_strings;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("name: ");
        string name = Console.ReadLine();

        Console.Write("surname: ");
        string surname = Console.ReadLine();

        Console.Write("age: ");
        int age = int.Parse(Console.ReadLine());


        // string name = "Ömerrrrr";
        // string surname= "Birgül";
        // int age = 15;

        // string str = "My name is " + name + " " + surname + " I'am  " + age + " years old";
        string str = $"My name is {name} {surname}. I am {age} years old.";

        System.Console.WriteLine(str);
    }
}
