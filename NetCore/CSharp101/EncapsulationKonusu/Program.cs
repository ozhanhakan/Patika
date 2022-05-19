using System;

namespace EncapsulationKonusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenc1 = new Ogrenci("Elif Sare", "Özhan", 58, 1);
            Ogrenci ogrenc2 = new Ogrenci("Alparslan", "Özhan", 57, 2);
            ogrenc1.OgrenciBilgileriniGetir();
            ogrenc2.OgrenciBilgileriniGetir();
            ogrenc1.SinifAtlat();
            ogrenc1.OgrenciBilgileriniGetir();
            ogrenc2.SinifDusur();
            ogrenc2.SinifDusur();
            ogrenc2.SinifDusur();
            ogrenc2.OgrenciBilgileriniGetir();

        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif
        {
            get => sinif;
            set
            {
                if (value < 1)
                { System.Console.WriteLine("Sınıf en az 1 olabilir."); }

                else
                    sinif = value;
            }
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif = 0)
        {
            Isim = ısim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public void OgrenciBilgileriniGetir()
        {
            System.Console.WriteLine("*****Öğrenci Bilgileri*****");
            System.Console.WriteLine("Öğrenci Adı:{0}", this.Isim);
            System.Console.WriteLine("Öğrenci Soyadı:{0}", this.Soyisim);
            System.Console.WriteLine("Öğrenci No:{0}", this.OgrenciNo);
            System.Console.WriteLine("Öğrenci Sınıfı:{0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif++;

        }
        public void SinifDusur()
        {
            this.Sinif--;
        }

    }
}
