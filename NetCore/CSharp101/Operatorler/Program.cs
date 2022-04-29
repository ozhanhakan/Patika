using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atama ve İşlemli Atama");
            int x=3;
            int y=3;
            Console.WriteLine(y);
            y=y+2;
            Console.WriteLine(y);

            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            x *=2;
            Console.WriteLine(x);

            Console.WriteLine(" Mantıksal Operatörler *|| && !");
            bool isSuccess = true;
            bool isCompleted = false;
            if(isSuccess && isCompleted)
            Console.WriteLine("Perfect!");

            if (isSuccess || isCompleted)
            Console.WriteLine("Great!");
            if(isSuccess && !isCompleted )
            Console.WriteLine("Fine");
           
            Console.WriteLine(" İlişkisel Operatörler <,> !=, <=,>=");
            bool sonuc = x>y;
            Console.WriteLine(sonuc);
            sonuc = x<y;
            Console.WriteLine(sonuc);
            sonuc = x<=y;
            Console.WriteLine(sonuc);
            sonuc = x==y;
            Console.WriteLine(sonuc);
            sonuc = x!=y;
            Console.WriteLine(sonuc);
            
            Console.WriteLine(" Aritmetik Operatörler +,-,*,/,%");
            int sayi1=10;
            int sayi2=5;
            int sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);
            int sonuc2=sayi1%sayi2;
            Console.WriteLine(sonuc2);
            int sonuc3=++sonuc2;
            Console.WriteLine(sonuc3);

            

        }
    }
}
