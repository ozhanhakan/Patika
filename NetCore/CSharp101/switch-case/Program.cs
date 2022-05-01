using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("switch case");
            int month = DateTime.Now.Month+7;
            //expression
            switch (month)
            {
                case 1:
                System.Console.WriteLine("Ocak Ayındasınız"); break;
                case 2:
                System.Console.WriteLine("Şubat Ayındasınız"); break;
                case 3:
                System.Console.WriteLine("Mart Ayındasınız"); break;
                case 4:
                System.Console.WriteLine("Nisan Ayındasınız"); break;
                case 5:
                System.Console.WriteLine("Mayıs Ayındasınız"); break;
                case 6:
                System.Console.WriteLine("Haziran Ayındasınız"); break;
                case 7:
                System.Console.WriteLine("Temmuz Ayındasınız"); break;
                case 8:
                System.Console.WriteLine("Ağustos Ayındasınız"); break;
                case 9:
                System.Console.WriteLine("Eylül Ayındasınız"); break;
                case 10:
                System.Console.WriteLine("Ekim Ayındasınız"); break;
                case 11:
                System.Console.WriteLine("Kasım Ayındasınız"); break;
                case 12:
                System.Console.WriteLine("Aralık Ayındasınız"); break;

                default:
                System.Console.WriteLine("Yanlış veri girişi"); break;
            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                System.Console.WriteLine("Kış Mevsimindesiniz"); break;
                case 3:
                case 4:
                case 5:
                System.Console.WriteLine("İlk Bahar Mevsimindesiniz"); break;
                case 6:
                case 7:
                case 8:
                System.Console.WriteLine("Yaz Mevsimindesiniz"); break;
                case 9:
                case 10:
                case 11:
                System.Console.WriteLine("Güz Mevsimindesiniz"); break;
                
                default: 
                System.Console.WriteLine("Yanlış veri girişi"); break;

            }
        }
    }
}
