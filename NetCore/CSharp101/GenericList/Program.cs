using System;
using System.Collections.Generic;
namespace GenericList
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            List<T> class
            //System.Collections.Generic
            //T-> object türündedir bir nesne alabilir. 
            
            */
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);

            List<string> renkListesi = new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Sarı");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Yeşil");

            //count
            System.Console.WriteLine(renkListesi.Count);
            System.Console.WriteLine(sayiListesi.Count);


            //for each ile elemanlara erişim
            foreach (var item in renkListesi)
            {
                System.Console.WriteLine(item);
            }

            foreach (var item in sayiListesi)
            {
                System.Console.WriteLine(item);
            }
            //list.foreach ile elemenlara erişim

            sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
            renkListesi.ForEach(sayi => System.Console.WriteLine(sayi));

            //listeden eleman çıkarma
            sayiListesi.Remove(4);//4 adlı elemanı listeden çıkar;
            renkListesi.Remove("Yeşil");

            renkListesi.ForEach(sayi => System.Console.WriteLine(sayi));
            sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));
            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);
            renkListesi.ForEach(sayi => System.Console.WriteLine(sayi));
            sayiListesi.ForEach(sayi => System.Console.WriteLine(sayi));

            //liste içerisinde arama
            if (sayiListesi.Contains(10))
                System.Console.WriteLine("10 bulundu");

            //eleman ile index'e erişme
            System.Console.WriteLine(renkListesi.BinarySearch("Sarı"));

            //Diziyi liste çevirme
            string[] hayvanlar = { "kedi", "köpek", "Kuş" };
            List<string> hayvanListesi = new List<string>(hayvanlar);
            //Listeyi temizlemek
            hayvanListesi.Clear();

            ///Liste içinde nesne tutmak
            List<Kullanicilar> kullaniciListesi = new List<Kullanicilar>();
            Kullanicilar kullanici1 = new Kullanicilar();
            kullanici1.Isim = "isim1";
            kullanici1.SoyIsim = "Soyisim1";
            kullanici1.Yas = 25;

            Kullanicilar kullanici2 = new Kullanicilar();
            kullanici2.Isim = "isim2";
            kullanici2.SoyIsim = "Soyisim2";
            kullanici2.Yas = 26;

            kullaniciListesi.Add(kullanici1);
            kullaniciListesi.Add(kullanici2);

            List<Kullanicilar> yeniListe = new List<Kullanicilar>();
            yeniListe.Add(new Kullanicilar()
            {
                Isim = "Yeniİsim1",
                SoyIsim = "YeniSoyİsim1",
                Yas = 27
            });
            System.Console.WriteLine("yeniListe listesi:  ");

            foreach (var item in yeniListe)
            {
                System.Console.WriteLine(item.Isim); ;
                System.Console.WriteLine(item.SoyIsim); ;
                System.Console.WriteLine(item.Yas); ;
            }
            yeniListe.Clear();
            System.Console.WriteLine("yeniListe listesine clear metodu uygulandı");

            foreach (var item in yeniListe)
            {
                System.Console.WriteLine(item.Isim); ;
                System.Console.WriteLine(item.SoyIsim); ;
                System.Console.WriteLine(item.Yas); ;
            }
            System.Console.WriteLine("kullanıcı listesi:  ");

            foreach (var item in kullaniciListesi)
            {
                System.Console.WriteLine(item.Isim); ;
                System.Console.WriteLine(item.SoyIsim); ;
                System.Console.WriteLine(item.Yas); ;
            }
            kullaniciListesi.Clear();
            System.Console.WriteLine("kullanıcı listesine clear metodu uygulandı");
            foreach (var item in kullaniciListesi)
            {
                System.Console.WriteLine(item.Isim); ;
                System.Console.WriteLine(item.SoyIsim); ;
                System.Console.WriteLine(item.Yas); ;
            }


        }
    }

    public class Kullanicilar
    {
        string isim;
        string soyIsim;
        int yas;

        public string Isim { get => isim; set => isim = value; }
        public string SoyIsim { get => soyIsim; set => soyIsim = value; }
        public int Yas { get => yas; set => yas = value; }
    }
}
