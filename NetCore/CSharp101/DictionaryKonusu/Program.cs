using System;
using System.Collections.Generic;

namespace DictionaryKonusu
{
    /*
    Dictionary Nedir ?
Dictionary koleksiyonunda key-value yani anahtar-deger denen 2 kavram ile karşılaşıyoruz. 
Dizilere eklediğimiz elemanları value, index lerini ise key olarak düşünebilirsiniz.
Dictionary lerin elemanlarının anahtarları birbirinden farklı olmalıdır. 
Aynı anahtar kullanılarak 2 değer saklanamaz.
Örnek söz dizimi şu şekildedir:
Dictionary<Key_Veri_Tipi, Value_Veri_Tipi> dictionary_adi = new Dictionary<Key_Veri_Tipi, Value_Veri_Tipi>();
Örnek:
Dictionary<int,string> renkler = new Dictionary<int, string>();
renkler.Add(3,"Kırmızı");
renkler.Add(5,"Sarı");
Yukarıdaki örnekte anatarı integer olan, değeri string olan renkler adında bir dictionary tanımladık. 
3-"Kırmızı", 5-"Sarı" ikililerini dictionary'e ekledik.
    */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dictionary Key/Value çifti, Key uniqe olmalı");
            Dictionary<int,string> kullanicilar=new Dictionary<int, string>();
            kullanicilar.Add(10,"Hakan Özhan");
            kullanicilar.Add(12,"Özcan Balcı");
            kullanicilar.Add(14,"Coşkun Kasap");

            //dzinin elemanlarına erişim
            System.Console.WriteLine(kullanicilar[12]);//12 anahtarına sahip eleman value/değeri döner
            foreach (var item in kullanicilar)
            {
                System.Console.WriteLine(item);
            }

            //Count
            System.Console.WriteLine("Count");
            System.Console.WriteLine(kullanicilar.Count);

            //Contains
            System.Console.WriteLine("Contains");
            System.Console.WriteLine(kullanicilar.ContainsKey(12));
            System.Console.WriteLine(kullanicilar.ContainsValue("Hakan"));

            //Remove
            System.Console.WriteLine("Remove");
            System.Console.WriteLine(kullanicilar.Remove(12));
            foreach (var item in kullanicilar)
            {
                System.Console.WriteLine(item);
            }
            foreach (var item in kullanicilar)
            {
                System.Console.WriteLine(item.Key);
            }

            //Keys
            System.Console.WriteLine("Keys");

            foreach (var item in kullanicilar.Keys)
            {
                System.Console.WriteLine(item);
            }
            //values
            System.Console.WriteLine("Values");

            foreach (var item in kullanicilar.Values)
            {
                System.Console.WriteLine(item);
            }

            
        }
    }
}
