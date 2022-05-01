using System;

namespace DongulerForLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ekrandan girlien sayıya kadar tek sayıları yazdıralım


            Console.WriteLine("Lütfen Bir sayı giriniz!");
            int sayac = int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i % 2 == 1)
                    System.Console.WriteLine(i);
            }

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerindeki toplamı
            int tekToplam = 0;
            int ciftToplam = 0;
            int length = 1000;
            for (int i = 1; i <= length; i++)
            {
                if (i % 2 == 0)
                    ciftToplam += i;
                else
                    tekToplam += i;

            }
            System.Console.WriteLine("Tek toplam: " + tekToplam);
            System.Console.WriteLine("Çift toplam: " + ciftToplam);

            //break continue
            for (int i = 1; i <= sayac; i++)
            {
                if (i == 10)
                    break;
                if ( i % 3 == 0)
                    continue;
                if (i % 2 == 1) // 3'e bölünmeyen tek sayıları yazacak
                    System.Console.WriteLine(i);
            }
        }

    }
}
