using MaquinaDeTroco.Infra.Data.Context;
using MaquinaDeTroco.Infra.Data.Repository.Interfaces;

namespace MaquinaDeTroco.Infra.Data.Repository.Repositories
{
	public class UnitOfWork : IUnitOfWork
	{
		#region Fields
		private readonly MaquinaDeTrocoContext _context;
		private readonly IUserRepository _user;
		#endregion

		#region Properties
		public IUserRepository User => _user;
		#endregion

		public UnitOfWork(MaquinaDeTrocoContext context)
		{
			_context = context;
			_user = new UserRepository(context);
		}

		public int Save()
		{
			return _context.SaveChanges();
		}

		public void Dispose()
		{
			_context.Dispose();
			GC.SuppressFinalize(this);
		}
	}
}
