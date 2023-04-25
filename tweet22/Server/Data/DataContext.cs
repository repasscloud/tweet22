using System;
using Microsoft.EntityFrameworkCore;
using tweet22.Shared;

namespace tweet22.Server.Data
{
	public class DataContext : DbContext
	{
		public DataContext(DbContextOptions<DataContext> options) : base(options)
		{

		}

		public DbSet<Unit> Units { get; set; }
		public DbSet<User> Users { get; set; }
		public DbSet<UserUnit> UserUnits { get; set; }
	}
}

