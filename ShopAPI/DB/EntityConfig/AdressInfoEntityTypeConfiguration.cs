using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopAPI.Model;

namespace ShopAPI.DB.EntityConfig
{
	public class AdressInfoEntityTypeConfiguration : IEntityTypeConfiguration<AdressInfo>
	{
		public void Configure(EntityTypeBuilder<AdressInfo> builder)
		{
			builder
				.Property(a => a.PostalCode)
				.HasMaxLength(6)
				.IsRequired();

			builder
				.Property(a => a.PostalCity)
				.HasMaxLength(64)
				.IsRequired();

			builder
				.Property(a => a.Settlement)
				.HasMaxLength(64)
				.IsRequired();

			builder
				.Property(a => a.StreetName)
				.HasMaxLength(128);

			builder
				.Property(a => a.StreetNumber)
				.HasMaxLength(6);

			builder
				.Property(a => a.HomeNumber)
				.HasMaxLength(6)	
				.IsRequired();
		}
	}
}
