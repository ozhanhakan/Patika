using System;

namespace recursiveVeExtensionFonksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //recursive
            int result = 1;
            int pow = 4;
            for (int i = 1; i <= pow; i++)
            {
                result *= 3;
            }

            Console.WriteLine("3^4= " + result);


            Islemler instance = new();
            System.Console.WriteLine("recursive method: 3^4=  " + instance.Expo(3, 4));

            //Extension methodlar ve class lar static olmalı ki nesnesi olmadan erişme imkanı olsun.
            string ifade = "Hakan Özhan";
            System.Console.WriteLine(ifade.MakeUpperCase());
            System.Console.WriteLine(ifade.MakeLowerCase());
            bool sonuc = ifade.CheckSpaces();
            System.Console.WriteLine(sonuc);
            if (sonuc)
            {
                System.Console.WriteLine(ifade.RemoveWhiteSpaces());
            }

            int[] dizi = { 9, 3, 6, 2, 1, 5, 0 };
            dizi.SortArray();
            dizi.EkranaYazdir();
            System.Console.WriteLine();
            foreach (var item in dizi)
            {
                System.Console.WriteLine(item + ": " + item.CiftMi());
            }
            System.Console.WriteLine();

            foreach (var item in dizi)
            {
                System.Console.WriteLine(item + ": " + (item.CiftMi() ? "Çift" : "Tek"));
            }

            System.Console.WriteLine();
            System.Console.WriteLine(ifade.IlkKarakteriGetir());
        }
    }
    public class Islemler
    {
        public int Expo(int taban, int us)
        {
            if (us < 2)
                return taban;
            return Expo(taban, us - 1) * taban;
        }
        /*
        Expo(3,4)
        Expo(3,3)*3
        Expo(3,2)*3*3
        Expo(3,1)*3*3*3
        3        *3*3*3 = 81
        */
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi = param.Split(" ");
            return string.Join("", dizi);
        }
        public static string MakeUpperCase(this string param)
        {

            return param.ToUpper();
        }
        public static string MakeLowerCase(this string param)
        {

            return param.ToLower();
        }

        public static int[] SortArray(this int[] param)
        {
            Array.Sort(param);
            return param;

        }
        public static void EkranaYazdir(this int[] param)
        {
            System.Console.WriteLine();
            foreach (var item in param)
            {
                Console.Write(item);
            }
        }

        public static bool CiftMi(this int param)
        {

            return param % 2 == 0;
        }
        public static string IlkKarakteriGetir(this string param)
        {
            return param.Substring(0, 1);
        }
    }
}
