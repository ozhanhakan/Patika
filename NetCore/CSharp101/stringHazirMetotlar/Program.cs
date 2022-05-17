using System;

namespace stringHazirMetotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz";
            string degisken2 = "Dersimiz CSharp";
            //Length
            Console.WriteLine(degisken.Length);
            //ToUpper, ToLower
            Console.WriteLine(degisken.ToLower());
            Console.WriteLine(degisken.ToUpper());

            //Concat
            System.Console.WriteLine("concat metodu");
            System.Console.WriteLine("Merhaba, " + degisken);
            System.Console.WriteLine(String.Concat(degisken+" Merhaba"));

            //Compare
            System.Console.WriteLine("Compare  metodu");
            System.Console.WriteLine(degisken.CompareTo(degisken2)); //0 aynısı,1 sonrası,-1 öncesi döner,
            System.Console.WriteLine(1.CompareTo(2)); //0,1,-1 döner
            System.Console.WriteLine(1.CompareTo(1)); //0,1,-1 döner
            System.Console.WriteLine(1.CompareTo(0)); //0,1,-1 döner
            System.Console.WriteLine("A".CompareTo("a")); //0,1,-1 döner
            System.Console.WriteLine(String.Compare(degisken, degisken2, true)); //büyük küçük harf dikkate alınmaz
            System.Console.WriteLine(String.Compare("Hakan", "hakan", true)); 
            //büyük küçük harf dikkate alınmaz H ve h aynı sırada sayılır..
            
            System.Console.WriteLine(String.Compare("Hakan", "hakan", false)); 
            //büyük küçük harf dikkate alınır "H", "h" den sonradır

            //Contains
            System.Console.WriteLine("Contains metodu");
            System.Console.WriteLine(degisken.Contains(degisken2));
            System.Console.WriteLine(degisken.EndsWith("Hoşgeldiniz"));
            System.Console.WriteLine(degisken.StartsWith("Merhaba"));

            //indexOf
            System.Console.WriteLine("indexOf  metodu");
            System.Console.WriteLine(degisken.IndexOf("CS"));
            System.Console.WriteLine(degisken.IndexOf("Merhaba"));
            System.Console.WriteLine(degisken.IndexOf("Hakan"));
            System.Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            System.Console.WriteLine("insert  metodu");
            System.Console.WriteLine(degisken.Insert(0,"Merhaba! "));
            System.Console.WriteLine(degisken);
           string degisken3= degisken.Insert(0,"Hey merhabalar! ");
            System.Console.WriteLine(degisken3);

            //PadLeft, PadRight
            System.Console.WriteLine("PadLeft metodu");
            System.Console.WriteLine(degisken+degisken2.PadLeft(30));
            System.Console.WriteLine(degisken+degisken2.PadLeft(30,'*'));
            System.Console.WriteLine(degisken.PadRight(50)+degisken2);
            System.Console.WriteLine(degisken.PadRight(50,'-')+degisken2);

            //Remove
            System.Console.WriteLine("Remove  metodu");
            System.Console.WriteLine(degisken.Remove(10));
            System.Console.WriteLine(degisken.Remove(5,1));
            System.Console.WriteLine(degisken.Remove(0,1));

            //Replace
            System.Console.WriteLine("Replace  metodu");
            System.Console.WriteLine(degisken.Replace("CSharp","C#"));
            System.Console.WriteLine(degisken.Replace(" ","-"));

            //Split
            System.Console.WriteLine("Split  metodu");
            System.Console.WriteLine(degisken.Split(' ')[0]);
            System.Console.WriteLine(degisken.Split(' ')[1]);
            System.Console.WriteLine(degisken.Split(' ')[2]);

            //Substring
            System.Console.WriteLine("Substring  metodu");
            System.Console.WriteLine(degisken.Substring(4));//4.index dahil sonrakileri bir string olarak getirir
            System.Console.WriteLine(degisken.Substring(4,2));//4.index dahil sonraki 2 karakteri bir string olarak getirir




            
        }
    }
}
