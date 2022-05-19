using System;

namespace StaticSinifVeUyeler
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan0 = new Calisan();
            Console.WriteLine("Çalışan sayısı{0}: ", Calisan.CalisanSayisi);
            Calisan calisan1 = new Calisan("Hakan", "Özhan", "Yazılım");
            Console.WriteLine("Çalışan sayısı{0}: ", Calisan.CalisanSayisi);
            Calisan calisan2 = new Calisan("Fatma", "Özhan", "Satın Alma");
            Console.WriteLine("Çalışan sayısı{0}: ", Calisan.CalisanSayisi);
            Calisan calisan3 = new Calisan("Elif Sare", "Özhan", "Öğrenci");
            Console.WriteLine("Çalışan sayısı{0}: ", Calisan.CalisanSayisi);

            System.Console.WriteLine("static sınıfın nesnesi oluşturulamaz, sınıf üzerinden erişilir");
            System.Console.WriteLine(Islemler.Topla(10, 20));
            System.Console.WriteLine(Islemler.Cikar(10, 20));


        }
    }
    class Calisan
    {
        private static int calisanSayisi;
        private string Isim;
        private string Soyisim;
        private string Departman;

        //static kurucu da yapılabilir, erişim belirteci de olmaz.
        static Calisan()
        {

            calisanSayisi = 0;
            System.Console.WriteLine("static constructor çalıştı.");

        }
        public Calisan(string isim, string soyisim, string departman)
        {

            Isim = isim;
            Soyisim = soyisim;
            Departman = departman;
            calisanSayisi++;
            System.Console.WriteLine("public parametreli constructor çalıştı.");
        }
        public Calisan()
        {
            System.Console.WriteLine("public boş constructor çalıştı");
        }

        public static int CalisanSayisi { get => calisanSayisi; }
    }

    static class Islemler
    {
        public static long Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
        public static long Cikar(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }
    }

}
