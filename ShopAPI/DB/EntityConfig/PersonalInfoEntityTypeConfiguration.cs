using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopAPI.Model;

namespace ShopAPI.DB.EntityConfig
{
	public class PersonalInfoEntityTypeConfiguration : IEntityTypeConfiguration<PersonalInfo>
	{
		public void Configure(EntityTypeBuilder<PersonalInfo> builder)
		{
			builder
				.Property(pi => pi.FirstName)
				.HasMaxLength(32)
				.IsRequired();

			builder
				.Property(pi => pi.LastName)
				.HasMaxLength(64)
				.IsRequired();

			builder
				.Property(pi => pi.PhoneNumber)
				.HasMaxLength(11)
				.IsRequired();
		}
	}
}
