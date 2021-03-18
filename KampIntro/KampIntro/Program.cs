using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety = tip güvenligi
            String str = "String degiskenin degeri";
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun < dolarBugun)
            {
                Console.Write("Dolarda Artis Var!!!!");
            }
            else if (dolarDun > dolarBugun)
            {
                Console.Write("Dolarda Azalis Var!!!!");
            }
            else
            {
                Console.Write("Dolarda Degisiklik Yok!!!!");
            }
        }
    }
}
