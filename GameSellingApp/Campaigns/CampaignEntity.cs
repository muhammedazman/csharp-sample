using System;
using System.Collections.Generic;
using System.Text;

namespace GameSellingApp.Campaigns
{
    public class CampaignEntity
    {
        public int CampaignId { get; set; }
        public string CampaignName { get; set; }
        public int DiscountAmount { get; set; }
        public DateTime ExpiryDate { get; set; }
    }
}
