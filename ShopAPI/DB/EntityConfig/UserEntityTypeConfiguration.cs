using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopAPI.Model;

namespace ShopAPI.DB.EntityConfig
{
	public class UserEntityTypeConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			throw new NotImplementedException();
		}
	}
}
