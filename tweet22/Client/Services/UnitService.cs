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

        public UnitService(IToastService toastService, HttpClient httpClient)
        {
            _toastService = toastService;
            _httpClient = httpClient;
        }

        public IList<Unit> Units { get; set; } = new List<Unit>();

        public IList<UserUnit> MyUnits { get; set; } = new List<UserUnit>();

        public void AddUnit(int unitId)
        {
            var unit = Units.First(unit => unit.Id == unitId);
            MyUnits.Add(new UserUnit { UnitId = unit.Id, HitPoints = unit.HitPoints });
            _toastService.ShowSuccess($"Your {unit.Title} has been built");

            Console.WriteLine($"{unit.Title} was built");
            Console.WriteLine($"Your army size: {MyUnits.Count}");
        }

        public async Task LoadUnitsAsync()
        {
            if (Units.Count == 0)
            {
                Units = await _httpClient.GetFromJsonAsync<IList<Unit>>("api/Unit");
            }
        }
    }
}

