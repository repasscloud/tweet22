using System;
using System.ComponentModel.DataAnnotations;

namespace tweet22.Shared
{
	public class UserRegister
	{
		[Required, EmailAddress]
		public string Email { get; set; } = null!;
		[StringLength(16, ErrorMessage = "Your username is too long, 16 char max")]
		public string Username { get; set; } = null!;
        [Required, StringLength(100, MinimumLength = 6)]
		public string Bio { get; set; } = null!;
        public string Password { get; set; } = null!;
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; } = null!;
        public int StartUnitId { get; set; } = 1;
		[Range(100, 1000, ErrorMessage = "Choose between 100 to 1000")]
		public int Bananas { get; set; } = 100;
		public DateTime DateOfBirth { get; set; } = DateTime.UtcNow;
		[Range(typeof(bool), "true", "true", ErrorMessage = "Only confirmed users can play")]
		public bool IsConfirmed { get; set; } = true;
	}
}

