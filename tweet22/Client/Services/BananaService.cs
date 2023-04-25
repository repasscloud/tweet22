using System;
using System.Net.Http.Json;

namespace tweet22.Client.Services
{
	public class BananaService : IBananaService
	{
        private readonly HttpClient _httpClient;

        public event Action? OnChange;

        public int Bananas { get; set; } = 0;

        public BananaService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public void EatBananas(int amount)
        {
            Bananas -= amount;
            BananasChanged();
        }

        public void AddBananas(int amount)
        {
            Bananas += amount;
            BananasChanged();
        }

        void BananasChanged() => OnChange?.Invoke();

        public async Task GetBananas()
        {
            Bananas = await _httpClient.GetFromJsonAsync<int>("api/user/getbananas");
            BananasChanged();
        }
    }
}

