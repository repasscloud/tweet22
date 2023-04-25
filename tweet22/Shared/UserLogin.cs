using System;
using System.ComponentModel.DataAnnotations;

namespace tweet22.Shared
{
	public class UserLogin
	{
		[Required(ErrorMessage = "Valid email address required")]
		public string Email { get; set; } = null!;
		[Required]
		public string Password { get; set; } = null!;
	}
}

