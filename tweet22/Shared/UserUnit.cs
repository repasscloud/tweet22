using System;
using System.ComponentModel.DataAnnotations;

namespace tweet22.Shared
{
	public class UserUnit
	{
		[Key]
		public int Id { get; set; }
		public int UserId { get; set; }
		public Unit? Unit { get; set; }
		public int UnitId { get; set; }
		public int HitPoints { get; set; }
	}
}

