using System;
using System.Collections;
using System.Collections.Generic;

namespace ArrayListKonusu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array List");
            ArrayList liste = new ArrayList();
            ArrayList liste2 = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(true);
            liste.Add('A');

            //içerisindeki verilere erişim
            System.Console.WriteLine(liste[1]);

            foreach (var item in liste)
                System.Console.WriteLine(item);

            //AddRange birden fazla elemanı ekleme
            System.Console.WriteLine("AddRange");
            string[] renkler = { "kırmızı", "sarı", "yeşil" };
            List<int> sayilar = new List<int>() { 1, 8, 3, 7, 9, 92, 5 };
            liste.AddRange(renkler);
            liste.AddRange(sayilar);
            liste2.AddRange(sayilar);

            foreach (var item in liste)
                System.Console.WriteLine(item);

            //sort
            System.Console.WriteLine("*******Sort*******");
            // liste.Sort();//compile zamanda hata vermedi fakat runtime zamanında hata verdi.
            /*
            aynı tipteki elemanlar sıralanır/compare
            Özel durum oluştu: CLR/System.InvalidOperationException
            'System.InvalidOperationException' türünde bir yakalanamayan özel durum, System.Private.CoreLib.dll öğesinde oluştu: 'Failed to compare two elements in the array.'
            İç özel durumlar bulundu, daha fazla ayrıntı için değişkenler penceresinden $exception'a bakın.
            En içteki özel durum 	 System.ArgumentException : Object must be of type Int32.
            */
            liste2.Sort();
            foreach (var item in liste2)
                System.Console.WriteLine(item);

            //Binary Search, sıralı bir liste üzerinden çalıştırılır
            System.Console.WriteLine("*******Binary Search*******");
            System.Console.WriteLine(liste2.BinarySearch(9));
            //System.Console.WriteLine(liste.BinarySearch(9)); hata veriyor
            System.Console.WriteLine("reverse");
            liste2.Reverse();
            foreach (var item in liste2)
                System.Console.WriteLine(item);

                liste.Clear();
                foreach (var item in liste)
                System.Console.WriteLine(item);





        }
    }
}
