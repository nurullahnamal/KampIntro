using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Kurs kurs1 =new Kurs();
            kurs1.Ad = "Engiow";
            kurs1.SoyAd = "dadadda";
            kurs1.Memleket = "manisa";

            Kurs kurs2 = new Kurs();
            kurs2.Ad = "Engiow";
            kurs2.SoyAd = "dadadda";
            kurs2.Memleket = "manisa";

            Kurs kurs3 = new Kurs();
            kurs3.Ad = "Engiow";
            kurs3.SoyAd = "dadadda";
            kurs3.Memleket = "manisa";

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var item in kurslar)
            {
                Console.WriteLine(item.Ad);
            }
            
            Console.WriteLine("Hello World!");
        }
    }
    class Kurs
    {
        public string Ad { get; set; }
        public string Memleket { get; set; }
        public string SoyAd { get; set; }
    }
}
