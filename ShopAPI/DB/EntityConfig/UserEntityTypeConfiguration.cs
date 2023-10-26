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
		}
	}
}
