using System;

namespace HataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool hataVar=false;
           /*  try
            {
                Console.WriteLine("Bir sayı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı: "+sayi); 
            }
            catch(Exception e){
                hataVar=true;
                Console.WriteLine("Hata: "+e.Message.ToString());

            }
            finally
            {
                if(hataVar)
                Console.WriteLine("işlem hatasız tamamlanamadı!");
                else
                Console.WriteLine("işlem tamamlandı.");
            } */

            try
            {
                int a = int.Parse("2");
                Console.WriteLine(a);
                Console.WriteLine(a*2);
                int b =int.Parse("-2500000000"); 
            }
            catch (ArgumentNullException e)
            {
                hataVar=true;
               Console.WriteLine("Boş değer girdiniz.");
               Console.WriteLine(e);
            }
            catch (FormatException e)
            {
                hataVar=true;
               Console.WriteLine("Veritipi uygun değil.");
               Console.WriteLine(e);
            }
            catch(OverflowException e){
                hataVar=true;
                Console.WriteLine("Aralık dışında bir değer girildi.");
                Console.WriteLine(e);
            }

            finally
            {
                if(hataVar)
                Console.WriteLine("işlem hatasız tamamlanamadı!");
                else
                Console.WriteLine("işlem tamamlandı.");
            }
           
        }
    }
}
