﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameService
{
    interface IUserValidationService
    {
        bool Validate(Gamer gamer);
    }
}
