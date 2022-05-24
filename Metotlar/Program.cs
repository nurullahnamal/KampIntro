using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();

            urun1.Adi = "elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "amasya Elması";

            Urun urun2 = new Urun();

            urun2.Adi = "karpuz";
            urun2.Fiyati = 75;
            urun2.Aciklama = "Diyar Bakır karpuzu";

            Urun [] urunler = new Urun[] {urun1,urun2};

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);

                Console.WriteLine("-------------------");


            }

            SepetManager ekle = new SepetManager();
                ekle.Ekle(urun1);
            ekle.Ekle(urun2);


        }
    }
}