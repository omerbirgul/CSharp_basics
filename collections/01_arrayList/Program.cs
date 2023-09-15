using System.Collections;
namespace _01_arrayList;

class Program
{
    static void Main(string[] args)
    {
        ArrayList myList = new ArrayList();
        myList.Add(10);
        myList.Add("10");
        myList.Add("abc");
        myList.Add(10.5);
        myList.Add(true);


        ArrayList myList2 = new ArrayList() {"***",25,18.4,"false"};

        myList.Insert(1,8); // verilen index deki değişkeni değiştirir.
        myList.InsertRange(1,myList2); // verilen index den itibaren başka bir listeyi ekler.

        foreach(var i in myList){
            System.Console.WriteLine(i);
        }
    }
}
