﻿using BeeHRM.ApplicationService.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHRM.ApplicationService.Interfaces
{
   public interface IUserService
    {

        UsersResponse GetUsersByRole(string roleName);
        UsersResponse GetUsers();
    }
}