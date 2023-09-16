namespace _03_uygulamaExceptionHandling;

class Program
{


    static void Main(string[] args)
    {
        // 1-) 1,2,5a,10b,abc,10,50  liste içerisindeki sayısal değerleri bul.

        // var liste = new List<string>(){
        //     "1","2","5a","10b","abc","10","50"
        // };

        // foreach(var i in liste){
        //     try
        //     {
        //         int a = int.Parse(i);
        //         Console.WriteLine(a);
        //     }
        //     catch (Exception )
        //     {
        //         continue;
        //     }
        // }





        // 2-) kullanıcı q değerini girmedikçe aldığınız her değerin sayısal olup olmadığını kontrol edin aksi halde hata mesaı verin

        // while (true)
        // {
        //     System.Console.Write("Değer girin: ");
        //     var deger = Console.ReadLine();
        //     if (deger == "q"){

        //         System.Console.WriteLine("çıkıldı");
        //         break;
        //     }
        //     try
        //     {
        //         int sayi = int.Parse(deger);
        //         System.Console.WriteLine($"girdiğiniz değer: {sayi}");
        //     }
        //     catch (System.Exception e)
        //     {
        //         System.Console.WriteLine("geçersiz sayı");
        //         continue;
        //     }

        // }




        // 3-) Girilen parola içinde türkçe karakter araması yapınız.

        Console.Write("parola: ");
            string parola = Console.ReadLine();

            try
            {
                CheckPassword(parola);
            }
            catch (Exception ex)
            {
                Console.Write(ex.Message);
            }



        static void CheckPassword(string parola)
        {
            string turkce_karakterler = "ğ,Ğ,ç,Ç,ş,Ş,ü,Ü,ö,Ö,ı,İ";

            foreach (var karakter in parola)
            {
                if (turkce_karakterler.IndexOf(karakter)>-1)
                    throw new Exception("Parola türkçe karakter içeremez");
            }
            Console.Write("geçerli parola");
        }

    }





}
