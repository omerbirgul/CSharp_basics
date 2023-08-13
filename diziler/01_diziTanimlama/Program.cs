using System;
var ogrenciler = new string[3];
var notlar = new int[3];

System.Console.Write("1. ogrenciyi girin:");
ogrenciler[0] = Console.ReadLine() ?? "";
System.Console.Write("1. ogrencinin notunu girin:");
notlar[0] = int.Parse(Console.ReadLine());

System.Console.Write("2. ogrenciyi girin:");
ogrenciler[1] = Console.ReadLine() ?? "";
System.Console.Write("2. ogrencinin notunu girin:");
notlar[1] = int.Parse(Console.ReadLine());

System.Console.Write("3. ogrenciyi girin:");
ogrenciler[2] = Console.ReadLine() ?? "";
System.Console.Write("3. ogrencinin notunu girin:");
notlar[2] = int.Parse(Console.ReadLine());

foreach(var ogrenci in ogrenciler[..2]){
    System.Console.WriteLine(ogrenci);
}
foreach(var not in notlar[..2]){
    System.Console.WriteLine(not);
}

var not1 = notlar[0];
var not2 = notlar[1];
var not3 = notlar[2];

var ortalama = (not1 + not2 + not3) / notlar.Length;

System.Console.WriteLine("ortalama: " +ortalama);
