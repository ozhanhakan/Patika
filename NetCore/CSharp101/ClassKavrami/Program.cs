using System;

namespace ClassKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Erişim Belirleyici");
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

            Calisan calisan1=new Calisan();
            calisan1.Ad="Ayşe";
            calisan1.Soyad="Kara";
            calisan1.No=12345678;
            calisan1.Departman="İnsan Kaynakları";
            calisan1.CalisanBilgileri();
            System.Console.WriteLine("*********");
            Calisan calisan2=new Calisan();
            calisan2.Ad="Göktuğ";
            calisan2.Soyad="Balcı";
            calisan2.No=12345679;
            calisan2.Departman="Güvenlik";
            calisan2.CalisanBilgileri();
        }
    }
    class Calisan
    {
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri(){
            System.Console.WriteLine("Çalışan Adı:{0}",Ad);
            System.Console.WriteLine("Çalışan Soyadı:{0}",Soyad);
            System.Console.WriteLine("Çalışan Numarası:{0}",No);
            System.Console.WriteLine("Çalışan Departmanı:{0}",Departman);
        }

    }
}
