using System;
using tweet22.Shared;

namespace tweet22.Server.Data
{
	public interface IAuthRepository
	{
		Task<ServiceResponse<int>> Register(User user, string password);
		Task<ServiceResponse<string>> Login(string email, string password);
		Task<bool> UserExists(string email);
    }
}

