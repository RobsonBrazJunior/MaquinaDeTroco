using MaquinaDeTroco.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MaquinaDeTroco.Infra.Data.Context.Configurations
{
	public class UserConfiguration : IEntityTypeConfiguration<User>
	{
		public void Configure(EntityTypeBuilder<User> builder)
		{
			builder.ToTable("User");
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).HasColumnType("VARCHAR(100)").IsRequired();
			builder.Property(x => x.Password).HasMaxLength(16).IsRequired();
			builder.Property(x => x.Email).HasColumnType("VARCHAR(80)").IsRequired();
		}
	}
}
