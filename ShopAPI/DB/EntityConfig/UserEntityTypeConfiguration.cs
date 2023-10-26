using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopAPI.Model;

namespace ShopAPI.DB.EntityConfig
{
	public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder
				.HasIndex(u => u.Email)
				.IsUnique();

			builder
				.Property(u => u.Email)
				.HasMaxLength(128)
				.IsRequired();

			builder
				.Property(u => u.Password)
				.HasMaxLength(64)
				.IsRequired();

			builder
				.Property(u => u.Role)
				.IsRequired();

			builder
				.HasData
				(
					new User 
					{
						Id = 1,
						Email = "admin_email@email.com",
						Password = "G@garin12_",
						CreationDateTime = DateTime.Now,
						IsActive = true,
						Role = UserRole.Admin,
						PersonalInfo = new PersonalInfo
						{
							Id = 1,
							FirstName = "Jan",
							LastName = "Muzykant",
							PhoneNumber = "000111222",
							Gender = Gender.Male
						},
						AdressInfo = new AdressInfo
						{
							Id = 1,
							PostalCode = "00-000",
							PostalCity = "Przykład",
							Settlement = "Przykład",
							StreetName = "Przykładowa",
							StreetNumber = "1",
							HomeNumber = "2"
						}
					},
					new User
					{
						Id = 1,
						Email = "customer_email.email.com",
						Password = "G@garin12_",
						CreationDateTime = DateTime.Now,
						IsActive = true,
						Role = UserRole.Customer,
						PersonalInfo = new PersonalInfo
						{
							Id = 2,
							FirstName = "Maria",
							LastName = "Wiktorska",
							PhoneNumber = "111222333",
							Gender = Gender.Female
						},
						AdressInfo = new AdressInfo
						{
							Id = 2,
							PostalCode = "00-000",
							PostalCity = "Przykładowo",
							Settlement = "Przykładno",
							StreetName = "Przykładowa",
							StreetNumber = "1",
							HomeNumber = "2"
						}
					}
				);
		}
	}
}
