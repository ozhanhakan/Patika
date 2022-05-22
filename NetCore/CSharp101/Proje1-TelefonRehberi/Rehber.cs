using System;
using System.Collections.Generic;

namespace Proje1_TelefonRehberi
{
    public class Rehber
    {
        //KisiKart class'ı kişi bilgilerini tutar
        //Bir Generic List'e bu kartlar ekleniyor.
        List<KisiKarti> kisiKartiRehberi = new List<KisiKarti>();
      
       public Rehber(){
           kisiKartiRehberi.Add(new KisiKarti("Acil","Yardım","112"));
           kisiKartiRehberi.Add(new KisiKarti("Yangın","Yardım","110"));
           kisiKartiRehberi.Add(new KisiKarti("Polis","Yardım","155"));
           kisiKartiRehberi.Add(new KisiKarti("Hastane","Randevu","182"));
           kisiKartiRehberi.Add(new KisiKarti("Belediye","İLetişim","153"));
       }

        public void Program1()//tamamlandı
        {
            /*
            Lütfen isim giriniz             : 
            Lütfen soyisim giriniz          :
            Lütfen telefon numarası giriniz :
            */
            // kişi bilgileri alınarak bir karta elınır.
            KisiKarti kart1 = new();
            System.Console.WriteLine("(1) Yeni Numara Kaydetmek");
            System.Console.WriteLine("Lütfen isim giriniz              : ");
            kart1.Isim = Console.ReadLine();
            System.Console.WriteLine("Lütfen soyisim giriniz           : ");
            kart1.Soyisim = Console.ReadLine();
            System.Console.WriteLine("Lütfen telefon numarası giriniz  : ");
            kart1.TelefonNumarasi = Console.ReadLine();



            //kart listeye eklenir.

            kisiKartiRehberi.Add(kart1);
            //eklenen kartı ekrana yazdır.
            System.Console.WriteLine("Eklenen son kart bilgisi");
            System.Console.WriteLine(kisiKartiRehberi[kisiKartiRehberi.Count - 1].Isim);
            System.Console.WriteLine(kisiKartiRehberi[kisiKartiRehberi.Count - 1].Soyisim);
            System.Console.WriteLine(kisiKartiRehberi[kisiKartiRehberi.Count - 1].TelefonNumarasi);

        }
        public void Program2()
        {
            System.Console.WriteLine("2. Program Seçildi");
            string isimYaDaSoyisim;
            int silmeyeDevam = 2;
            while (silmeyeDevam == 2)
            {

                System.Console.WriteLine(" Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");

                isimYaDaSoyisim = Console.ReadLine();

                foreach (var item in kisiKartiRehberi)
                {
                    if ((kisiKartiRehberi.IndexOf(item) == kisiKartiRehberi.Count - 1) &&
                    !(isimYaDaSoyisim.ToLower() == item.Isim.ToLower() ||
                    isimYaDaSoyisim.ToLower() == item.Soyisim.ToLower()))
                    {

                        System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        System.Console.WriteLine("* Silmeyi sonlandırmak için : (1)");

                        System.Console.WriteLine("* Yeniden denemek için      : (2)");
                        silmeyeDevam = Convert.ToInt32(Console.ReadLine());


                    }
                    else if (isimYaDaSoyisim.ToLower() == item.Isim.ToLower() ||
                    isimYaDaSoyisim.ToLower() == item.Soyisim.ToLower())
                    {

                        System.Console.WriteLine(item.Isim + " " + item.Soyisim + " : " + item.TelefonNumarasi + " kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");

                        if (Convert.ToChar(Console.ReadLine()) == 'y')
                        {
                            System.Console.WriteLine(item.Isim + " " + item.Soyisim + " : " + item.TelefonNumarasi + " kişi silindi");
                            kisiKartiRehberi.RemoveAt(kisiKartiRehberi.IndexOf(item));
                            System.Console.WriteLine();
                            silmeyeDevam = 1;

                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }


                }



            }

        }
        public void Program3()
        {
            System.Console.WriteLine("3. Program Seçildi Güncelleme");
            string isimYaDaSoyisim;
            int guncellemeyeDevam = 2;
            while (guncellemeyeDevam == 2)
            {

                System.Console.WriteLine(" Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");

                isimYaDaSoyisim = Console.ReadLine();

                foreach (var item in kisiKartiRehberi)
                {
                    if ((kisiKartiRehberi.IndexOf(item) == kisiKartiRehberi.Count - 1) &&
                    !(isimYaDaSoyisim.ToLower() == item.Isim.ToLower() ||
                    isimYaDaSoyisim.ToLower() == item.Soyisim.ToLower()))
                    {

                        System.Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                        System.Console.WriteLine("* Güncellemeyi sonlandırmak için : (1)");

                        System.Console.WriteLine("* Yeniden denemek için      : (2)");
                        guncellemeyeDevam = Convert.ToInt32(Console.ReadLine());


                    }
                    else if (isimYaDaSoyisim.ToLower() == item.Isim.ToLower() ||
                    isimYaDaSoyisim.ToLower() == item.Soyisim.ToLower())
                    {

                        System.Console.WriteLine(item.Isim + " " + item.Soyisim + " : " + item.TelefonNumarasi + " kişi bilgileri güncellenmek üzere, onaylıyor musunuz ?(y/n)");

                        if (Convert.ToChar(Console.ReadLine()) == 'y')
                        {
                            System.Console.WriteLine("Lütfen güncel isim giriniz              : ");
                            item.Isim = Console.ReadLine();
                            System.Console.WriteLine("Lütfen güncel soyisim giriniz           : ");
                            item.Soyisim = Console.ReadLine();
                            System.Console.WriteLine("Lütfen güncel telefon numarası giriniz  : ");
                            item.TelefonNumarasi = Console.ReadLine();
                            System.Console.WriteLine(item.Isim + " " + item.Soyisim + " : " + item.TelefonNumarasi + " kişi olarak güncellendi");
                            //kisiKartiRehberi.RemoveAt(kisiKartiRehberi.IndexOf(item));
                            System.Console.WriteLine();
                            guncellemeyeDevam = 1;

                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }


                }



            }
        }
        public void Program4()//tamamlandı
        {
            // rehber boyutu
            System.Console.WriteLine(" Rehber'de toplam " + kisiKartiRehberi.Count + " adet kişi kartı vardır.");

            //rehberli listele
            foreach (var item in kisiKartiRehberi)
            {
                System.Console.WriteLine(item.Isim + " " + item.Soyisim + " : " + item.TelefonNumarasi);

            }

        }
        public void Program5()
        {
            System.Console.WriteLine("(5) Rehberde Arama Yapmak");
            System.Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz.:");
            System.Console.WriteLine(" ***************************************");
            System.Console.WriteLine(" İsim veya soyisime göre arama yapmak için: (1)");
            System.Console.WriteLine(" Telefon numarasına göre arama yapmak için: (2)");
            int aramaTipi = Convert.ToInt32(Console.ReadLine());
            if (aramaTipi == 1)
            {
                System.Console.WriteLine(" İsim veya soyisime göre arama yapmak için isim ya da soyisim giriniz");

                string isimYaDaSoyisim = Console.ReadLine();

                foreach (var item in kisiKartiRehberi)
                {
                    if ((kisiKartiRehberi.IndexOf(item) == kisiKartiRehberi.Count - 1) &&
                    !(isimYaDaSoyisim.ToLower() == item.Isim.ToLower() ||
                    isimYaDaSoyisim.ToLower() == item.Soyisim.ToLower()))
                    {

                        if (!kisiKartiRehberi.Contains(item))
                            System.Console.WriteLine("Rehber sonuna gelindi, aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                        else
                            System.Console.WriteLine("Rehber sonuna gelindi, aradığınız krtiterlere uygun başka veri rehberde bulunamadı.");
                    }
                    else if (isimYaDaSoyisim.ToLower() == item.Isim.ToLower() ||
                    isimYaDaSoyisim.ToLower() == item.Soyisim.ToLower())
                    {

                        System.Console.WriteLine("İsim: " + item.Isim + "\n Soyisim: " + item.Soyisim + "\n Telefon Numarası: " + item.TelefonNumarasi);

                    }


                }
            }
            else if (aramaTipi == 2)
            {
                System.Console.WriteLine(" Telefon numarasına göre arama yapmak için telefon numarasını giriniz");

                string telefonNumarasi = Console.ReadLine();

                foreach (var item in kisiKartiRehberi)
                {
                    if ((kisiKartiRehberi.IndexOf(item) == kisiKartiRehberi.Count - 1) &&
                    !(telefonNumarasi.ToLower() == item.TelefonNumarasi.ToLower()))
                    {
                        if (!kisiKartiRehberi.Contains(item))
                            System.Console.WriteLine("Rehber sonuna gelindi, aradığınız krtiterlere uygun veri rehberde bulunamadı.");
                        else
                            System.Console.WriteLine("Rehber sonuna gelindi, aradığınız krtiterlere uygun başka veri rehberde bulunamadı.");

                    }
                    else if (telefonNumarasi.ToLower() == item.TelefonNumarasi.ToLower())
                    {

                        System.Console.WriteLine("İsim: " + item.Isim + "\n Soyisim: " + item.Soyisim + "\n Telefon Numarası: " + item.TelefonNumarasi);

                    }


                }
            }

            /*
            Arama yapmak istediğiniz tipi seçiniz.
 **********************************************
 
 İsim veya soyisime göre arama yapmak için: (1)
 Telefon numarasına göre arama yapmak için: (2)
            */

        }
    }
}