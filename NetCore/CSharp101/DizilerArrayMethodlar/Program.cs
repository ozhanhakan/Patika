using System;

namespace DizilerArrayMethodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayiDizisi = { 23, 12, 4, 86, 72, 3, 11, 17 };

            Console.WriteLine("Sırasız Dizi");
            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }
            Console.WriteLine("Sıralı Dizi");
            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

            //clear

            System.Console.WriteLine("Array Clear");
            Array.Clear(sayiDizisi, 2, 2);//2.indeksten itibareb iki elemanı 0 yapar
            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

            //reverse
            System.Console.WriteLine("Array Reverse");
            Array.Reverse(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }

            //indexOf
            System.Console.WriteLine("Array indexOf");
            
            System.Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize
            System.Console.WriteLine("Array resize");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8]=99;
            foreach (var item in sayiDizisi)
            {
                System.Console.WriteLine(item);
            }







        }
    }
}
