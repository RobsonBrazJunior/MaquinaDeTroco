namespace MaquinaDeTroco.Infra.Data.Repository.Interfaces
{
	public interface IUnitOfWork : IDisposable
	{
		IUserRepository User { get; }
		int Save();
	}
}
