using GameSellingApp.Gamer;
using GameSellingApp.Games;
using GameSellingApp.Campaigns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameSellingApp
{
    interface ISalesService
    {
        void Sell(GamerEntity gamer, Game game);
        void Sell(GamerEntity gamer, Game game, CampaignEntity campaign);

    }
}
