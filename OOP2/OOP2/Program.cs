using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Muhammed Azman
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "12345";
            gercekMusteri.Adi = "Muhammed";
            gercekMusteri.Soyadi = "Azman";
            gercekMusteri.TcNo = "39218155936";


            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "54321";
            tuzelMusteri.SirketAdi = "Kodlama.io";
            tuzelMusteri.VergiNo = "1234564890";

            Musteri musteri1 = new GercekMusteri();
            Musteri musteri2 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
