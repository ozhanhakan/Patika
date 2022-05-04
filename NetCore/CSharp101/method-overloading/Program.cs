using System;

namespace method_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999";
            bool sonuc = int.TryParse(sayi, out int outSayi);
            if (sonuc)
            {
                Console.WriteLine("Başarılı!");
                Console.WriteLine(outSayi);

            }
            else
            {
                Console.WriteLine("Başarısız!");

            }

            Metodlar instance = new Metodlar();
            instance.Topla(2, 3, out int toplamSonucu);
            System.Console.WriteLine(toplamSonucu);

            //Metod aşırı yükleme, imzaları değiştirerek aynı metodu farklı parametrelerle çapırma işlemi
            int ifade = 999;
            instance.EkranaYazdir(Convert.ToString(ifade));
            instance.EkranaYazdir(ifade);
            instance.EkranaYazdir("Hakan", " Özhan");

        }
    }

    class Metodlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        }

        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine(veri);
        }
        public void EkranaYazdir(int veri)
        {
            System.Console.WriteLine(veri);
        }
        public void EkranaYazdir(string veri1, string veri2)
        {
            System.Console.WriteLine(veri1 + veri2);
        }
    }
}
