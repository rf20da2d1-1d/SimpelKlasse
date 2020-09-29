using System;

namespace SimpleKlasse
{
    class Program
    {
        static void Main(string[] args)
        {
            BraetSpil spil1 = new BraetSpil();
            System.Console.WriteLine("Spil et med default værdier");
            System.Console.WriteLine(spil1.HentInfo());

            BraetSpil spil2 = new BraetSpil(124.50, "Mariehønen", 5, 4, 25);
            System.Console.WriteLine("Spil et med eksplicitte værdier");
            System.Console.WriteLine(spil2.HentInfo());

            Console.ReadLine();
        }
    }
}
