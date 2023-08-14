string[] ogrenciler = {"Omer","Duygu","Ali"};
int[,] notlar = new int[3,3];

notlar[0,0] = 50;
notlar[0,1] = 60;
notlar[0,2] = 70;

notlar[1,0] = 80;
notlar[1,1] = 90;
notlar[1,2] = 30;

notlar[2,0] = 50;
notlar[2,1] = 60;
notlar[2,2] = 70;

var ortalama1 = (notlar[0,0] + notlar[0,1] + notlar[0,2]) / 3;
var ortalama2 = (notlar[1,0] + notlar[1,1] + notlar[1,2]) / 3;
var ortalama3 = (notlar[2,0] + notlar[2,1] + notlar[2,2]) / 3;

System.Console.WriteLine($"{ogrenciler[0]} isimli ogrencinin not ortalamasi: {ortalama1}");
System.Console.WriteLine($"{ogrenciler[1]} isimli ogrencinin not ortalamasi: {ortalama2}");
System.Console.WriteLine($"{ogrenciler[2]} isimli ogrencinin not ortalamasi: {ortalama3}");