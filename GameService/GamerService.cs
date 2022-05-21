using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    class GamerService :IGamerService
    {

        IUserValidationService _userValidationService;

        public GamerService(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Üye silindi");
        }

     

        public void Register(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer) == true) {
                Console.WriteLine("Oyuncu kayıt edildi :" + gamer.FirstName + gamer.Surname);
            }
            else {
                Console.WriteLine("Doğrulama Başarısız !!");
            }
            
        }

       

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu bilgisi güncellendi ! :"+gamer.FirstName+gamer.Surname);
        }
    }
}
