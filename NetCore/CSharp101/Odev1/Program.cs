using System;

namespace Odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Ödev 1 - https://app.patika.dev/courses/csharp-101/12-odev-1
            
            */
            Odevler1 programlar = new Odevler1();

            string programDevam = "";
            while (programDevam != "exit")
            {
                Console.WriteLine("Ödev 1 için 1-4 arası 4 alt programdan birini seçiniz: \nProgramdan Çıkış için 'exit' giriniz");
                System.Console.WriteLine("1. pozitif bir sayı giriniz(n)");
                System.Console.WriteLine("  Bu n adet pozitif sayıyı giriniz.");
                System.Console.WriteLine("  Girmiş olduğu sayılardan çift olanlar:");
                System.Console.WriteLine("2. Pozitif iki sayı giriniz (n, m).");
                System.Console.WriteLine("  n adet pozitif sayı giriniz. ");
                System.Console.WriteLine("  Girilen sayılardan m'e eşit yada tam bölünenleri:");
                System.Console.WriteLine("3.pozitif bir sayı giriniz(n)");
                System.Console.WriteLine("   n adet kelime giriniz. ");
                System.Console.WriteLine("  kelimelerin sondan başa doğru listesi:");
                System.Console.WriteLine("4. bir cümle yazınız.");
                System.Console.WriteLine("  Cümledeki toplam kelime ve harf sayısı: ");

                programDevam = Console.ReadLine().ToLower();
                // System.Console.WriteLine("Seçilen Program: " + programDevam);
                switch (programDevam)
                {
                    case "1":
                        programlar.Program1();
                        break;
                    case "2":
                        programlar.Program2();
                        break;
                    case "3":
                        programlar.Program3();
                        break;
                    case "4":
                        programlar.Program4();
                        break;
                    case "exit": break;
                    default:
                        System.Console.WriteLine("1-4 arası program seçiniz ya da exit ile çıkınız.");
                        break;
                }
            }
        }


    }

    public class Odevler1
    {
        public void Program1()
        {
            System.Console.WriteLine("1. Program Seçildi");
            System.Console.WriteLine("Pozitif bir sayı giriniz: ");
            System.Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(n + " adet pozitif sayı girişi yapınız.");
            int tekrar = n;
            int[] nSayi = new int[n];
            for (int i = 0; i < n; i++)
            {
                System.Console.Write(i + 1 + ". sayıyı giriniz :");
                nSayi[i] = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine();
            }
            System.Console.Write("giriş yapılan sayılar: " + n + " adet;\n");
            foreach (var item in nSayi)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Girmiş olduğu sayılardan çift olanlar: ");
            foreach (var item in nSayi)
            {

                if (item % 2 == 0)
                    System.Console.WriteLine(item);
            }
        }
        public void Program2()
        {
            System.Console.WriteLine("2. Program Seçildi");
            System.Console.WriteLine("Pozitif iki sayı giriniz (n, m)");
            System.Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            System.Console.Write("m: ");
            int m = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(n + " adet pozitif sayı girişi yapınız.");
            int tekrar = n;
            int[] nSayi = new int[n];
            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine(i + 1 + ". sayıyı giriniz.");
                nSayi[i] = Convert.ToInt32(Console.ReadLine());
            }
            System.Console.Write("giriş yapılan sayılar: " + n + " adet;\n");
            foreach (var item in nSayi)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Girmiş olduğu sayılardan " + m + "'e tam bölünenler");
            foreach (var item in nSayi)
            {

                if (item % m == 0)
                    System.Console.WriteLine(item);
            }
        }
        public void Program3()
        {
            System.Console.WriteLine("3. Program Seçildi");
            System.Console.WriteLine("Pozitif bir sayı giriniz: ");
            System.Console.Write("n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine(n + " adet kelime  girişi yapınız.");
            int tekrar = n;
            string[] nKelime = new string[n];
            for (int i = 0; i < n; i++)
            {
                System.Console.Write(i + 1 + ". kelimeyi giriniz :");
                nKelime[i] = (Console.ReadLine());
                System.Console.WriteLine();
            }
            System.Console.Write("giriş yapılan kelimeler: " + n + " adet;\n");
            foreach (var item in nKelime)
            {
                System.Console.WriteLine(item);
            }

            System.Console.WriteLine("Girmiş olduğunuz kelimelerin sondan başa sırası: ");
            Array.Reverse(nKelime);
            foreach (var item in nKelime)
            {
                System.Console.WriteLine(item);
            }
        }
        public void Program4()
        {
            System.Console.WriteLine("4. Program Seçildi");
            System.Console.WriteLine("Bir cümle giriniz: ");

            string cumle = Console.ReadLine();


            System.Console.WriteLine("giriş yapılan cümledeki kelime sayısı:");
            string[] kelimeler = cumle.Split(' ');
            System.Console.WriteLine(kelimeler.Length);

            System.Console.WriteLine("giriş yapılan cümledeki harf sayısı:");
            string bitisikKelimeler = string.Join("", kelimeler);

            System.Console.WriteLine(bitisikKelimeler.Length);

        }
    }

}
