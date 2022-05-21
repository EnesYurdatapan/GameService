using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    interface IGamerService
    {
        void Register(Gamer gamer);
        void Update(Gamer gamer);
        void Delete(Gamer gamer);

    }
}
