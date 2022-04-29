/*
Bu program ortamı komut satırında 
dotnet new console
komutu kullanılarak otomatik başlatıldı.
Patika\Net Core\CSharp101\ConsoleProgramlama>dotnet new console
*/

using System;

namespace ConsoleProgramlama
{
    class Program
    {
        static void Main(string[] args)
        //static nesnesi yaratılmadan objeye ulaşmak.
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi giriniz!");
            string name = Console.ReadLine();

            Console.WriteLine("soyisminizi giriniz!");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba!, " +name+" "+surname);
            Console.ReadKey();

            /* launch.json dosyasındaki "console": "internalConsole",
                        "console": "integratedTerminal",
                        ya da 
                         "console": "externalTerminal",

            olarak değiştirilmeli ki terminal okuma yapabilsin
            */

        }
    }
}
