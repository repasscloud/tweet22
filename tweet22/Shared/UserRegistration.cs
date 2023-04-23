using System;
using System.ComponentModel.DataAnnotations;

namespace tweet22.Shared
{
	public class UserRegistration
	{
		[Required, EmailAddress]
		public string Email { get; set; }
		[StringLength(16, ErrorMessage = "Your username is too long, 16 char max")]
		public string Username { get; set; }
		[Required, StringLength(100, MinimumLength = 6)]
		public string Bio { get; set; }
		public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }
		public int StartUnitId { get; set; } = 1;
		[Range(100, 1000, ErrorMessage = "Choose between 100 to 1000")]
		public int Bananas { get; set; } = 100;
		public DateTime DateOfBirth { get; set; } = DateTime.UtcNow;
		[Range(typeof(bool), "true", "true", ErrorMessage = "Only confirmed users can play")]
		public bool IsConfirmed { get; set; } = true;
	}
}

