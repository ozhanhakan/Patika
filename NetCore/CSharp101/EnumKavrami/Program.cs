using System;

namespace EnumKavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Cuma);
            Console.WriteLine((int)Gunler.Cuma);
            int sıcaklık = 32;
            if (sıcaklık <= (int)HavaDurumu.Normal)
            {
                System.Console.WriteLine("Dışarıya çıkmak için Havanın ısınmasını bekleyelim");

            }
            else if (sıcaklık >= (int)HavaDurumu.Sıcak)
            {
                System.Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün!");
            }
            else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık < (int)HavaDurumu.ÇokSıcak)
            {
                System.Console.WriteLine("Hadi dışarıya çıkalım.");
            }
        }
    }
    enum Gunler
    {
        Pazartesi = 1,
        Salı,
        Çarşamba = 20,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu
    {
        Soğuk = 5,
        Normal = 20,
        Sıcak = 25,
        ÇokSıcak = 30
    }
}
