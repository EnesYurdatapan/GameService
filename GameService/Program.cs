using System;

namespace GameService
{
    class Program
    {
        static void Main(string[] args)
        {
            GameService gameService = new GameService();
            Gamer gamer = new Gamer();
            gamer.FirstName = "Enes";
            gamer.Id = 1;
            gamer.Surname = "Yılmaz";
            gamer.IdentityNumber = 12345;
            gamer.BirthYear = 1999;
            Campaign campaign = new Campaign();
            campaign.Name = "Yaz Kampanyası";
            gameService.Sell(gamer, campaign);

            GamerService gamerService = new GamerService(new UserValidationManager());
            gamerService.Register(new Gamer
            {
                Id = 1,
                BirthYear = 1999,
                FirstName = "Enes",
                Surname = "Yurt",
                IdentityNumber = 1234

            });
        }
    }
}
