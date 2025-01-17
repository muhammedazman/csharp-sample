﻿using GameSellingApp.Campaigns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellMyGames
{
    class CampaignManager : ICampaignManager
    {

        List<CampaignEntity> campaigns = new List<CampaignEntity>();




        public  void AddCampaign(CampaignEntity campaign)
        {
            campaigns.Add(campaign);
            Console.WriteLine("\"" + campaign.CampaignName + " Campaign\" added with a discount amount "+campaign.DiscountAmount+"% and expires at " + campaign.ExpiryDate);

        }

        public  void DeleteCampaign(CampaignEntity campaign)
        {
            campaigns.Remove(campaign);
            Console.WriteLine("Campaign Removed : " + campaign.CampaignName);       
        }

        public  void Modify(CampaignEntity campaign, DateTime newExpiryDate)
        {
            foreach (var camp in campaigns)
            {
                if (camp.Equals(campaign))
                {
                    camp.ExpiryDate = newExpiryDate;
                    Console.WriteLine(" ");
                    Console.WriteLine("=====================================================");
                    Console.WriteLine(camp.CampaignName + " was set to be expired at " + camp.ExpiryDate);
                    Console.WriteLine("=====================================================");
                    Console.WriteLine("  ");

                }
            }

        }

        public  void Modify(CampaignEntity campaign, int discountAmount)
        {
            foreach (var camp in campaigns)
            {
                if (camp.Equals(campaign))
                {
                    camp.DiscountAmount = discountAmount;
                    Console.WriteLine(camp.CampaignName + " gives " + camp.DiscountAmount + "% discount..");
                }
            }

        }


        public void ListTheCampaigns()
        {
            Console.WriteLine(" ");
            Console.WriteLine("------------------ VALID CAMPAIGNS   --------------");

            foreach (var campaign in campaigns)
            {
                Console.WriteLine("Campaign Name: "+campaign.CampaignName + " discount percentage : " + campaign.DiscountAmount  + "%");

            }

            Console.WriteLine("------------------ END OF THE LIST   --------------");
            Console.WriteLine(" ");

        }

    }
}
