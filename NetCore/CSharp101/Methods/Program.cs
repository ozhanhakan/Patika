using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            //erişim_belirteci geri_dönüş_tipi metod_adı(parametreListesi/Argüman)
            //{
            //komutlar    
            //  }

            Console.WriteLine("iki sayıyı toplayan method örneği");
            int a = 2;
            int b = 3;
            System.Console.WriteLine(a + b);


            int sonuc = Topla(5, 5);  //statik metodlar içinden sadece statik metdlara erişilebilecğeinden metodu statc yapmalıyız
            System.Console.WriteLine(sonuc);
            Metotlar ornek = new Metotlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));
//call by value örneği
            int sonuc2=ornek.ArttirVeTopla(a,b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));
//call by reference örneği
            sonuc2=ornek.ArttirVeTopla(ref a,ref b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(a+b));

        }

        static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        }
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            System.Console.WriteLine(veri);
        }
//call by value
        public int ArttirVeTopla(int deger1,int deger2){
            deger1++;
            deger2++;

            return deger1+deger2;
        }

        //call by reference
        public int ArttirVeTopla(ref int deger1,ref int deger2){
            deger1++;
            deger2++;

            return deger1+deger2;
        }
    }
}
