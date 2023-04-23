using System;
namespace tweet22.Shared
{
	public class UserRegistration
	{
		public string Email { get; set; }
		public string Username { get; set; }
		public string Bio { get; set; }
		public string Password { get; set; }
		public string ConfirmPassword { get; set; }
		public int StartUnitId { get; set; } = 1;
		public int Bananas { get; set; } = 100;
		public DateTime DateOfBirth { get; set; } = DateTime.UtcNow;
		public bool IsConfirmed { get; set; } = true;
	}
}

