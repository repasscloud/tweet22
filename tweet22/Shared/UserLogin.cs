using System;
using System.ComponentModel.DataAnnotations;

namespace tweet22.Shared
{
	public class UserLogin
	{
		[Required(ErrorMessage = "Valid email address required")]
		public string Username { get; set; }
		[Required]
		public string Password { get; set; }
	}
}

