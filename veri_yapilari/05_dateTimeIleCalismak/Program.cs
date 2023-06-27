namespace _05_dateTimeIleCalismak;

class Program
{
    static void Main(string[] args)
    {
    string[] aylar = {"ocak","şubat","mart","nisan","mayıs","haziran","temmuz","ağustos","eylül","ekim","kasım","aralık"};
    DateTime simdi = DateTime.Now;

    DateTime dt = new DateTime(1999,9,16,9,15,1);

    var fark = simdi - dt;
    System.Console.WriteLine(fark);

    // System.Console.WriteLine(simdi.ToString("d"));
    // System.Console.WriteLine(simdi.ToString("D"));
    // System.Console.WriteLine(simdi.ToString("F"));
    // System.Console.WriteLine(simdi.ToString("M"));
    // System.Console.WriteLine(simdi.ToString("t"));
    // System.Console.WriteLine(simdi.ToString("T"));
    // System.Console.WriteLine(simdi.ToString("Y"));

    System.Console.WriteLine(simdi.ToString("hh-mm-ss"));
    System.Console.WriteLine(simdi.ToString("ddd MMM %d, yyyy"));
    }
}
