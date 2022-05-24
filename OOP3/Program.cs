using System;
using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtıyacKrediManager = new IhtıyacKrediManager();

            IKrediManager tasıtKrediManager = new TasıtKrediManager();
          

            IKrediManager konutKrediManager = new KonutKrediManager();  
           
           BasvuruManager basvuruManager = new BasvuruManager();
           // basvuruManager.BasvuruYap(tasıtKrediManager);
            
            List<IKrediManager> krediler = new List<IKrediManager>() { ihtıyacKrediManager};

            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
