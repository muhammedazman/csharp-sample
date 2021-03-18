using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 80;
            urun1.Aciklama = "Amasya elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 90;
            urun2.Aciklama = "Diyarbakir karpuzu";

            Urun[] urunler = { urun1, urun2 };

            foreach (var urun in urunler)
            {
                Console.WriteLine("Adi: " + urun.Adi);
                Console.WriteLine("Fiyati: " + urun.Fiyati);
                Console.WriteLine("Aciklama: " + urun.Aciklama);
            }
        }
    }
}
