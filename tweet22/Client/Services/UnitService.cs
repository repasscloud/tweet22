using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using Blazored.Toast.Services;
using tweet22.Shared;

namespace tweet22.Client.Services
{
    public class UnitService : IUnitService
    {
        private readonly IToastService _toastService;
        private readonly HttpClient _httpClient;
        private readonly IBananaService _bananaService;

        public UnitService(IToastService toastService, HttpClient httpClient, IBananaService bananaService)
        {
            _toastService = toastService;
            _httpClient = httpClient;
            _bananaService = bananaService;
        }

        public IList<Unit> Units { get; set; } = new List<Unit>();

        public IList<UserUnit> MyUnits { get; set; } = new List<UserUnit>();

        public async Task AddUnit(int unitId)
        {
            var unit = Units.First(unit => unit.Id == unitId);
            var result = await _httpClient.PostAsJsonAsync<int>("api/userunit", unitId);

            if (result.StatusCode != System.Net.HttpStatusCode.OK)
            {
                _toastService.ShowError(await result.Content.ReadAsStringAsync());
            }
            else
            {
                await _bananaService.GetBananas();
                _toastService.ShowSuccess($"Your {unit.Title} has been built");
            }
        }

        public async Task LoadUnitsAsync()
        {
            if (Units.Count == 0)
            {
#pragma warning disable CS8601 // Possible null reference assignment.
                Units = await _httpClient.GetFromJsonAsync<IList<Unit>>("api/Unit");
#pragma warning restore CS8601 // Possible null reference assignment.
            }
        }

        public async Task LoadUserUnitsAsync()
        {
            MyUnits = (IList<UserUnit>)await _httpClient.GetFromJsonAsync<IList<UserUnit>>("api/userunit");
        }
    }
}

