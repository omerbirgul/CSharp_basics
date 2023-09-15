using System.Collections.Generic;
namespace _03_DictionaryKeyValue;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<int,string> plakalar = new Dictionary<int, string>();

        plakalar.Add(34,"istanbul");
        plakalar.Add(45,"manisa");
        plakalar.Add(42,"konya");


        Dictionary<int,string> sayilar = new Dictionary<int, string>()
        {
            {1,"bir"},
            {2,"iki"},
            {3,"uc"},

        };

        // foreach(KeyValuePair<int,string> plaka in plakalar){
        //     System.Console.WriteLine($"{plaka.Key} {plaka.Value}");
        // }

        for(int i = 0; i < plakalar.Count; i++){
            System.Console.WriteLine($"{plakalar.Keys.ElementAt(i)}  {plakalar[plakalar.Keys.ElementAt(i)]}");
        }

        System.Console.WriteLine(plakalar.Contains(new KeyValuePair<int,string>(34,"istanbul")));
    }
}
