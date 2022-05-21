using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    class CampaignService : ICampaignService
    {
        public void Add(Campaign campaign,Game game)
        {
            Console.WriteLine("Kampanya eklendi ! :"+campaign.Name+"İndirim oranı :"+campaign.SaleRatio+"İndirimli Fiyat :"+((game.Cost)-(game.Cost*campaign.SaleRatio/100)));
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya kaldırıldı ! :"+campaign.Name);
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya güncellendi ! :"+campaign.Name);
        }
    }
}
