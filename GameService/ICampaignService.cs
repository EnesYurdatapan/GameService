using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    interface ICampaignService
    {
        void Add(Campaign campaign,Game game);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
