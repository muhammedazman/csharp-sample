using GameSellingApp.Campaigns;
using GameSellingApp.Gamer;
using GameSellingApp.Games;
using GameSellingApp.Sales;
using SellMyGames;
using System;

namespace GameSellingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Game
            Game game1 = new Game() { GameId = 1, GameName = "Counter Strike", GamePrice = 133.00 };
            Game game2 = new Game() { GameId = 2, GameName = "PUBG Mobile ", GamePrice = 123.40 };
            Game game3 = new Game() { GameId = 3, GameName = "Need for Speed", GamePrice = 175.90 };
            Game game4 = new Game() { GameId = 4, GameName = "Medal of Honor", GamePrice = 92.00 };
            Game game5 = new Game() { GameId = 5, GameName = "Call of Duty", GamePrice = 124.60 };
            Game game6 = new Game() { GameId = 6, GameName = "Angry Birds", GamePrice = 210.30 };

            //Gamer
            GamerEntity gamer1 = new GamerEntity() { GamerId = 1, FirstName = "Bledar", LastName = "Brown", DateOfBirth = new DateTime(1987, 2, 6), NatioanlityId = "353434534764" };
            GamerEntity gamer2 = new GamerEntity() { GamerId = 2, FirstName = "Rachid", LastName = "Khane", DateOfBirth = new DateTime(1992, 10, 30), NatioanlityId = "8765432345" };
            GamerEntity gamer3 = new GamerEntity() { GamerId = 3, FirstName = "Naoko", LastName = "Kohosi", DateOfBirth = new DateTime(2000, 3, 12), NatioanlityId = "121300787264" };
            GamerEntity gamer4 = new GamerEntity() { GamerId = 4, FirstName = "Natalia", LastName = "Jaros", DateOfBirth = new DateTime(2003, 6, 12), NatioanlityId = "123471928461" };
            GamerEntity gamer5 = new GamerEntity() { GamerId = 5, FirstName = "Lisa", LastName = "Jonie", DateOfBirth = new DateTime(1997, 1, 12), NatioanlityId = "2179176412" };
            GamerEntity gamer6 = new GamerEntity() { GamerId = 6, FirstName = "Jenny", LastName = "Kirks", DateOfBirth = new DateTime(2005, 12, 12), NatioanlityId = "641294169421" };

            //Campaign
            CampaignEntity campaign1 = new CampaignEntity() { CampaignId = 1, CampaignName = "Welcome", DiscountAmount = 25, ExpiryDate = new DateTime(2025, 4, 12) };
            CampaignEntity campaign2 = new CampaignEntity() { CampaignId = 2, CampaignName = "Summer", DiscountAmount = 20, ExpiryDate = new DateTime(2025, 11, 11) };
            CampaignEntity campaign3 = new CampaignEntity() { CampaignId = 3, CampaignName = "VIP", DiscountAmount = 10, ExpiryDate = new DateTime(2025, 5, 4) };
            CampaignEntity campaign4 = new CampaignEntity() { CampaignId = 4, CampaignName = "Our Gift", DiscountAmount = 5, ExpiryDate = new DateTime(2025, 12, 10) };
            CampaignEntity campaign5 = new CampaignEntity() { CampaignId = 5, CampaignName = "Valentine's", DiscountAmount = 50, ExpiryDate = new DateTime(2025, 5, 5) };
            CampaignEntity campaign6 = new CampaignEntity() { CampaignId = 6, CampaignName = "Unnamed", DiscountAmount = 2, ExpiryDate = new DateTime(2023, 10, 18) };


            GameManager gameManager = new GameManager();
            gameManager.InsertGame(game1);
            gameManager.InsertGame(game2);
            gameManager.InsertGame(game3);
            gameManager.InsertGame(game4);
            gameManager.InsertGame(game5);
            gameManager.InsertGame(game6);
            gameManager.DeleteGame(game5);
            gameManager.UpdateGame(game4, 230.00);

            Console.WriteLine("");
            Console.WriteLine("");

            GamerManager gamerManager = new GamerManager();
            gamerManager.RegisterGamer(gamer1);
            gamerManager.RegisterGamer(gamer2);
            gamerManager.RegisterGamer(gamer3);
            gamerManager.RegisterGamer(gamer4);
            gamerManager.RegisterGamer(gamer5);
            gamerManager.RegisterGamer(gamer6);
            gamerManager.DeleteGamer(gamer3);
            gamerManager.UpdateGamer(gamer5, "Jack");

            Console.WriteLine("");
            Console.WriteLine("");

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.AddCampaign(campaign1);
            campaignManager.AddCampaign(campaign2);
            campaignManager.AddCampaign(campaign3);
            campaignManager.AddCampaign(campaign4);
            campaignManager.AddCampaign(campaign5);
            campaignManager.AddCampaign(campaign6);

            Console.WriteLine("");
            Console.WriteLine("");

            gameManager.ListGame();
            gamerManager.ListGamer();
            campaignManager.ListTheCampaigns();


            SalesManager salesManager = new SalesManager();
            salesManager.Sell(gamer6, game2);
            salesManager.Sell(gamer2, game3, campaign1);
            salesManager.Sell(gamer1, game4, campaign1);
            salesManager.Sell(gamer4, game6, campaign5);
            salesManager.Sell(gamer5, game1);
            salesManager.Sell(gamer1, game2);
            salesManager.Sell(gamer4, game3, campaign3);
            salesManager.Sell(gamer5, game4);
            salesManager.Sell(gamer1, game6, campaign2);
            salesManager.Sell(gamer2, game1, campaign4);
            salesManager.Sell(gamer5, game2);

            campaignManager.Modify(campaign1, new DateTime(2021, 10, 30));
            campaignManager.Modify(campaign2, new DateTime(2021, 10, 30));
            campaignManager.Modify(campaign3, new DateTime(2021, 10, 30));
            campaignManager.Modify(campaign4, new DateTime(2021, 10, 30));
            campaignManager.Modify(campaign5, new DateTime(2021, 10, 30));

            campaignManager.Modify(campaign2, 80);
            campaignManager.Modify(campaign5, 70);


            salesManager.Sell(gamer6, game3, campaign1);
            salesManager.Sell(gamer2, game4, campaign2);
            salesManager.Sell(gamer4, game6, campaign5);
            salesManager.Sell(gamer6, game1, campaign2);
            salesManager.Sell(gamer1, game2, campaign1);

            campaignManager.DeleteCampaign(campaign6);

            campaignManager.ListTheCampaigns();
            gameManager.ListGame();

            Console.Read();
        }
    }
}
