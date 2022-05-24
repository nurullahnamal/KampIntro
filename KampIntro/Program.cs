using System;

namespace KampIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string katgori = "dawdada";
            Console.WriteLine(katgori);
            double FaizOranı = 3.1;
            bool SistemeGirisYapmısMı=false;

            double DolarDun = 7.2;
            double DolarBugun = 7.29;



            if (DolarBugun>DolarDun)
            {
                Console.WriteLine("Dolare artmış kee");
            }
            else if (DolarDun > DolarBugun)
            {
                Console.WriteLine("dolar düşmüşkee");
            }
            else
            {
                Console.WriteLine("Dolar sabitt");
            }
        }
    }
}
