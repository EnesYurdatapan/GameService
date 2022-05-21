using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1999 && gamer.FirstName == "Enes" && gamer.Surname == "Yurt" && gamer.IdentityNumber == 1234)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
