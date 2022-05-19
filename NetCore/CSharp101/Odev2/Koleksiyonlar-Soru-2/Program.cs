using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koleksiyonlar-Soru-2: 20 adet sayı listelenecek");
            /*
            Koleksiyonlarla ilgili algoritma soruları
Ödev - 2
Aşağıdaki 3 soruyu ayrı ayrı console uygulamaları açarak yazınız. 
Koleksiyonlar-Soru-1, 
Koleksiyonlar-Soru-2, 
Koleksiyonlar-Soru-3 
isimlerini kullanınız.

Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve 
asal olmayan olarak 2 ayrı listeye atın. 
(ArrayList sınıfını kullanara yazınız.)
Negatif ve numeric olmayan girişleri engelleyin.
Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.
Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve 
en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve 
bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. 
(Array sınıfını kullanarak yazınız.)
Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi 
içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            */

            //asal ve asal olmayan iki Array List oluşturulur
            ArrayList enBuyuk3 = new ArrayList();
            ArrayList enKucuk3 = new ArrayList();
            ArrayList girilenSayilar = new ArrayList();
            //klavyeden sadece 20 sayı kabul edecek

            int limit = 20;
            int adet = limit;
            double enBuyuk3Ortalama = 0; ;
            double enKucuk3Ortalama = 0;
            double ortalamaToplami = 0;

            int girilenSayi;
            while (adet > 0)
            {
                System.Console.WriteLine((limit - adet + 1) + ".  sayıyı giriniz: ");

                try
                {

                    girilenSayi = Convert.ToInt32(Console.ReadLine());
                    girilenSayilar.Add(girilenSayi);



                }
                catch (System.Exception e)
                {

                    System.Console.WriteLine("Lütfen Dikkat ediniz, sadece tam sayı giriniz:");
                    adet++;
                }

                adet--;

            }
            System.Console.WriteLine("sayi listesinin elemanlarını küçükten büyüğe sıralanması.");
            foreach (var item in girilenSayilar)
            {
                System.Console.WriteLine(item);
            }
            girilenSayilar.Sort(); // küçükten büyüğe sıralama
            //ilk 3 tanesini aktar,
            for (int i = 0; i < 3; i++)
            {
                enKucuk3.Add(girilenSayilar[i]);
            }

            girilenSayilar.Reverse();// büyükten küçüğe sıralar
            for (int i = 0; i < 3; i++)
            {
                enBuyuk3.Add(girilenSayilar[i]);
            }

            // en küçük üç
            System.Console.WriteLine("en küçük üç");

            System.Console.WriteLine("en küçük 3 sayı adedi: " + enKucuk3.Count);
            foreach (var item in enKucuk3)
            {
                System.Console.WriteLine(item);
            }
            foreach (var item in enKucuk3)
            {
                enKucuk3Ortalama += Convert.ToDouble(item);
            }
            enKucuk3Ortalama /= enKucuk3.Count;
            System.Console.WriteLine("en küçük 3 sayı ortalaması: " + enKucuk3Ortalama);


            System.Console.WriteLine("en büyük üç");
            foreach (var item in enBuyuk3)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("en büyük 3 sayı adedi: " + enBuyuk3.Count);

            foreach (var item in enBuyuk3)
            {
                enBuyuk3Ortalama += Convert.ToDouble(item);
            }
            enBuyuk3Ortalama /= enBuyuk3.Count;
            System.Console.WriteLine("en büyük 3 sayı ortalaması: " + enBuyuk3Ortalama);
            ortalamaToplami = enKucuk3Ortalama + enBuyuk3Ortalama;
            System.Console.WriteLine(" ortalamaların toplamı: " + ortalamaToplami);


        }

    }
}
