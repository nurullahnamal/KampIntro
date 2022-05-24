using System;

namespace OOP2
{
    internal class Program
    {// soyutlama
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "23232323";
            musteri1.Adi = "nurullah";
            musteri1.Soyadi = "Namal";
            musteri1.TcNo = "87644646";

            


            TuzelMusteri musteri2=new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "8797890";
            musteri2.Sirketadi = "Kodlama.io";
            musteri2.VergiNo = "1826639619";
            

            Musteri musteri3=new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();


            CustomerManager customerManager = new CustomerManager();    
            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            // Gerçek müsteri - Tüzel Müsteri


        }
    }
}
