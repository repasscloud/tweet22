using System;
using tweet22.Shared;

namespace tweet22.Client.Services
{
	public interface IAuthService
	{
		Task<ServiceResponse<int>> Register(UserRegister request);
		Task<ServiceResponse<string>> Login(UserLogin request);
	}
}

