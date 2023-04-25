using System;
using System.Net.Http;
using System.Net.Http.Json;
using tweet22.Shared;

namespace tweet22.Client.Services
{
	public class AuthService : IAuthService
	{
        private readonly HttpClient _httpClient;

		public AuthService(HttpClient httpClient)
		{
            _httpClient = httpClient;
		}

        public async Task<ServiceResponse<int>> Register(UserRegister request)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/register", request);

#pragma warning disable CS8603 // Possible null reference return.
            return await result.Content.ReadFromJsonAsync<ServiceResponse<int>>();
#pragma warning restore CS8603 // Possible null reference return.
        }

        public async Task<ServiceResponse<string>> Login(UserLogin request)
        {
            var result = await _httpClient.PostAsJsonAsync("api/auth/login", request);

#pragma warning disable CS8603 // Possible null reference return.
            return await result.Content.ReadFromJsonAsync<ServiceResponse<string>>();
#pragma warning restore CS8603 // Possible null reference return.
        }
    }
}

