﻿using Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositories
{
    public interface IUserRepository:IRepository<User>
    {
        User ValidateUser(string email, string password);
    }
}
