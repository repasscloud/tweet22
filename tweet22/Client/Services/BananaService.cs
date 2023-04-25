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

        void BananasChanged() => OnChange?.Invoke();

        public void EatBananas(int amount)
        {
            Bananas -= amount;
            BananasChanged();
        }

        public async Task AddBananas(int amount)
        {
            var result = await _httpClient.PutAsJsonAsync<int>("api/user/addbananas", amount);
            Bananas = await result.Content.ReadFromJsonAsync<int>();
            BananasChanged();
        }

        public async Task GetBananas()
        {
            Bananas = await _httpClient.GetFromJsonAsync<int>("api/user/getbananas");
            BananasChanged();
        }
    }
}

