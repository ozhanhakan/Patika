using System;

namespace KurucuMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Yapıcı/Kurucu Metodlar Constructor");
            /*
                Söz dizimi
                Class SinifAdi
                {

                    [Erişim Belirleyici] [Veri tipi] ÖzellikAdi;
                    [Erişim Belirleyici] [Geri Dönüş tipi] MetodAdı(Parametre Listesi){
                        metot komutları
                    }

                }

                * Private
                * Public
                * Internal
                * Protected
            */
            System.Console.WriteLine("Çalışan 1");

            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 12345678;
            calisan1.Departman = "İnsan Kaynakları";
            calisan1.CalisanBilgileri();
            System.Console.WriteLine("*********");
            System.Console.WriteLine("Çalışan 2");

            Calisan calisan2 = new Calisan();
            calisan2.Ad = "Göktuğ";
            calisan2.Soyad = "Balcı";
            calisan2.No = 12345679;
            calisan2.Departman = "Güvenlik";
            calisan2.CalisanBilgileri();
            System.Console.WriteLine("Çalışan 3");

            Calisan calisan3 = new Calisan("Hakan", "Özhan", 58, "Yazılım");
            calisan3.CalisanBilgileri();
            System.Console.WriteLine("Çalışan 4");
            Calisan calisan4 = new Calisan("Fatma", "Özhan");
            calisan4.CalisanBilgileri();
        }
    }
    class Calisan
    {
        //constructor sınıf adı ile aynı olur, geri dönüş tipi yoktur.
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public Calisan(string ad, string soyad, int no, string departman)
        {
            this.Ad = ad;
            this.Soyad = soyad;
            this.No = no;
            this.Departman = departman;

        }
        public Calisan(string ad, string soyad)
        {
            this.Ad = ad;
            this.Soyad = soyad;


        }
        public Calisan()
        {

        }
        public void CalisanBilgileri()
        {
            System.Console.WriteLine("Çalışan Adı:{0}", Ad);
            System.Console.WriteLine("Çalışan Soyadı:{0}", Soyad);
            System.Console.WriteLine("Çalışan Numarası:{0}", No);
            System.Console.WriteLine("Çalışan Departmanı:{0}", Departman);
        }

    }
}
