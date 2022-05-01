using System;

namespace Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dizi Tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = { "kedi", "köpek", "Kuş", "Aslan" };
            int[] dizi;
            dizi = new int[5];

            //Dizilere değer atama ve erişim
            renkler[0] = "Mavi";
            dizi[3] = 10;
            System.Console.WriteLine(hayvanlar[1]);
            System.Console.WriteLine(renkler[0]);
            Console.WriteLine(dizi[3]);

            //Döngülerle dizi kullanımı
            //dizi boyutunun console üzerinden belirlenip, 
            //girilen n adet sayıları diziye aktarıp ortalamasını almak

            System.Console.WriteLine("Lütfen dizinin eleman sayısını giriniz");
            int diziUzunlugu = int.Parse(Console.ReadLine().Trim());
            int[] sayiDizisi = new int[diziUzunlugu];
            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.Write("Lütfen {0}. sayıyı giriniz ", i + 1);
                sayiDizisi[i] = int.Parse(Console.ReadLine().Trim());


            }

            int toplam = 0;
            foreach (var item in sayiDizisi)
            {

                toplam+=item;
            }

            System.Console.WriteLine("Ortalama: "+toplam/diziUzunlugu);
        }
    }
}
