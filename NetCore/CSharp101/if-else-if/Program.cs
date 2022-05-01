using System;

namespace if_else_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***if-else-if***");
            //saate göre selamlama
            int time = DateTime.Now.Hour-5;
            if(time>=6 && time<=11)
                Console.WriteLine("if-else-if yöntemi: \n saat: "+time+" Günaydın!");
            else if (time<=18)
                Console.WriteLine("if-else-if yöntemi: \n saat: "+time+" iyi günler!");
            else
                Console.WriteLine("if-else-if yöntemi: \n saat: "+time+" iyi geceler!");

            string sonuc = time >=6 && time<=11 ?  " Günaydın!" : time<=18 ? "iyi günler!":"iyi geceler!";
            Console.WriteLine("ternary yöntemi: \n saat: "+time+" "+sonuc);
        }
    }
}
