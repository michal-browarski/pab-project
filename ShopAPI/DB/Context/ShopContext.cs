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

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<PersonalInfo>()
				.HasData
				(
					new PersonalInfo()
					{
						Id = 1,
						FirstName = "Jan",
						LastName = "Muzykant",
						PhoneNumber = "000111222",
						Gender = Gender.Male
					},

					new PersonalInfo()
					{
						Id = 2,
						FirstName = "Maria",
						LastName = "Wiktorska",
						PhoneNumber = "111222333",
						Gender = Gender.Female
					}
				);

			modelBuilder.Entity<AdressInfo>()
				.HasData
				(
					new AdressInfo()
					{
						Id = 1,
						PostalCode = "00-000",
						PostalCity = "Przykład",
						Settlement = "Przykład",
						StreetName = "Przykładowa",
						StreetNumber = "1",
						HomeNumber = "2",
						UserId = 1
					},

					new AdressInfo()
					{
						Id = 2,
						PostalCode = "00-000",
						PostalCity = "Przykładowo",
						Settlement = "Przykładno",
						StreetName = "Przykładowa",
						StreetNumber = "1",
						HomeNumber = "2",
						UserId = 2
					}
				);

			modelBuilder.Entity<User>()
				.HasData
				(
					new User()
					{
						Id = 1,
						Email = "admin_email@email.com",
						Password = "G@garin12_",
						CreationDateTime = DateTime.Now,
						IsActive = true,
						Role = UserRole.Admin,
					},

					new User()
					{
						Id = 2,
						Email = "customer_email.email.com",
						Password = "G@garin12_",
						CreationDateTime = DateTime.Now,
						IsActive = true,
						Role = UserRole.Customer,
					}
				);
		}
	}
}
