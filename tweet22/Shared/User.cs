using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace tweet22.Shared
{
	public class User
	{
		[Key]
		public int Id { get; set; }
        public string Email { get; set; } = null!;
        public string Username { get; set; } = null!;
        public byte[]? PasswordHash { get; set; }
        public byte[]? PasswordSalt { get; set; }
        public int Bananas { get; set; }
		public DateTime DateOfBirth { get; set; }
		public bool IsDeleted { get; set; }
		public bool IsConfirmed { get; set; }
		public DateTime DateCreated { get; set; } = DateTime.UtcNow;
	}
}

