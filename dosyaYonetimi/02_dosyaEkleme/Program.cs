using System.IO;
// using(StreamWriter sw = File.CreateText("deneme.txt")){
//     sw.WriteLine("merhaba");
//     sw.WriteLine("dünya");
//     sw.WriteLine("deneme");
// }

// using(StreamWriter sw = File.AppendText("deneme.txt")){
//     sw.WriteLine("selam");
//     sw.WriteLine("dünya");
//     sw.WriteLine("çikolata");
// }

File.WriteAllText("deneme.txt","btk");
File.AppendAllText("deneme.txt","eğitim");

using(StreamReader sr = File.OpenText("deneme.txt")){
    var s = "";
    while((s = sr.ReadLine()) != null){
        System.Console.WriteLine(s);
    }
}
