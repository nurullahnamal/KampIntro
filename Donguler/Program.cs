using System;

namespace Donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar  =new string[] { "dwadada", "dwadsadsscght", "üürnler", "kitaplar" };
            string kurs1 = "Yazılım .geliştrime Yerleştirme Kapmpı"; 
            string kurs2 = "Programlama Baslangacı için temel kurs";
            

        
        
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("------------------------");


            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
        }
    }
}
