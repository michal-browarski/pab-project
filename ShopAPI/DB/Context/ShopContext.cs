using Microsoft.EntityFrameworkCore;
using ShopAPI.Model;

namespace ShopAPI.DB.Context
{
	public class ShopContext : DbContext
	{
		public ShopContext(DbContextOptions options) 
			: base(options)
		{
		}

		public DbSet<User> Users { get; set; }
		public DbSet<PersonalInfo> PersonalInfos { get; set; }
		public DbSet<AdressInfo> Adresses { get; set; }
	}
}
