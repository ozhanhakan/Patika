using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koleksiyonlar-Soru-1: 20 adet Asal ve Asal olmayan sayılar listelenecek");
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
en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)
Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi 
içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.
            */

            //asal ve asal olmayan iki Array List oluşturulur
            ArrayList asal = new ArrayList();
            ArrayList asalOlmayan = new ArrayList();
            //klavyeden sadece 20 pozitif sayıyı kabul edecek
            int adet = 20;
            int girilenSayi;
            while (adet > 0)
            {
                System.Console.WriteLine((20 - adet + 1) + ". pozitif sayıyı giriniz: ");

                try
                {
                    while (true)
                    {
                        girilenSayi = Convert.ToInt32(Console.ReadLine());
                        if (girilenSayi > 0)
                        {

                            if (isPrime(girilenSayi))
                                asal.Add(girilenSayi);

                            else
                                asalOlmayan.Add(girilenSayi);
                            break;
                        }
                        System.Console.WriteLine((20 - adet + 1) + ". pozitif sayıyı giriniz: ");

                    }
                }
                catch (System.Exception e)
                {

                    System.Console.WriteLine("Lütfen Dikkat ediniz, sadece pozitif tam sayı giriniz:");
                    adet++;
                }

                adet--;

            }
            System.Console.WriteLine("Her bir dizinin elemanlarını büyükten küçüğe sıralanması.");
            System.Console.WriteLine("Asal liste");
            asal.Sort();
            asal.Reverse();
            System.Console.WriteLine("Asal sayı adedi: " + asal.Count);
            double ortalamaAsal=0;
            foreach (var item in asal)
            {
                ortalamaAsal+=Convert.ToDouble(item);
            }
            ortalamaAsal /=asal.Count;
            System.Console.WriteLine("Asal sayı ortalaması: " + ortalamaAsal);

            foreach (var item in asal)
            {
                System.Console.WriteLine(item);
            }
            System.Console.WriteLine("Asal Olmayan liste");
            asalOlmayan.Sort();
            asalOlmayan.Reverse();
            System.Console.WriteLine("Asal olmayan sayı adedi: " + asalOlmayan.Count);
            double ortalamaAsalOlmayan=0;
            foreach (var item in asalOlmayan)
            {
                ortalamaAsalOlmayan+=Convert.ToDouble(item);
            }
            ortalamaAsalOlmayan /=asalOlmayan.Count;
            System.Console.WriteLine("Asal olmayan sayı listesi ortalaması: " + ortalamaAsalOlmayan);

            foreach (var item in asalOlmayan)
            {
                System.Console.WriteLine(item);
            }

        }

        static bool isPrime(int n)
        {
            //ilk temel bilgilerin kontrolü
            if (n < 2) return false; // en küçük asal sayı 2 dir.
            if (n == 2) return true; // 2 de bir asal sayıdır
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0) return false;
                if (i * i > n) return true;
            }
            return false;
            // 2 dışındaki n sayısı kendinden başka bir sayıya bölünüyorsa asal değildir.

            // bir sayının kareköküne kadar hiç böleni yoksa o sayı asal sayıdır.
            // yani n-2'e kadar kontrol etmeye gerek yok.
            // if (i > n-2) return true;

        }
    }
}
