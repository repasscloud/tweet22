using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tweet22.Shared;

namespace Server.Services
{
    public interface IUtilityService
    {
        Task<User> GetUser();
    }
}