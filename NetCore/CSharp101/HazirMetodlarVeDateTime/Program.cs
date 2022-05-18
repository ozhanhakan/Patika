using System;

namespace HazirMetodlarVeDateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Date);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);
            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());
            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());
            Console.WriteLine(DateTime.Now.AddDays(2));
            Console.WriteLine(DateTime.Now.AddHours(2));
            Console.WriteLine(DateTime.Now.AddMinutes(2));
            Console.WriteLine(DateTime.Now.AddSeconds(2));
            Console.WriteLine(DateTime.Now.AddMonths(2));
            Console.WriteLine(DateTime.Now.AddMilliseconds(2));

            System.Console.WriteLine("DateTime Format");
            System.Console.WriteLine(DateTime.Now.ToString("dd"));//24saat
            System.Console.WriteLine(DateTime.Now.ToString("ddd"));//Çar
            System.Console.WriteLine(DateTime.Now.ToString("dddd"));//Çarşamba
            System.Console.WriteLine(DateTime.Now.ToString("MM"));//05
            System.Console.WriteLine(DateTime.Now.ToString("MMM"));//May
            System.Console.WriteLine(DateTime.Now.ToString("MMMM"));//Mayıs
            System.Console.WriteLine(DateTime.Now.ToString("YY"));//Yıl son iki hane 22
            System.Console.WriteLine(DateTime.Now.ToString("YYY"));//2022

            System.Console.WriteLine("Math Kütüphanesi");
            System.Console.WriteLine(Math.Abs(-25));
            System.Console.WriteLine(Math.Sin(90));
            System.Console.WriteLine(Math.Cos(0));
            System.Console.WriteLine(Math.Ceiling(0.8));
            System.Console.WriteLine(Math.Floor(0.8));
            System.Console.WriteLine(Math.Round(0.8));

            System.Console.WriteLine(Math.Max(2,6));
            System.Console.WriteLine(Math.Min(2,6));
            System.Console.WriteLine(Math.Pow(2,3)); //2 üzeri 3
            System.Console.WriteLine(Math.Sqrt(9)); //karekök
            System.Console.WriteLine(Math.Log(9));//e tabanındaki logaritma
            System.Console.WriteLine(Math.Exp(9));//e üssü
            System.Console.WriteLine(Math.Log10(100));//10 tabanında log






        }
    }
}
