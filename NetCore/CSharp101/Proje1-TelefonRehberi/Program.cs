using System;
using System.Collections.Generic;

namespace Proje1_TelefonRehberi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            https://app.patika.dev/courses/csharp-101/19-proje-1
            Yeni bir console uygulaması açarak telefon rehberi uygulaması yazınız. 
            Uygulamada olması gereken özellikler aşağıdaki gibidir.
            Telefon Numarası Kaydet
            Telefon Numarası Sil
            Telefon Numarası Güncelle
            Rehber Listeleme (A-Z, Z-A seçimli)
            Rehberde Arama
            Açıklama:
            Başlangıç olarak 5 kişinin numarasını varsayılan olarak ekleyiniz.
            Uygulama ilk başladığında kullanıcıya yapmak istediği işlem seçtirilir.
                        */


            //refactoring yapılarak bunlar düzenlencek
            //ödevde ilerleme sağlanması için şimdiki tecrübeme göre programlıyorum

            Console.WriteLine("Telefon Rehberi Uygulamasına Hoşgeldiniz!");

            //1-5 arası programlar Rehber class'ı içindeki metodlar olarak yazıldı. 
            Rehber rehber1 = new Rehber();
            //kişi isim ve telefon bilgileri için yeni bir tip/class oluşturuldu. KisiKarti.cs
           

            string programDevam = "";
            while (programDevam != "exit")
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)  \nProgramdan Çıkış için 'exit' giriniz");
                System.Console.WriteLine("*******************************************");
                System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
                System.Console.WriteLine("(2) Varolan Numarayı Silmek");
                System.Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                System.Console.WriteLine("(4) Rehberi Listelemek");
                System.Console.WriteLine("(5) Rehberde Arama Yapmak");


                programDevam = Console.ReadLine().ToLower();
                // System.Console.WriteLine("Seçilen Program: " + programDevam);
                switch (programDevam)
                {
                    case "1":
                        rehber1.Program1();
                        break;
                    case "2":
                        rehber1.Program2();
                        break;
                    case "3":
                        rehber1.Program3();
                        break;
                    case "4":
                        rehber1.Program4();
                        break;
                    case "5":
                        rehber1.Program5();
                        break;
                    case "exit": break;
                    default:
                        System.Console.WriteLine("1-5 arası program seçiniz ya da exit ile çıkınız.");
                        break;
                }
            }

        }
    }


}