using System;
using tweet22.Shared;

namespace tweet22.Client.Services
{
	public interface IUnitService
	{
		IList<Unit> Units { get; set; }
		IList<UserUnit> MyUnits { get; set; }
		Task AddUnit(int unitId);
		Task LoadUnitsAsync();
	}
}

