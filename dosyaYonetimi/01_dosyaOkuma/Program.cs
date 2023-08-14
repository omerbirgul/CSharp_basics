using System.IO;
StreamReader sr = File.OpenText("deneme.txt");
var s = "";

while((s = sr.ReadLine()) != null){
    System.Console.WriteLine(s);
}

System.Console.WriteLine("**************************************");
System.Console.WriteLine("**************************************");

string sonuc = File.ReadAllText("deneme.txt");
System.Console.WriteLine(sonuc);

System.Console.WriteLine("**************************************");
System.Console.WriteLine("**************************************");

string[] sonuc2 = File.ReadAllLines("deneme.txt");
System.Console.WriteLine(sonuc2[0]);
System.Console.WriteLine(sonuc2[3]);