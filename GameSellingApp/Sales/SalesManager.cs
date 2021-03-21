using GameSellingApp.Campaigns;
using GameSellingApp.Gamer;
using GameSellingApp.Games;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingApp.Sales
{
    public class SalesManager : ISalesService
    {
        public void Sell(GamerEntity gamer, Game game)
        {
            gamer.GameBought.Add(game);
            Console.WriteLine("....................................................................");
            Console.WriteLine(gamer.FirstName.ToUpper() + " bought  " + game.GameName.ToUpper() + " for " +
                game.GamePrice + "Euros.");
            Console.Write(gamer.FirstName.ToUpper() + "'s gamelist now includes : ");

            foreach (var g in gamer.GameBought)
            {
                Console.Write(g.GameName + ", ");
            }

            Console.WriteLine(" ");

            Console.WriteLine("....................................................................");

            Console.WriteLine(" ");
        }

        public void Sell(GamerEntity gamer, Game game, CampaignEntity campaign)
        {
            double newPrice = (game.GamePrice / 100) * (100 - campaign.DiscountAmount);
            gamer.GameBought.Add(game);
            Console.WriteLine("....................................................................");

            Console.WriteLine(gamer.FirstName.ToUpper() + " bought  " + game.GameName.ToUpper() + " for " + newPrice + "Euros.");
            Console.Write(gamer.FirstName.ToUpper() + "'s gamelist now includes : ");
            foreach (var g in gamer.GameBought)
            {

                Console.Write(g.GameName + ", ");

            }
            Console.WriteLine(" ");

            Console.WriteLine("....................................................................");

            Console.WriteLine(" ");
        }
    }
}
