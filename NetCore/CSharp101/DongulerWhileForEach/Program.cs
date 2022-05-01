using System;

namespace DongulerWhileForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            //While
            //console üzerinden girilen sayıya kadar ortalamayı hesapla

            Console.WriteLine("Lütfen Bir sayı giriniz!");
            int sayi = int.Parse(Console.ReadLine());
            int sayac =1 ;
            int toplam=0;
            while(sayac<=sayi){
                toplam+=sayac;
                sayac++;

            }
            Console.WriteLine("ortalama: "+toplam/sayi);

            //A'dan Z'ye tüm karakterleri yazdırmak
            char character ='a';
            while(character<='z'){
                System.Console.Write(character);
                character++;
            }
            System.Console.WriteLine();

            System.Console.WriteLine("****Foreach****");
            string[] arabalar = {"BMW", "Devrim","Mercedes", "TOGG"};
            foreach (var item in arabalar)
            {
                System.Console.WriteLine(item);
                
            }

        }
    }
}
