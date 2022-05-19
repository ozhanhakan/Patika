using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Koleksiyonlar-Soru-3: cümledeki sesli harfler listelenecek");
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

            string girilenCumle;
            ArrayList sesliHarfler = new ArrayList() { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            ArrayList cumledekiSesliHarfler = new ArrayList();
            ArrayList cumledekiTumKarakterler = new ArrayList();


            System.Console.WriteLine("Bir cümle giriniz; ");

            girilenCumle = Console.ReadLine();
            foreach (var item in girilenCumle)
            {
                cumledekiTumKarakterler.Add(item);
            }


            System.Console.WriteLine("girilen cümledeki karakter sayısı: " + cumledekiTumKarakterler.Count);


            foreach (var item in cumledekiTumKarakterler)
            {
                if (sesliHarfler.Contains(item) && !cumledekiSesliHarfler.Contains(item))
                    cumledekiSesliHarfler.Add(item);
            }


            foreach (var item in cumledekiSesliHarfler)
            {
                System.Console.Write(item + ", ");
            }

            cumledekiSesliHarfler.Sort();
            System.Console.WriteLine();
            System.Console.WriteLine("sort metodu sonrası sıralama:");
            foreach (var item in cumledekiSesliHarfler)
            {
                System.Console.Write(item + ", ");
            }


        }

    }
}
