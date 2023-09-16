namespace _03_uygulamaExceptionHandling;

class Program
{
    static void Main(string[] args)
    {
        // 1-) 1,2,5a,10b,abc,10,50  liste içerisindeki sayısal değerleri bul.

        var liste = new List<string>(){
            "1","2","5a","10b","abc","10","50"
        };

        foreach(var i in liste){
            try
            {
                int a = int.Parse(i);
                Console.WriteLine(a);
            }
            catch (Exception )
            {
                continue;
            }
        }
    }
}
