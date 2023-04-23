using System;
using tweet22.Shared;

namespace tweet22.Client.Services
{
	public interface IUnitService
	{
		IList<Unit> Units { get; }
		IList<UserUnit> MyUnits { get; set; }
		void AddUnit(int unitId);
	}
}

