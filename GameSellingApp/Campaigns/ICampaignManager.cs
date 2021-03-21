using GameSellingApp.Campaigns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SellMyGames
{
    interface ICampaignManager
    {
        public void AddCampaign(CampaignEntity campaign);
        public void DeleteCampaign(CampaignEntity campaign);
        public void Modify(CampaignEntity campaign, DateTime newExpiryDate);
        public void Modify(CampaignEntity campaign, int discountAmount);
    }
}
