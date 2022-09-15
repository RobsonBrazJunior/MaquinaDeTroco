using MaquinaDeTroco.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace MaquinaDeTroco.Infra.Data.Context
{
	public sealed class MaquinaDeTrocoContext : DbContext
	{
		public DbSet<User> Users { get; set; }

		public MaquinaDeTrocoContext(DbContextOptions<MaquinaDeTrocoContext> options) : base(options) { }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfigurationsFromAssembly(typeof(MaquinaDeTrocoContext).Assembly);
		}
	}
}
