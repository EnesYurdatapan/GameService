using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    class GameService : IGameService
    {
        public void Sell(Gamer gamer, Campaign campaign)
        {
            Console.WriteLine(gamer.FirstName + "Adlı oyuncu"+campaign.Name+"Kampanyasıyla oyunu satın aldı.");
        }
    }
}
