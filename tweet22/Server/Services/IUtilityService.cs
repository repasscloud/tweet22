using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tweet22.Shared;

namespace tweet22.Server.Services
{
    public interface IUtilityService
    {
        Task<User> GetUser();
    }
}