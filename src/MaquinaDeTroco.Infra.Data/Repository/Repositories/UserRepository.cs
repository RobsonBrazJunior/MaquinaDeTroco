using MaquinaDeTroco.Domain.Models;
using MaquinaDeTroco.Infra.Data.Context;
using MaquinaDeTroco.Infra.Data.Repository.Interfaces;

namespace MaquinaDeTroco.Infra.Data.Repository.Repositories
{
	public class UserRepository : GenericRepository<User>, IUserRepository
	{
		public UserRepository(MaquinaDeTrocoContext context) : base(context)
		{
		}
	}
}
