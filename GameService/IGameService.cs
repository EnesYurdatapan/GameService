using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    interface IGameService
    {
        void Sell(Gamer gamer,Campaign campaign);
    }
}
